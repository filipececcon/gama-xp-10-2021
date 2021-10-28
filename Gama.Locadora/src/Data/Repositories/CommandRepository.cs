using System;
using Gama.Locadora.Infra.Data.Contexts;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;

namespace Gama.Locadora.Infra.Data.Repositories
{
    public class CommandRepository<TEntity> : ICommandRepository<TEntity> where TEntity : Entity
    {
        private readonly RentCarStoreContext _context;

        public CommandRepository(RentCarStoreContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);           
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);            
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);          
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
