using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetCarBrandByNameHandler : QueryHandler<IEnumerable<CarBrand>, GetCarBrandByNameRequest>
    {
        private List<CarBrand> _brands =  new List<CarBrand> {
        
            new CarBrand { Name = "Ford" },
            new CarBrand { Name = "Ford" },
            new CarBrand { Name = "VW" },
            new CarBrand { Name = "VW" },
            new CarBrand { Name = "Fiat" },
            new CarBrand { Name = "Porche" },
        
        };

        public override IEnumerable<CarBrand> Handle(GetCarBrandByNameRequest request)
        {
            return _brands.Where(x => x.Name == request.Name);
        }
    }
}
