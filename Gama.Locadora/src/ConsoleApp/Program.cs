using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Requests;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //pegar a entidade CarBrand onde o nome eh igual ao que eu passar

            var handler = new GetCarBrandByNameHandler();

            var request = new GetCarBrandByNameRequest() { Name = "Ford" };

            var response = handler.Handle(request);
        }


       
    }
}
