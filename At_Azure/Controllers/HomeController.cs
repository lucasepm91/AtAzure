using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using At_Azure.Models;
using At_Azure.Repository;

namespace At_Azure.Controllers
{
    public class HomeController : Controller
    {
        AtRepository repository = new AtRepository();

        public IActionResult Index()
        {
            int numAmigos, numPaises, numEstados;

            repository.QtdEntidades(out numAmigos, out numPaises, out numEstados);

            ViewBag.Amigos = numAmigos;
            ViewBag.Paises = numPaises;
            ViewBag.Estados = numEstados;

            return View();
        }
               

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
