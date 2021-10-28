using Gama.Locadora.Shared.Entities;
using System;

namespace Gama.Locadora.Shared.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);

        TEntity GetById(Guid id);

        void Save();
    }
}
