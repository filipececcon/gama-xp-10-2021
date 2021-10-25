using System;
using Gama.Locadora.Comercial.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public class CarModelConfiguration : EntityConfiguration<CarModel>
    {
        public override void Configure(EntityTypeBuilder<CarModel> builder)
        {
            base.Configure(builder);

            builder.ToTable("TB_CAR_MODEL");

            builder
                .Property(x => x.Name)
                .HasColumnName("NM_MODEL");

            builder
                .Property(x => x.CarBrandId)
                .HasColumnName("ID_BRAND");

            builder
                .HasOne(model => model.Brand)
                .WithMany(brand => brand.Models)
                .HasForeignKey(model => model.CarBrandId);


            // MODEL(ID, ID_BRAND) <----  BRAND(ID)
        }
    }
}