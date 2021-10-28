using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Infra.Data.Contexts;
using Gama.Locadora.Infra.Data.Repositories;
using Gama.Locadora.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarBrandController : ControllerBase
    {
        private readonly IQueryRepository<CarBrand> _repository;

        public CarBrandController(IQueryRepository<CarBrand> repository)
        {
            _repository = repository;
        }
                
        [HttpGet]
        public IActionResult GetAll()
        {
            var query = new GetAllCarBrandQueryHandler(_repository);

            var request = new GetAllCarBrandRequest();

            var result = query.Handle(request);

            return Ok(result);
        }
    }   
}
