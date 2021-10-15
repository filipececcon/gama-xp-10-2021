using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Colecoes
    {
        public static string[] MeuArray()
        {
            var nomes = new string[] { "maria", "joao" };

            return nomes;
        }

        public static Stack<Object> MinhaPilha()
        {
            var pilha = new Stack<Object>();

            var obj = new { nome = "Filipe" };


            //adicionar no topo
            pilha.Push(obj);

            // remove do topo
            //pilha.Pop();

            //retorno o do topo sem remover
            //pilha.Peek();


            return pilha;
        }


        public static Queue<Object> MinhaFila()
        {
            var fila = new Queue<Object>();

            var obj = new { nome = "Filipe" };

            fila.Enqueue(obj);

            var oDaVez = fila.Dequeue();

            return fila;
        }

        public static List<Object> MinhaLista()
        {
            var lista = new List<Object>();

            var obj = new { nome = "Filipe" };

            lista.Add(obj);

            lista.Remove(obj);

            return lista;
        }
    }
}
