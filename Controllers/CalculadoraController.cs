using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraSimplesAPI.Models;
using CalculadoraSimplesAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraSimplesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraService _calculadoraService;
        public CalculadoraController(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        [HttpGet("Somar")]
        public IActionResult Somar(double valor1, double valor2)
        {
            return Ok(_calculadoraService.somar(valor1, valor2));
        }

        [HttpGet("Subtrair")]
        public IActionResult Subtrair(double valor1, double valor2)
        {
            return Ok(_calculadoraService.subtrair(valor1, valor2));
        }

        [HttpGet("Multiplicar")]
        public IActionResult Multiplicar(double valor1, double valor2)
        {
            return Ok(_calculadoraService.multiplicar(valor1, valor2));
        }

        [HttpGet("Dividir")]
        public IActionResult Dividir(double valor1, double valor2)
        {
            return Ok(_calculadoraService.dividir(valor1, valor2));
        }

        [HttpGet("Potencializar")]
        public IActionResult Potencializar(double valor1, double valor2)
        {
            return Ok(_calculadoraService.potencializar(valor1, valor2));
        }

        [HttpGet("Radicionalizar")]
        public IActionResult Radicionalizar(double valor1, double valor2)
        {
            return Ok(_calculadoraService.radicionalizar(valor1, valor2));
        }

        [HttpGet("Percentualizar")]
        public IActionResult Percentualizar(double valor1, double valor2)
        {
            return Ok(_calculadoraService.percentualizar(valor1, valor2));
        }
    }
}