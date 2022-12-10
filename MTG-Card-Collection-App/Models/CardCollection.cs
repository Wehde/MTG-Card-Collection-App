using Microsoft.EntityFrameworkCore;

namespace MTG_Card_Collection_App.Models
{
    public class CardCollection
    {
        public string CardId { get; set; }
        public string UserId { get; set; }
        public Card Card { get; set; }
        public User User { get; set; }
    }
}
