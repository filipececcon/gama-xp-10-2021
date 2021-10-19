using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Shared.Requests;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto padrao DTO para fazer a requisicao
            var request = new GetByIdRequest() { Id = Guid.NewGuid() };

            //objeto que faz acesso aos dados
            var repository = new CarBrandRepository();

            //objeto manipulador de consultas
            var query = new GetCarBrandById(repository);

            //execucao da consulta com o retorno no resultado
            var result = query.Query(request);
        }
    }
}
