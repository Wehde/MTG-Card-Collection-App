namespace MTG_Card_Collection_App.Models
{
    public class CardViewModel
    {
        public Card Card { get; set; }

        public List<MtgApiManager.Lib.Model.ICard> Printings { get; set; }
    }
}
