using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CINEKONG.Context;
using CINEKONG.Models;


namespace CINEKONG.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Noticias()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Peliculas()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Trailers()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        

        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Iniciar(
             IniciarSesion iniciar)
		{
            ViewData["Message"] = "";
            return View("IniciarSesion",iniciar);
		}


        public IActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Registrar(
             Registrarse registrarse)
		{
          
            ViewData["Message"] = "Registro Exitoso";
            

            return View("Registrarse",registrarse);
		}
        public IActionResult RecuperarContra()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Recuperar(
             RecuperarContra recuperar)
		{
            ViewData["Message"] = "Te enviamos un link a "+recuperar.Email+" para recuperar tu contraseña.";
          
            return View("RecuperarContra",recuperar);
		}
        public IActionResult CambiarContra()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Cambiar(
             CambiarContra cambiar)
		{
            ViewData["Message"] = "Tu contraseña ha sido cambiada.";
          
            return View("CambiarContra",cambiar);
		}
        public IActionResult CantidadEntradas()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult ReservarEntradas()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }




      //USUARIO

        private readonly CinekongContext _context;
        public HomeController(CinekongContext _context)
        {
            this._context = _context;
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


         public IActionResult Usuario() {


            return View();
        }

        

        [HttpPost]
        public IActionResult Usuario(Usuario e) {

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

      
            

        }
}
