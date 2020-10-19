using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parking.EFCore.Dominio;
using Parking.EFCore.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parking.EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculosController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public IEnumerable<Veiculo> GetAll()
        {
            return _veiculoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetVeiculo")]
        public IActionResult GetById(long id)
        {
            var veiculo = _veiculoRepository.Find(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return new ObjectResult(veiculo);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Veiculo veiculo)
        {
            if (veiculo == null)
            {
                return BadRequest();
            }

            if (_veiculoRepository.Add(veiculo))
            {
                return CreatedAtRoute("GetVeiculo", new { id = veiculo.Id }, veiculo);
            }

            return BadRequest();
            
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Veiculo veiculo)
        {
            if (veiculo == null || veiculo.Id == id)
            {
                return BadRequest();
            }

            var _veiculo = _veiculoRepository.Find(id);

            if (_veiculo == null)
            {
                return NotFound();
            }

            _veiculo.Marca = veiculo.Marca;
            _veiculo.Modelo = veiculo.Modelo;
            _veiculo.Placa = veiculo.Placa;
            _veiculo.Tipo = veiculo.Tipo;

            _veiculoRepository.Update(_veiculo);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (id == 0)
            {
                return BadRequest();
            }            

            _veiculoRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
