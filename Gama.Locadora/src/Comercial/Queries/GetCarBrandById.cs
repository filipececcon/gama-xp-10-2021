using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;
using System;

namespace Gama.Locadora.Comercial.Queries
{
    /// <summary>
    /// manipulador da consultado que buscar marca de carro por id
    /// </summary>
    public class GetCarBrandById : QueryHandler<CarBrand, GetByIdRequest>
    {
        private readonly IRepository<CarBrand> _repository;

        /// <summary>
        /// necessario informar um repositorio do tipo solicitado
        /// </summary>
        /// <param name="repository">repositoru com acesso a dados de marcas de carro</param>
        public GetCarBrandById(IRepository<CarBrand> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// execucao da consulta do objetos de acesso a dados
        /// </summary>
        /// <param name="request">objeto de requisicao para a consulta</param>
        /// <returns>marca do carro como resultado</returns>
        public override CarBrand Query(GetByIdRequest request)
        {
            return _repository.GetById(request.Id);
        }
    }

    /// <summary>
    /// Objeto de acesso a dado da tabela de modelos de carro
    /// </summary>
    public class CarBrandRepository : IRepository<CarBrand>
    {
        public CarBrand GetById(Guid id)
        {
            return new CarBrand { Name = "VW" };
        }
    }
}
