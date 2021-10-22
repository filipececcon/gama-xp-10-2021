using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Infra.Data.Repositories
{
    public class CarBrandRepository : IQueryRepository<CarBrand>, ICommandRepository<CarBrand>
    {
        private static List<CarBrand> _brands = new List<CarBrand> {

            new CarBrand { Name = "Ford" },
            new CarBrand { Name = "Ford" },
            new CarBrand { Name = "VW" },
            new CarBrand { Name = "VW" },
            new CarBrand { Name = "Fiat" },
            new CarBrand { Name = "Porche" },

        };

        public CarBrand GetByName(string name)
        {
            return _brands.First(x => x.Name == name);
        }

        public void Add(CarBrand carBrand)
        {
            _brands.Add(carBrand);
        }
    }
}
