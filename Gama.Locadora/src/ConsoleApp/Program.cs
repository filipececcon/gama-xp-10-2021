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

            var command = new AddCarBrandCommandHandler(repository);

            var request = new AddCarBrandRequest() {  BrandName = "AlfaRomeo" };

            command.Handle(request);





            var request2 = new GetCarBrandByNameRequest() { Name = "AlfaRomeo" };

            var handler = new GetCarBrandByNameHandler(repository);

            var response = handler.Handle(request2);
            
        }
    }


    //CQRS => Command/Query Responsability Segregation


    

}
