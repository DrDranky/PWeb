using Microsoft.AspNetCore.Mvc;
using MaquinaDeCalcular.Models;
using Microsoft.AspNetCore.Http;
using CalculadoraSimples;

namespace MaquinaDeCalcular.Controllers
{
    public class MaquinaDeCalcularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind(include:"op1,op2")] CalculadoraViewModel calculadora, string Operacao)
        {
            calculadora.resultado = MaquinaCalcular.Calcular(calculadora.op1, getOperador(Operacao) , calculadora.op2, 2);
            return View(calculadora);
        }

        [NonAction]
        private TipoOperador getOperador(string op)
        {
            switch (op)
            {
                case "-": return TipoOperador.subtracao;
                case "x": return TipoOperador.multiplicacao;                    
                case "%": return TipoOperador.divisao;
            }
            return TipoOperador.adicao;

        }

    }
}
