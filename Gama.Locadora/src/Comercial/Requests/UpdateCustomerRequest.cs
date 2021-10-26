using System;
using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Comercial.Requests
{
    public class UpdateCustomerRequest : Request
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string CNH { get; set; }
    }
}
