﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MindPlus.Api.Contracts.Repository.Empresa;
using MindPlus.Api.Dto.Empresa;
using Swashbuckle.AspNetCore.Annotations;

namespace MindPlus.Api.Controllers.Empresa
{
    [ApiController]
    [Route("empresa")]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        /// <summary>
        /// Cadastrar uma empresa.
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "admin")]
        [SwaggerOperation(Summary = "Cadastrar uma empresa", Description = "Requer autenticação como 'admin'.")]
        public async Task<IActionResult> CadastrarEmpresa(EmpresaDto empresa)
        {
            await _empresaRepository.CadastrarEmpresa(empresa);
            return Ok(new { message = "Empresa cadastrada com sucesso!" });
        }

        /// <summary>
        /// Visualizar uma empresa.
        /// </summary>
        [HttpGet("{id:int}")]
        //[Authorize]
        [SwaggerOperation(Summary = "Visualizar empresa", Description = "Visualiza uma empresa de acordo com o Id passado por parâmetro.")]
        public async Task<IActionResult> ObterEmpresaPorId(int id)
        {
            return Ok(await _empresaRepository.ObterPorId(id));
        }
    }
}
