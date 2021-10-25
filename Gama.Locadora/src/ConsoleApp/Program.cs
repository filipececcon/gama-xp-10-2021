using Gama.Locadora.Comercial.Commands;
using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Infra.Data.Repositories;
using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CarBrandRepository();

            //var command = new AddCarBrandCommandHandler(repository);

            //var request = new AddCarBrandRequest("Fiat");

            var command = new UpdateCarBrandCommandHandler(repository);

            var idmanual = repository.PegaUm();

            var request = new UpdateCarBrandRequest() { BrandName = "Ferrari", Id = idmanual };

            command.Handle(request);

            var response = command.Handle(request);
            
        }
    }


    //CQRS => Command/Query Responsability Segregation


    

}
