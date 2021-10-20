using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Shared.Requests;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var funcionario = new Funcionario<Hamburguer>();

            //    var ff = new FastFood<Hamburguer>(funcionario);

            //    var comida = ff.ServirComida();

            //    Console.WriteLine($"Tipo: { comida.GetType().Name }, Ingredientes: { String.Join(",", comida.Ingredientes) }");


            var numeros = new int[] { 1, 6, 9, 20 };

            var nomes = new string[] { " jose", "joao", "maria"};

            Imprime<string>(nomes);
        }


        static void Imprime<T>(T[] array)
        {

            foreach(var item  in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
