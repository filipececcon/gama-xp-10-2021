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
            var brand = new CarBrand() { Name = request.BrandName };

            Repository.Update(brand, request.Id);

            return null;
        }
    }
}
