using Ficha4.App_Data;
using Ficha4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ficha4.Controllers
{
    public class ConversorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListaDeMoedas = new SelectList(DadosExemplo.UnidadesMonetarias);

            return View();
        }

        //[HttpPost]
        //public IActionResult Converter(IFormCollection collection)
        //{
        //    Conversor con = new Conversor();

        //    con.UnidadeInicial = int.Parse(collection["UnidadeIncial"]);
        //    con.UnidadeFinal = int.Parse(collection["UnidadeFinal"]);
        //    con.ValorIncial = double.Parse(collection["ValorInicial"]);
        //    con.ValorFinal = double.Parse(collection["ValorFinal"]);
        //    con.TaxaDeCambio = 0.9;

        //    return View("Index", con);
        //}
    }
}
