using System;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.ValueObjects;

namespace Gama.Locadora.Comercial.Commands
{
    public class UpdateCustomerCommandHandler : CommandHandler<Customer, UpdateCustomerRequest, Object>
    {
        public UpdateCustomerCommandHandler(ICommandRepository<Customer> repository) : base(repository)
        {
        }

        public override object Handle(UpdateCustomerRequest request)
        {
            //var name = new Name() { FirstName = request.FirstName };

            //var cnh = new CNH(request.CNH);

            //var email = new Email() { Value = request.Email };

            //var dadosDoClienteParaAtualizar = new Customer(name, null, cnh, null, email);

            //Repository.Update(dadosDoClienteParaAtualizar, request.Id);

            return null;
        }
    }
}
