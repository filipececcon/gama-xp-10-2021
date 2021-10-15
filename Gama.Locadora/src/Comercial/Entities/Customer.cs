using Gama.Locadora.Shared.Entities;

namespace Gama.Locadora.Comercial.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}