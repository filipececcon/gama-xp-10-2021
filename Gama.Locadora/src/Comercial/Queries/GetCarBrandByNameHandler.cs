using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetCarBrandByNameHandler : QueryHandler<CarBrand, CarBrand, GetCarBrandByNameRequest>
    {
        public GetCarBrandByNameHandler(IQueryRepository<CarBrand> repository) : base(repository)
        {
            
        }

        public override CarBrand Handle(GetCarBrandByNameRequest request)
        {
            return Repository.GetByName(request.Name);
        }

    }
}
