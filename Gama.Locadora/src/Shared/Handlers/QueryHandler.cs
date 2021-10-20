using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Handlers
{
    public abstract class QueryHandler<TResponse, TRequest>
        where TResponse : class
        where TRequest : Request
    {
        /// <summary>
        /// Execucao da consulta
        /// </summary>
        /// <param name="request">tipo de requisicao</param>
        /// <returns>o tipo do resultado passado</returns>
        public abstract TResponse Handle(TRequest request);
        
    }
}
