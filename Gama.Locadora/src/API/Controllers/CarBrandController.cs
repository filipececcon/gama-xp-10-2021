using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gama.Locadora.Comercial.Commands;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Infra.Data.Contexts;
using Gama.Locadora.Infra.Data.Repositories;
using Gama.Locadora.Shared.Handlers;
using Gama.Locadora.Shared.Interfaces;
using Gama.Locadora.Shared.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarBrandController : ControllerBase
    {
        private readonly IQueryRepository<CarBrand> _qRepository;
        private readonly ICommandRepository<CarBrand> _cmdRepository;

        public CarBrandController(IQueryRepository<CarBrand> qRepository, ICommandRepository<CarBrand> cmdRepository)
        {
            _qRepository = qRepository;
            _cmdRepository = cmdRepository;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] GetAllCarBrandRequest request)
        {
            var query = new GetAllCarBrandQueryHandler(_qRepository);

            var result = query.Handle(request);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var query = new GetByIdQueryHandler<CarBrand>(_qRepository);

            var request = new GetByIdRequest() { Id = id };

            var result = query.Handle(request);

            return Ok(result);
        }


        [HttpPost]
        public IActionResult Add([FromBody] AddCarBrandRequest request)
        {
            var command = new AddCarBrandCommandHandler(_cmdRepository);

            var result = command.Handle(request);

            return Created("", result);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateCarBrandRequest request)
        {
            var command = new UpdateCarBrandCommandHandler(_cmdRepository);

            request.Id = id;

            var result = command.Handle(request);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            var query = new RemoveCarBrandByIdCommandHandler(_cmdRepository);

            var request = new GetByIdRequest() { Id = id };

            var result = query.Handle(request);

            return Ok(result);
        }
    }   
}
