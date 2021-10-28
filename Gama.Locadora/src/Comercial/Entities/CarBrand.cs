using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Entities
{
    public class CarBrand : Entity
    {
        private CarBrand()
        {

        }

        public CarBrand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<CarModel> Models { get; set; }
    }
}
