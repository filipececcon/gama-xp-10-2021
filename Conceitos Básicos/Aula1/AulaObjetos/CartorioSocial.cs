using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.AulaObjetos
{
    class CartorioSocial : Cartorio, ICasamento
    {
        public void Casar(PessoaFisica pessoa1, PessoaFisica pessoa2)
        {
            pessoa1.IsCasado = true;
            pessoa2.IsCasado = true;
        }
    }
}
