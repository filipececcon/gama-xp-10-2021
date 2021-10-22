using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Interfaces
{
    public interface IQueryRepository<TEntity> where TEntity : Entity
    {
        public TEntity GetByName(string name);
    }
}
