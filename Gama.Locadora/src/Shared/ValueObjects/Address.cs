using Gama.Locadora.Shared.ValueObjects;

namespace Gama.Locadora.Comercial.ValueObjects
{
    public class Address : ValueObject
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress => GetBy();

        private string GetBy()
        {
            return $"{Country},{State},{City},{Neighbourhood},{Street},{Number},{Complement},{ZipCode}";
        }

        private void SetFrom(string fullAddress)
        {
            var address = fullAddress.Split(",");

            Country = address[0];
            State = address[1];
            City = address[2];
            Neighbourhood = address[3];
            Street = address[4];
            Number = address[5];
            Complement = address[6];
            ZipCode = address[7];
        }

    }
}