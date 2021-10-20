using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Shared.Requests;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Torneiro();

            var of = new Oficina<Parafuso>(m1);

            var material = of.ConsertaMotor();

            Console.WriteLine($"Tipo: {material.GetType().Name} - Marca: {material.Marca} ");
        }
    }
}
