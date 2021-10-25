using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Infra.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace Gama.Locadora.Infra.Data.Contexts
{
    public class RentCarStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //https://www.connectionstrings.com/sql-server/

            optionsBuilder.UseSqlServer("server=(localdb);database=RentCarStoreDb;");

            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CarBrandConfiguration().Configure(modelBuilder.Entity<CarBrand>());
            new CarModelConfiguration().Configure(modelBuilder.Entity<CarModel>());           
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

    }
}
