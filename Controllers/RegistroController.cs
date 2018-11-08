using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CINEKONG.Models;
using CINEKONG.Context;
using Microsoft.AspNetCore.Http;


namespace CINEKONG.Controllers
{
    public class RegistroController : Controller
    {

        
        private readonly CinekongContext _context;
        public RegistroController(CinekongContext _context) => this._context = _context;

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


         public IActionResult Usuario() {

            return View();
        }

        

        [HttpPost]
        public IActionResult Usuario(Usuario e) 
        {

            if (ModelState.IsValid)
            {
                _context.Add(e);
                _context.SaveChanges();

                return RedirectToAction("UsuarioConfirmacion");
            }

            

            return View(e);
        }

        public IActionResult UsuarioConfirmacion() {
            return View();
        }
         public IActionResult Registrarse()
        {
            var objUser = HttpContext.Session.GetString("User");
            Console.WriteLine("Entro2"+ objUser);
            return View();
        }

        [HttpPost]
		public IActionResult Registrar(
             Registrarse registrarse)
		{
          
            ViewData["Message"] = "Registro Exitoso";
            

            return View("Registrarse",registrarse);
		}

    }
}