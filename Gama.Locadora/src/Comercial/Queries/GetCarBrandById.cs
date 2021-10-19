using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;
using System;

namespace Gama.Locadora.Comercial.Queries
{
    public class GetCarBrandById : QueryHandler<CarBrand, GetByIdRequest>
    {
        private readonly IRepository<CarBrand> _repository;

        public GetCarBrandById(IRepository<CarBrand> repository)
        {
            _repository = repository;
        }

        public override CarBrand Query(GetByIdRequest request)
        {
            return _repository.GetById(request.Id);
        }


        
    }

    public class Qualquer : IRepository<CarBrand>
    {
        public CarBrand GetById(Guid id)
        {
            return new CarBrand { Name = "VW" };
        }
    }
}
