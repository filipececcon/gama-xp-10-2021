using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Interfaces
{
    public interface IQueryRepository<TEntity> where TEntity : Entity
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    }
}
