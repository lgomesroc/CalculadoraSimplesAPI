using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraSimplesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraSimplesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet("Somar")]
        public ActionResult<Calculadora> Somar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.somar();
            return Ok(calc);
        }

        [HttpGet("Subtrair")]
        public ActionResult<Calculadora> Subtrair(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.subtrair();
            return Ok(calc);
        }

        [HttpGet("Multiplicar")]
        public ActionResult<Calculadora> Multiplicar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.multiplicar();
            return Ok(calc);
        }

        [HttpGet("Dividir")]
        public ActionResult<Calculadora> Dividir(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.dividir();
            return Ok(calc);
        }

        [HttpGet("Potencializar")]
        public ActionResult<Calculadora> Potencializar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.potencializar();
            return Ok(calc);
        }

        [HttpGet("Radicionalizar")]
        public ActionResult<Calculadora> Radicionalizar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.radicionalizar();
            return Ok(calc);
        }

        [HttpGet("Percentualizar")]
        public ActionResult<Calculadora> Percentualizar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.percentualizar();
            return Ok(calc);
        }
    }
}