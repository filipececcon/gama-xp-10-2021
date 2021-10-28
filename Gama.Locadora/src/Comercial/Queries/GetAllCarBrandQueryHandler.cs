using System;
using System.Collections.Generic;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetAllCarBrandQueryHandler : QueryHandler<CarBrand, GetAllCarBrandRequest, IEnumerable<CarBrand>>
    {
        public GetAllCarBrandQueryHandler(IQueryRepository<CarBrand> repository) : base(repository)
        {
        }

        public override IEnumerable<CarBrand> Handle(GetAllCarBrandRequest request)
        {
            return base._repository.Get();
        }
    }
}
