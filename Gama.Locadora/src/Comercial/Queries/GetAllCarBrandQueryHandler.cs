using System;
using System.Collections.Generic;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Util;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetAllCarBrandQueryHandler : QueryHandler<CarBrand, GetAllCarBrandRequest, IEnumerable<CarBrand>>
    {
        public GetAllCarBrandQueryHandler(IQueryRepository<CarBrand> repository) : base(repository)
        {
        }

        public override IEnumerable<CarBrand> Handle(GetAllCarBrandRequest request)
        {
            var predicate = PredicateBuilder.New<CarBrand>();

            if (request.Active != null) predicate = predicate.And(x => x.IsActive == request.Active);

            if (request.Name != null) predicate = predicate.And(x => x.Name == request.Name);

            return base._repository.Get(predicate);
        }
    }
}
