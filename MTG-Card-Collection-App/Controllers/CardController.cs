using Microsoft.AspNetCore.Mvc;

namespace MTG_Card_Collection_App.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
