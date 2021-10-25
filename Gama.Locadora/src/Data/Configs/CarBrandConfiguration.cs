using System;
using Gama.Locadora.Comercial.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public class CarBrandConfiguration : EntityConfiguration<CarBrand>
    {
        public override void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            base.Configure(builder);

            builder.ToTable("TB_CAR_BRAND");

            builder
                .Property(x => x.Name)
                .HasColumnName("NM_BRAND");

        }
    }
}

/*
TB_ tabela
VL_ valores grana
NR_ numeros
DS_ descriçao
NM_ nomes 
ST_ status numericos BIT 0 1
DT_ datas             
IX_
ID - pks
ID_ - fks
*/



// CodeFirst, ModelFirst, DatabaseFirst

// DatabaseFirst => banco primeiro, codigo depois
// CodeFirst => Codigo primeiro, banco depois
// ModelFirst => Modelo conceitual primeiro(as suas e a suas tabelas)
