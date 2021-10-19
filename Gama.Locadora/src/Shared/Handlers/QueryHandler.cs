using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Handlers
{
    public abstract class QueryHandler<TResult, TRequest> 
        where TResult : class
        where TRequest : Request
    {
        public abstract TResult Query(TRequest request);
        
    }
}
