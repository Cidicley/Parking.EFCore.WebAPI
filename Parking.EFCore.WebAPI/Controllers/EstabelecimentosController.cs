using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;

namespace Parking.EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentosController : ControllerBase
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;

        public EstabelecimentosController(IEstabelecimentoRepository estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        [HttpGet]
        public IEnumerable<Estabelecimento> GetAll()
        {
            return _estabelecimentoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetEstabelecimento")]
        public IActionResult GetById(long id)
        {
            var model = _estabelecimentoRepository.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            return new ObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Estabelecimento estabelecimento)
        {
            if (estabelecimento == null)
            {
                return BadRequest();
            }

            if (_estabelecimentoRepository.Add(estabelecimento))
                return CreatedAtRoute("GetEstabelecimento", new { id = estabelecimento.Id }, estabelecimento);
            else
                return BadRequest();
        }

    }
}
