using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);

    }
}
