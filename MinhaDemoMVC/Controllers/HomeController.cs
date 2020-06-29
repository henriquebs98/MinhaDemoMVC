using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMVC.Models;

namespace MinhaDemoMVC.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(string id, string categoria)
        {
            //var filme = new Filme
            //{
            //    Titulo = "Oi",
            //    DataLancamento = DateTime.Now,
            //    Genero = null,
            //    Avaliacao = 10,
            //    Valor = 2000
            //};
            //return RedirectToAction("Privacy", filme);
            return View();
        }

        [Route("politica-de-privacidade")]
        [Route("privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View();
            //return Json("{'nome':'Henrique'}");
            //var fileBytes = System.IO.File.ReadAllBytes(@"c:\users\henri\onedrive\documentos\7 - Currículo\CV - Henrique Bittencourt Severo.pdf");
            //var fileName = "CV - Henrique Bittencourt Severo.pdf";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
