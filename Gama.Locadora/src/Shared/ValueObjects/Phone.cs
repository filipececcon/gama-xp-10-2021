using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Shared.ValueObjects
{
    public class Phone
    {
        public Phone()
        {

        }

        public Phone(string fullphone)
        {
            SetFrom(fullphone);
        }


        public string ContryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string FullPhone => GetBy();
        public bool IsMobile => Number.Length == 9;

        private string GetBy()
        {
            return $"+{ContryCode} {AreaCode} {Number}";
        }

        private void SetFrom(string fullphone)
        {
            var phone = fullphone.Split(" ");

            ContryCode = phone[0].Replace("+","");
            AreaCode = phone[1];
            Number = phone[2];
        }
    }
}
