using System;
using Ficha4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Ficha4.App_Data;

namespace Ficha4.Controllers
{
    public class UnidadeMonetariaController : Controller
    {

        public IActionResult Index()
        {
            return View("Listar", DadosExemplo.UnidadesMonetarias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                UnidadeMonetaria um = new UnidadeMonetaria
                {
                    Id = DadosExemplo.GetId(),
                    Codigo = collection["Codigo"],
                    Valor = Double.Parse(collection["Valor"]),
                    Data = DateTime.Now
                };
                DadosExemplo.UnidadesMonetarias.Add(um);



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(DadosExemplo.UnidadesMonetarias.FirstOrDefault(um => um.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var um = DadosExemplo.UnidadesMonetarias.FirstOrDefault(um => um.Id == id);
                if (um != null)
                {
                    um.Codigo = collection["Codigo"];
                    um.Valor = Double.Parse(collection["Valor"]);
                    um.Data = DateTime.Now;
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var um = DadosExemplo.UnidadesMonetarias.FirstOrDefault(um => um.Id == id);
            return View(um);
        }

        public ActionResult Delete(int id)
        {
            return View(DadosExemplo.UnidadesMonetarias.FirstOrDefault(um => um.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var um = DadosExemplo.UnidadesMonetarias.FirstOrDefault(um => um.Id == id);
                if (um != null)
                    DadosExemplo.UnidadesMonetarias.Remove(um);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }


}
