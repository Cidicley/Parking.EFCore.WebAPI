using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parking.EFCore.Dominio;
using Parking.EFCore.Repository.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parking.EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroVeiculosController : ControllerBase
    {
        private readonly IRegistroVeiculoRepository _registroVeiculoRepository;

        public RegistroVeiculosController(IRegistroVeiculoRepository registroVeiculoRepository)
        {
            _registroVeiculoRepository = registroVeiculoRepository;
        }

        [HttpGet]
        public IEnumerable<RegistroVeiculo > GetAll()
        {
            return _registroVeiculoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetRegistroVeiculo")]
        public IActionResult GetById(long id)
        {
            var registroVeiculo = _registroVeiculoRepository.Find(id);

            if (registroVeiculo == null)
            {
                return NotFound();
            }

            return new ObjectResult(registroVeiculo);
        }        

        [HttpPost(Name = "PostEntrada")]
        public IActionResult Entrada([FromBody] RegistroVeiculo registroVeiculo)
        {
            if (registroVeiculo == null)
            {
                return BadRequest();
            }

            if (_registroVeiculoRepository.EntradaVeiculo(registroVeiculo))
            {
                return CreatedAtRoute("GetRegistroVeiculo", new { id = registroVeiculo.Id }, registroVeiculo);
            }
            else
            {
                return BadRequest();
            }            
        }

        [HttpPut]
        public IActionResult Saida([FromBody] Veiculo veiculo)
        {
            if (veiculo == null)
            {
                return BadRequest();
            }            

            if (_registroVeiculoRepository.SaidaVeiculo(veiculo))
            {
                return new NoContentResult(); 
            }
            else
            {
                return NotFound();
            }            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var _veiculo = _registroVeiculoRepository.Find(id);

            if (_veiculo == null)
            {
                return NotFound();
            }

            _registroVeiculoRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
