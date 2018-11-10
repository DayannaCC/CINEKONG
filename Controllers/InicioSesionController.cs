
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
            try{
                 var usuario = (from m in _context.Usuario where (m.Correo == iniciar.Email && m.Contraseña ==iniciar.Contra)  select m.Nombres).Single();
                 
                 HttpContext.Session.SetString("User", usuario);
               
               
            }catch(Exception e){
                Console.WriteLine(e);
                return View("IniciarSesion");
            }
           
            
            
            
            
            
            
            
             return RedirectToAction("IndexIS");
		}


        public IActionResult PeliculasIS(){
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }

        public IActionResult TrailersIS(){
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }

         public IActionResult PruebaIS(){
              var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }

        public IActionResult NoticiasIS(){
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }
        
        public IActionResult IndexIS(){

              var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }
        
        public IActionResult ReservarEntradasIS(){
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }
        
        public IActionResult CantidadEntradasIS(){
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }

        public IActionResult ElegirButacaIS(){
             var repositorio=new RepositorioButacas();
            var butacas=repositorio.obtenerButacas();
            ViewBag.butacas=butacas;
             var objUser = HttpContext.Session.GetString("User");
                 ViewBag.Nombre = objUser;
                 Console.WriteLine(objUser);
            return View();
        }
    }
}