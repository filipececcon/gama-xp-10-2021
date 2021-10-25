using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Infra.Data.Contexts;
using Gama.Locadora.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gama.Locadora.Infra.Data.Repositories
{
    public class CarBrandRepository : IQueryRepository<CarBrand>, ICommandRepository<CarBrand>
    {
        private RentCarStoreContext _context;

        public CarBrandRepository()
        {
            _context = new RentCarStoreContext();
        }

        public CarBrand GetByName(string name)
        {
            return _context.CarBrands.First(x => x.Name == name);
        }

        public void Add(CarBrand carBrand)
        {
           _context.CarBrands.Add(carBrand);
        }

        public void Update(CarBrand entity, Guid id)
        {
            var carBrand = _context.CarBrands.Single(x => x.Id == id);

            carBrand.Name = entity.Name;

            carBrand.UpdatedAt = DateTime.Now;
        }

        public void Remove(CarBrand entity)
        {
            _context.CarBrands.Remove(entity);
        }

        public void Remove(Guid id)
        {
            var result = _context.CarBrands.Find(id);

            _context.CarBrands.Remove(result);
        }      
    }
}