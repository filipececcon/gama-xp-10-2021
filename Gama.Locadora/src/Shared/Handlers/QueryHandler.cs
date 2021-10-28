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
    public abstract class QueryHandler<TEntity, TRequest, TResponse>
        //where TResponse : class
        where TEntity : Entity
        where TRequest : Request
    {
        protected readonly IQueryRepository<TEntity> _repository;

        public QueryHandler(IQueryRepository<TEntity> repository)
        {
            _repository = repository;
        }


        /// <summary>
        /// Execucao da consulta
        /// </summary>
        /// <param name="request">tipo de requisicao</param>
        /// <returns>o tipo do resultado passado</returns>
        public abstract TResponse Handle(TRequest request);
        
    }
}
