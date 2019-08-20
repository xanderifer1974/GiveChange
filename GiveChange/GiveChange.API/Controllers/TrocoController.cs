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
                int t100, t50, t20, t10, m50, m10, m05, m1;              

                t100 = 0;
                t50 = 0;
                t20 = 0;
                t10 = 0;
                m50 = 0;
                m10 = 0;
                m05 = 0;
                m1 = 0;

                double valorTroco = troco.ValorPago - troco.PrecoProduto;
                troco.ValorTroco = valorTroco;

                while (valorTroco >= 100)
                {
                    valorTroco -= 100;
                    t100++;
                }

                while (valorTroco >= 50)
                {
                    valorTroco -= 50;
                    t50++;
                }

                while (valorTroco >= 20)
                {
                    valorTroco -= 20;
                    t20++;
                }

                while (valorTroco >= 10)
                {
                    valorTroco -= 10;
                    t10++;
                }

                while (valorTroco >= 0.50)
                {
                    valorTroco -= 0.50;
                    m50++;
                }

                while (valorTroco >= 0.10)
                {
                    valorTroco -= 0.10;
                    m10++;
                }

                while (valorTroco >= 0.05)
                {
                    valorTroco -= 0.05;
                    m05++;
                }


                while (valorTroco >= 0.01)
                {
                    valorTroco -= 0.01;
                    m1++;
                }

                if (t100 > 0)
                {
                    troco.Nota100 = t100;
                }

                if (t50 > 0)
                {
                    troco.Nota50 = t50;
                }

                if (t20 > 0)
                {
                    troco.Nota20 = t20;
                }

                if (t10 > 0)
                {
                    troco.Nota10 = t10;
                }

                if (m50 > 0)
                {
                    troco.Moeda050 = m50;
                }

                if (m10 > 0)
                {
                    troco.Moeda010 = m10;
                }

                if (m05 > 0)
                {
                    troco.Moeda005 = m05;
                }

                if (m1 > 0)
                {
                    troco.Moeda001 = m1;
                }



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
