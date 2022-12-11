using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using MTG_Card_Collection_App.Data;
using MTG_Card_Collection_App.Models;
using MtgApiManager.Lib.Service;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Drawing;

namespace MTG_Card_Collection_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<User> userManager;
        private CardContext context;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, CardContext context)
        {
            _logger = logger;
            this.userManager = userManager;
            this.context = context;
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
        public async Task<IActionResult> Collection()
        {
            var model = new CollectionViewModel();
            var user = await userManager.GetUserAsync(HttpContext.User);
            user = context.Users.Find(user.Id);
            if (user.Cards != null)
            {
                model.Cards = context.CardCollections.Where(c => c.UserId.Equals(user.Id)).Select(c => c.Card).ToList();
            }
            return View(model);
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
        public async Task<IActionResult> Search(string nameFilter, string selectedCardId)
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();
            var model = new SearchViewModel();
            if (!string.IsNullOrEmpty(nameFilter)){
                var result = await service
                .Where(c => c.Name, nameFilter)
                .AllAsync();
                model.Cards = result.Value.OrderBy(c => c.Name).Where(c => c.MultiverseId != null).DistinctBy(c => c.Name).ToList();
            } else
            {
                model.Cards = new List<MtgApiManager.Lib.Model.ICard>();
                nameFilter = "";
            }
            
            model.Message = "";

            if (!string.IsNullOrEmpty(selectedCardId))
            {
                var selectedCard = await service.FindAsync(selectedCardId);

                var card = new Card
                {
                    Id = selectedCard.Value.MultiverseId,
                    Name = selectedCard.Value.Name,
                    ManaCost = selectedCard.Value.ManaCost,
                    CMC = selectedCard.Value.Cmc,
                    Type = selectedCard.Value.Type,
                    Types = selectedCard.Value.Types.ToList(),
                    Rarity = selectedCard.Value.Rarity,
                    Set = selectedCard.Value.Set,
                    SetName = selectedCard.Value.SetName,
                    Text = selectedCard.Value.Text,
                    Artist = selectedCard.Value.Artist,
                    Number = selectedCard.Value.Number,
                    Power = selectedCard.Value.Power,
                    Toughness = selectedCard.Value.Toughness,
                    Layout = selectedCard.Value.Layout,
                    ImageUrl = selectedCard.Value.ImageUrl.ToString()
                };

                if (selectedCard.Value.Colors != null)
                {
                    card.Colors = selectedCard.Value.Colors.ToList();
                }
                if (selectedCard.Value.ColorIdentity != null)
                {
                    card.ColorIdentity = selectedCard.Value.ColorIdentity.ToList();
                }
                if (selectedCard.Value.SuperTypes != null)
                {
                    card.Supertypes = selectedCard.Value.SuperTypes.ToList();
                }
                if (selectedCard.Value.SubTypes != null)
                {
                    card.Subtypes = selectedCard.Value.SubTypes.ToList();
                }
                if (selectedCard.Value.Printings != null)
                {
                    card.Printings = selectedCard.Value.Printings.ToList();
                }

                if (context.Cards.Contains(card))
                {
                    card = context.Cards.Find(card);
                }

                var user = await userManager.GetUserAsync(HttpContext.User);
                CardCollection entity = new CardCollection
                {
                    UserId = user.Id,
                    User = user,
                    CardId = card.Id,
                    Card = card
                };
                user.Cards ??= new List<CardCollection>();

                user.Cards.Add(entity);
                context.Users.Update(user);
                context.SaveChanges();

                model.Message = card.Name + " was added.";
            }

            model.NameFilter = nameFilter;
            model.SelectedCardId = "";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}