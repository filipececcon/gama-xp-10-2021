using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Commands
{
    public class AddCarBrandCommandHandler : CommandHandler<CarBrand, Object, AddCarBrandRequest>
    {
        public AddCarBrandCommandHandler(ICommandRepository<CarBrand> repository) : base(repository)
        {
        }

        public override object Handle(AddCarBrandRequest request)
        {
            var newBrand = new CarBrand() { Name = request.BrandName };

            Repository.Add(newBrand);

            return null;
        }
    }
}
