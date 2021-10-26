using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public class CarConfiguration : EntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);

            builder.ToTable("TB_CAR");

            builder
                .Property(x => x.ModelId)
                .HasColumnName("ID_MODEL");

            builder
                .Property(x => x.YearModel)
                .HasColumnName("NR_YEAR_MODEL");

            builder
                .Property(x => x.YearManufactured)
                .HasColumnName("NR_YEAR_MANUFACTURED");

            builder
                .Property(x => x.Color)
                .HasColumnName("DS_COLOR");

            builder
                .Property(x => x.IsRented)
                .HasColumnName("ST_RENTED");

            builder
                .Property(x => x.DiaryPrice)
                .HasColumnName("VL_DIARY_PRICE");

            builder
                .Property(x => x.LicensePlate)
                .HasColumnName("DS_LICENCE_PLATE")
                .HasConversion(
                    //apenas conversao do tipo complexo 

                    //conversao para armazanamento no banco
                    placa => placa.Value,

                    //conversao do dado do banco para o tipo complexo
                    valorDoBanco => new LicensePlate() { Value = valorDoBanco }
                );


            builder
                .HasOne(x => x.Model)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.ModelId);
        }
    }
}


//TABELA -> DS_PLACA = AAA1234

// MinhaClass.Placa(string) = "AAA1234
