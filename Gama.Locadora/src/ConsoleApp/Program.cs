using Gama.Locadora.Comercial.Queries;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Ajudante();

            var metre = new Metre(funcionario);

            var prato = metre.FazerPedido();

            Console.WriteLine(prato.ToString());

        }
    }
}
