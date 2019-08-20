using GiveChange.Domain.Entities;
using GiveChange.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GiveChange.API.Controllers
{
    
    [Route("api/[Controller]")]
    public class TrocoController : Controller
    {
        private readonly ITrocoRepository _trocoRepository;
        public TrocoController (ITrocoRepository trocoRepository)
        {
            _trocoRepository = trocoRepository;
        }

        /// <summary>
        /// Retorna todos as movimentações de troco
        /// </summary>
        /// <returns></returns>  
        [HttpGet]
        public IActionResult Get()
        {

            try
            {

                return Ok(_trocoRepository.ObterTodos());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

       

        /// <summary>
        /// Retorna movimentação por Id
        /// /api/troco/id
        /// </summary>
        /// <returns></returns>  
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            try
            {
                return Ok(_trocoRepository.ObterPorId(id));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// Insere uma nova movimentação no banco de dados
        /// </summary>      
        [HttpPost]
        public IActionResult Post([FromBody]Troco troco)
        {

            try
            {
                decimal valorTroco = troco.ValorPago - troco.PrecoProduto;

                troco.ValorTroco = valorTroco;

                _trocoRepository.Adicionar(troco);
                return Created("api/troco", troco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
