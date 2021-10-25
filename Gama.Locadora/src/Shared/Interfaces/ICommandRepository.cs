﻿using Gama.Locadora.Shared.Entities;
using System;

namespace Gama.Locadora.Shared.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);

        void Update(TEntity entity, Guid id);

        void Remove(TEntity entity);

        void Remove(Guid id);
    }
}
