using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.ValueObjects;
using Gama.Locadora.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public class CustomerConfiguration : EntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);

            builder.ToTable("TB_CUSTOMER");

            builder
                .Property(x => x.Name)
                .HasColumnName("NM_CUSTOMER")
                .HasConversion(
                  nome => nome.FullName,
                  valorDoBanco => new Name(valorDoBanco)
                );

            builder
                .Property(x => x.CPF)
                .HasColumnName("DS_CPF")
                .HasConversion(
                  cpf => cpf.Value,
                  valorDoBanco => new CPF(valorDoBanco)
                 );


            builder
               .Property(x => x.CNH)
               .HasColumnName("DS_CNH")
               .HasConversion(
                 cnh => cnh.Value,
                 valorDoBanco => new CNH(valorDoBanco)
                );

            builder
               .Property(x => x.Address)
               .HasColumnName("DS_ADDRESS")
               .HasConversion(
                 address => address.FullAddress,
                 valorDoBanco => new Address(valorDoBanco)
                );

            builder
                .Property(x => x.Email)
                .HasColumnName("DS_EMAIL")
                .HasConversion(
                   email => email.Value,
                   valorDoBanco => new Email() { Value = valorDoBanco }
                );

            builder
                .Property(x => x.Phone)
                .HasColumnName("DS_PHONE")
                .HasConversion(
                   phone => phone.FullPhone,
                   valorDoBanco => new Phone(valorDoBanco)
                );

        }

    }
}
