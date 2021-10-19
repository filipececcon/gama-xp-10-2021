using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.Interfaces
{
    /// <summary>
    /// Interface para determinar comportamentos de consulta a base de dados
    /// </summary>
    //public interface IRepository<TEntity> where TEntity : Entity
    //{
    //    TEntity GetById(Guid id);
    //    IQueryable<TEntity> GetAll();
    //}

    //vai dizer o que a classe deve fazer
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public TEntity GetById(Guid id);
    }

    
}
