using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Comercial.Commands
{
    public class RemoveCarBrandByIdCommandHandler : CommandHandler<CarBrand, GetByIdRequest, Object>
    {
        public RemoveCarBrandByIdCommandHandler(ICommandRepository<CarBrand> repository) : base(repository)
        {
        }

        public override object Handle(GetByIdRequest request)
        {
            var entity = _repository.GetById(request.Id);

            _repository.Remove(entity);

            _repository.Save();

            return null;
        }
    }
}
