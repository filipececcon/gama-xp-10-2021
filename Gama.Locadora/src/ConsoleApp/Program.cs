using Gama.Locadora.Comercial.Queries;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CarBrandRepository();

            var consulta = new GetCarBrandById(repository);

            var result = consulta.Query();
        }
    }
}
