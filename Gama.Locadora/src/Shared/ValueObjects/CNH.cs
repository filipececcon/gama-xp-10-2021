using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.ValueObjects
{
    public class CNH : ValueObject
    {
        public CNH(string cnh)
        {
            Value = cnh;
        }

        public string Value { get; private set; }

        public string Mask()
        {
            //mascarar um cpf sem mascara
            return "";
        }

        public string Unmask()
        {
            //desmascarat um cpf com mascara

            return "";
        }
    }
}
