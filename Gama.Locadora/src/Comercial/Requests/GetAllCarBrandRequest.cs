using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Comercial.Requests
{
    public class GetAllCarBrandRequest : Request
    {
        public string Name { get; set; }
        public bool? Active { get; set; }
    }
}