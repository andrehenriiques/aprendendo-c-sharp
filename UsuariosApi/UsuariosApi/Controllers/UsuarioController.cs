﻿
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
	[ApiController]
	[Route("[Controller]")]
	public class UsuarioController: ControllerBase
	{
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Cadastro")]
		public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
		{
			await _usuarioService.Cadastra(dto);

            return Ok("resultado Cadastrado!");

        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);

            return Ok(token);
        }
    }
}

