﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Olcer_DAL.Concrete
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UVMSNSF;Initial Catalog=Bilgi_Olcer;Integrated Security=True");
        }
 

        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }

    }
}
