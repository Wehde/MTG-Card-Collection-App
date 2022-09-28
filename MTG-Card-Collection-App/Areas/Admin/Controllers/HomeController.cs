using Microsoft.AspNetCore.Mvc;
using MTG_Card_Collection_App.Models;
using System.Diagnostics;

namespace MTG_Card_Collection_App.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("[area]/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[area]/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("[area]/Collection")]
        public IActionResult Collection()
        {
            return View();
        }

        [Route("[area]/Decks")]
        public IActionResult Decks()
        {
            return View();
        }

        [Route("[area]/Social")]
        public IActionResult Social()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StaticContent(string num)
        {
            return Content($"Static Content: {num}");
        }
    }
}