using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWebDeCarros.Models;

namespace SistemaWebDeCarros.Controllers
{
    public class CarrosController : Controller
    {
        private SistemaWebDeCarrosContext context;
        public CarrosController(SistemaWebDeCarrosContext db)
        {
            this.context = db;

        }
        public IActionResult ListarCarros(Carro carro)
        {
            var carros = context.Carros.ToList();
            return View(carros);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Carro carro)
        {
            if (ModelState.IsValid)
            {
                context.Add(carro);
                context.SaveChanges();
                return RedirectToAction("ListarCarros");
            }

            return View();
        }
        public IActionResult Editar(int id)
        {
            var carro = context.Carros.Find(id);

            return View(carro);
        }

        [HttpPost]
        public IActionResult Editar(Carro carro)
        {
            if (ModelState.IsValid)
            {
                context.Update(carro);
                context.SaveChanges();
                return RedirectToAction("ListarCarros");
            }

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            var carro = context.Carros.Find(id);
            if (carro == null)
                return HttpNotFound();

            return View(carro);
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}