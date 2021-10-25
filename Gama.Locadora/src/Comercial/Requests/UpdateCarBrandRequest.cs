using System;
using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Comercial.Requests
{
    public class UpdateCarBrandRequest : Request
    {
        public string BrandName { get; set; }

        public Guid Id { get; set; }
    }
}
