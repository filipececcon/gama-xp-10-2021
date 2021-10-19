using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Handlers
{
    //manipulador de consulta abstrato
    public abstract class QueryHandler<TResult, TRequest> 
        where TResult : class
        where TRequest : Request
    {
        /// <summary>
        /// Execucao da consulta
        /// </summary>
        /// <param name="request">tipo de requisicao</param>
        /// <returns>o tipo do resultado passado</returns>
        public abstract TResult Query(TRequest request);
        
    }
}
