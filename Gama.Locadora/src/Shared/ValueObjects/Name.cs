using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.ValueObjects
{
    public class Name : ValueObject
    {
        public Name()
        {

        }

        public Name(string fullname)
        {
            SetFrom(fullname);
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => GetBy();

        private string GetBy()
        {
            return $"{FirstName},{LastName}";
        }

        public void SetFrom(string fullname)
        {
            var address = fullname.Split(",");
            FirstName = address[0];
            LastName = address[1];
        }


    }
}
