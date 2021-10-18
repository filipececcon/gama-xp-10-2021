using Gama.Locadora.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.ValueObjects
{
    public class LicensePlate : ValueObject
    {
        public string Value { get; set; }
        public bool IsMercosul => !Value.Contains("-");
    }
}
