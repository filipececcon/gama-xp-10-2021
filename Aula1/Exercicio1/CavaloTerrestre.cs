using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Exercicio1
{
    public class CavaloTerrestre : Cavalo, IGalope
    {
        public CavaloTerrestre(string raça, string cor) : base(raça, cor, "terra")
        {
        }

        public string Galopar()
        {
            return "Galopeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeraaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        }
    }
}
