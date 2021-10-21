using Microsoft.EntityFrameworkCore;
using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        public PSContext()
        {
            //Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ProductStoreDB-4BI4;Integrated Security=true");
        }
    }
}
