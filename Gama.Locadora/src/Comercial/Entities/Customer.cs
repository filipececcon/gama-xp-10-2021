using Gama.Locadora.Comercial.ValueObjects;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.ValueObjects;

namespace Gama.Locadora.Comercial.Entities
{
    public class Customer : Entity
    {
        public Customer(Name name, CPF cpf, CNH cnh, Address address, Email email, Phone phone = null)
        {
            Name = name;
            CPF = cpf;
            CNH = cnh;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public Name Name { get; set; }
        public CPF CPF { get; set; }
        public CNH CNH { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
    }
}