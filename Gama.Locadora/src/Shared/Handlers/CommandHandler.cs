using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Handlers
{
    public abstract class CommandHandler<TEntity, TRequest, TResponse>
        where TRequest : Request
        where TEntity : Entity
    {
        protected readonly ICommandRepository<TEntity> Repository;

        protected CommandHandler(ICommandRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public abstract TResponse Handle(TRequest request);
    }
}
