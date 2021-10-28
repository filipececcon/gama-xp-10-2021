using System;
using System.Collections.Generic;
using System.Linq;
using Gama.Locadora.Infra.Data.Contexts;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gama.Locadora.Infra.Data.Repositories
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity> where TEntity : Entity
    {
        private readonly RentCarStoreContext _context;

        public QueryRepository(RentCarStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().AsNoTracking().Single(x => x.Id == id);
        }
    }
}
