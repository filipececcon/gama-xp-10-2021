using System;

namespace Gama.Locadora.Shared.Requests
{
    public class GetByIdRequest : Request
    {
        public Guid Id { get; set; }
    }
}
