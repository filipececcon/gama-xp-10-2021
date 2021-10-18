using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetCarBrandById
    {
        private readonly IRepository<CarBrand> _repository;

        public GetCarBrandById(IRepository<CarBrand> repository)
        {
            _repository = repository;
        }

        public string Query()
        {
            var result = _repository.GetById();

            return result.Name;
        }

       
    }

    public class CarBrandRepository : IRepository<CarBrand>
    {
        public CarBrand GetById()
        {
            return new CarBrand { Name = "Jeruza" };
        }
    }

    
}    