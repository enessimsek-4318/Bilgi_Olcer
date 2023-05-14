using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using System.Net;
using RestSharp;
using System.Net.Http;
using Bilgi_Olcer.Identity;
//using Method = RestSharp.Method;

namespace Bilgi_Olcer.Controllers
{
    public class BookController : Controller
    {
        private readonly HttpClient _httpClient;
        public BookController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://api.collectapi.com/book/search?data.query=harry%20potter");
        }
        public IActionResult Index()
        {

            return View();
        }
        public async Task<IActionResult> Search()
        {
            var response = await _httpClient.GetAsync("/users");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<ResponseModel>>(jsonString);
                return View(users);
            }
            return View("Error");
            //var client = new RestClient("https://api.collectapi.com/book/search?data.query=harry%20potter");
            //var request = new RestRequest(RestSharp.Method.Get.ToString());
            //request.AddHeader("authorization", "apikey 0YdkTVlaiOH8CH3YD1lHfO:55ibkZtiP3VdWgxgFC5nuk");
            //request.AddHeader("content-type", "application/json");
            //RestResponse response = client.Execute(request);
            return View();
        }

    }
    public class ResponseModel
    {
        public string name { get; set; }
        public string url { get; set; }
        public string img { get; set; }
        public string oldprice { get; set; }
        public string price { get; set; }
        public string author { get; set; }
    }
    //public interface IRestResponse
    //{        
    //    public string name { get; set; }
    //    public string url { get; set; }
    //    public string img { get; set; }
    //    public string oldprice { get; set; }
    //    public string price { get; set; }
    //    public string author { get; set; }
    //}
    //public class RestResponse : IRestResponse
    //{
    //    public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string img { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string oldprice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}
}
