using Microsoft.AspNetCore.Mvc;
using MTG_Card_Collection_App.Models;
using System.Diagnostics;

namespace MTG_Card_Collection_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Collection")]
        public IActionResult Collection()
        {
            return View();
        }

        [Route("Decks")]
        public IActionResult Decks()
        {
            return View();
        }

        [Route("Social")]
        public IActionResult Social()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}