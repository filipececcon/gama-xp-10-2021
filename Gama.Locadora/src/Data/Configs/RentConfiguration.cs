using System;
using Gama.Locadora.Comercial.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public class RentConfiguration : EntityConfiguration<Rent>
    {
        public override void Configure(EntityTypeBuilder<Rent> builder)
        {
            base.Configure(builder);

            builder.ToTable("TB_RENT");

            builder
                .Property(x => x.Price)
                .HasColumnName("VL_PRICE");

            builder
              .Property(x => x.Tax)
              .HasColumnName("VL_TAX");

            builder
              .Property(x => x.StartDate)
              .HasColumnName("DT_START");

            builder
              .Property(x => x.EndDate)
              .HasColumnName("DT_END");

            builder
                .Property(x => x.CustomerId)
                .HasColumnName("ID_CUSTOMER");


            builder
                .Property(x => x.CarId)
                .HasColumnName("ID_CAR");

            builder
                .HasOne(x => x.Customer)
                .WithMany(x => x.Rents)
                .HasForeignKey(x => x.CustomerId);

            builder
                .HasOne(x => x.Car)
                .WithMany(x => x.Rents)
                .HasForeignKey(x => x.CarId);
        }

    }
}
