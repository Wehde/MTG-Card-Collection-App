using Microsoft.AspNetCore.Mvc;
using MTG_Card_Collection_App.Models;
using MtgApiManager.Lib.Service;
using System.Collections.Immutable;
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

        [Route("Search")]
        public async Task<IActionResult> Search(string nameFilter)
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();
            var model = new SearchViewModel();
            if (!string.IsNullOrEmpty(nameFilter)){
                var result = await service
                .Where(c => c.Name, nameFilter)
                .AllAsync();
                model.Cards = result.Value.OrderBy(c => c.Name).DistinctBy(c => c.Name).ToList();
            } else
            {
                model.Cards = new List<MtgApiManager.Lib.Model.ICard>();
                nameFilter = "";
            }
            model.NameFilter = nameFilter;

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}