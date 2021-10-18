using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.ValueObjects
{
    public class Email : ValueObject
    {
        public string Value { get; set; }

        public string Domain => GetDomain();

        private string GetDomain()
        {
            return Value.Split("@")[1];
        }
    }
}
