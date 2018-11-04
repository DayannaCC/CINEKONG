
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
    public class InicioSesionController : Controller
    {

        
        private readonly CinekongContext _context;
        public InicioSesionController(CinekongContext _context) => this._context = _context;

        public IActionResult IniciarSesion()
        {
            //HttpContext.Session.SetString("User", "test@gmail.com");
            Console.WriteLine("Entro1");
            return View();
        }

        
        //public async Task<IActionResult> IniciarSesion(string correo)
        //{
          //   var usuario = from m in _context.Usuario select m;

         //   if (!String.IsNullOrEmpty(correo))
          //  {
             //   var usuario = usuario.Where(s => s.Email.Contains(correo));
           // }
            
           // return View(await usuario.ToListAsync());
        //}

        [HttpPost]
		public IActionResult Iniciar(IniciarSesion iniciar)
		{
            ViewData["Message"] = "";
            HttpContext.Session.SetString("User", iniciar.Email);
            var objUser = HttpContext.Session.GetString("User");
            Console.WriteLine("Entro2"+ objUser);
            
            return View("IniciarSesion",iniciar);
		}
    }
}