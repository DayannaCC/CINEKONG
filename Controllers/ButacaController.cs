using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CINEKONG.Models;

namespace CINEKONG.Controllers
{
    public class ButacaController : Controller
    {
        public IActionResult ElegirButaca()
        {
            var repositorio=new RepositorioButacas();
            var butacas=repositorio.obtenerButacas();
            ViewBag.butacas=butacas;
            return View();
        }

    }
}
