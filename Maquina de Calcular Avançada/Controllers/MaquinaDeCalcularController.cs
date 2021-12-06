using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CalculadoraSimples;
using Maquina_de_Calcular_Avançada.Models;

namespace MaquinaDeCalcular.Controllers
{
    public class MaquinaDeCalcularController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculadoraModel());
        }

        [HttpPost]
        public IActionResult Index([Bind(include:"op1,op2,NDigitos")] CalculadoraModel calculadora, string Operacao)
        {
            calculadora.resultado = calculadora.op1 + " " + Operacao + " " + calculadora.op2 + " = " +  
                MaquinaCalcular.Calcular(   calculadora.op1,
                                            getOperador(Operacao) ,
                                            calculadora.op2,
                                            calculadora.NDigitos);
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
