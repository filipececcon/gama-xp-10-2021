using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Carros
{
    public class Carro
    {
        public int Combustivel { get; set; }

        public Carro(int combustivel)
        {
            Combustivel = combustivel;
        }


        public void Acelerar()
        {
            Combustivel -= 10;
        }

    }
}
