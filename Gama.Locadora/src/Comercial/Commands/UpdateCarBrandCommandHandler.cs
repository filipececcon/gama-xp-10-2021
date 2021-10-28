using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;

namespace Gama.Locadora.Comercial.Commands
{
    public class UpdateCarBrandCommandHandler : CommandHandler<CarBrand, UpdateCarBrandRequest, Object>
    {
        public UpdateCarBrandCommandHandler(ICommandRepository<CarBrand> repository) : base(repository)
        {
        }

        public override object Handle(UpdateCarBrandRequest request)
        {
            var brand = _repository.GetById(request.Id);
                        
            brand.Name = request.BrandName;
             
            var result = _repository.Update(brand);

            _repository.Save();

            return result;
        }
    }
}
