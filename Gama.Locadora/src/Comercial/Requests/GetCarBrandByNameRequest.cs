using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Requests
{
    public class GetCarBrandByNameRequest : Request
    {
        public string Name { get; set; }

    }
}
