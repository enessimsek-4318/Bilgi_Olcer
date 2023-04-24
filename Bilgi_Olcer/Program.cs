using Bilgi_Olcer.Identity;
using Bilgi_Olcer_BLL.Absract;
using Bilgi_Olcer_BLL.Concrete;
using Bilgi_Olcer_DAL.Abstract;
using Bilgi_Olcer_DAL.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<UserIdentityDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));


builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<UserIdentityDbContext>()
    .AddDefaultTokenProviders();
var userManager = builder.Services.BuildServiceProvider().GetService<UserManager<User>>();
var roleManager = builder.Services.BuildServiceProvider().GetService<RoleManager<IdentityRole>>();

builder.Services.AddScoped<IQuestionDal, QuestionDal>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();

builder.Services.AddScoped<IResultDal, ResultDal>();
builder.Services.AddScoped<IResultService, ResultManager>();

builder.Services.AddScoped<IAdminDal, AdminDal>();
builder.Services.AddScoped<IAdminService, AdminManager>();

builder.Services.Configure<IdentityOptions>(options =>
{
    //password

    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = true;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
    options.LogoutPath = "/User/Logout";
    options.AccessDeniedPath = "/User/accessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = "Bilgi_Olcer.Security.Cookie",
        SameSite = SameSiteMode.Strict 
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
});
SeedDatabase.Seed();
app.Run();
