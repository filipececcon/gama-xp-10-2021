using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Infra.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace Gama.Locadora.Infra.Data.Contexts
{
    public class RentCarStoreContext : DbContext
    {
        public RentCarStoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //https://www.connectionstrings.com/sql-server/

            //optionsBuilder.UseSqlServer("server=(localdb);database=RentCarStoreDb;");

            optionsBuilder.UseSqlServer("Server=localhost;Database=RentCarStoreDb;User Id=sa;Password=yourStrong(!)Password;");
                       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CarBrandConfiguration().Configure(modelBuilder.Entity<CarBrand>());
            new CarModelConfiguration().Configure(modelBuilder.Entity<CarModel>());
            new CustomerConfiguration().Configure(modelBuilder.Entity<Customer>());
            new RentConfiguration().Configure(modelBuilder.Entity<Rent>());
            new CarConfiguration().Configure(modelBuilder.Entity<Car>());
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Car> Cars { get; set; }



    }
}
