using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Entities
{
    public class CarModel : Entity
    {
        public string Name { get; set; }
        public CarBrand Brand { get; set; }
        public Guid CarBrandId { get; set; }
    }
}
