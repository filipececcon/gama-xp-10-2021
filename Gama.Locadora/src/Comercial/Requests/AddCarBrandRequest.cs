using Gama.Locadora.Shared.Requests;

namespace Gama.Locadora.Comercial.Requests
{
    public class AddCarBrandRequest : Request
    {
        public AddCarBrandRequest(string brandName)
        {
            BrandName = brandName;
        }

        public string BrandName { get; set; }
    }
}