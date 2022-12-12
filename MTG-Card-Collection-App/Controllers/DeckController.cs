using Microsoft.AspNetCore.Mvc;
using MTG_Card_Collection_App.Models;

namespace MTG_Card_Collection_App.Controllers
{
    public class DeckController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var session = new CardSession(HttpContext.Session);
            var model = new CollectionViewModel
            {
                Cards = session.GetMyCards()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new CardSession(HttpContext.Session);
            var cookies = new CardCookies(Response.Cookies);

            session.RemoveMyCards();
            cookies.RemoveMyCardIds();

            TempData["message"] = "Deck Cleared";

            return RedirectToAction("Collection", "Home");
        }
    }
}
