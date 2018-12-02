using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestDrivenDevelopment.Capitulo._10.Entities;

namespace TestDrivenDevelopment.Capitulo._10.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DbSet<Produto> Produto { get; set; }

        public string ConnectionString => new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build().GetConnectionString("DefaultConnection");

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
