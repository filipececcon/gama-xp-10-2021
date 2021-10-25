using System;
using Gama.Locadora.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gama.Locadora.Infra.Data.Configs
{
    public abstract class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID");

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("DT_CREATED");

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnName("DT_UPDATED");

            builder
                .Property(x => x.IsActive)
                .HasColumnName("ST_ACTIVE");
        }
    }
}
