using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using System;

namespace Gama.Locadora.Comercial.Commands
{
    public class AddCarBrandCommandHandler : CommandHandler<CarBrand, AddCarBrandRequest, Object>
    {
        public AddCarBrandCommandHandler(ICommandRepository<CarBrand> repository) : base(repository)
        {
        }

        public override object Handle(AddCarBrandRequest request)
        {
            var newCarBrand = new CarBrand(request.BrandName);

            Repository.Add(newCarBrand);

            return newCarBrand;
        }
    }
}
