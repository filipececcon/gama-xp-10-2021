using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Shared.Requests;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Qualquer();

            var query = new GetCarBrandById(repository);

            var request = new GetByIdRequest() { Id = Guid.NewGuid() };

            var result = query.Query(request);

        }
    }
}
