using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF(string cpf)
        {
            Value = cpf;
        }

        public string Value { get; private set; }

        public string Mask()
        {
            //mascarar um cpf sem mascara
            return "";
        }

        public string Unmask()
        {
            //desmascarar um cpf com mascara

            return "";
        }

    }
}
