using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Exercicio1
{
    public class Passaro : Animal
    {
        public Passaro(bool carnivoro, string porte, string habitat): base(false, 2, habitat)
        {
            var portes = new string[] { "pequeno", "medio", "grande" };

            Carnivoro = carnivoro;

            Porte = portes.Contains(porte) ? porte : null;
        }

        public bool Carnivoro { get; set; }
        public string Porte { get; set; }
    }

    
}
