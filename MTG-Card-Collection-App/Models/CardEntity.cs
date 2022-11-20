namespace MTG_Card_Collection_App.Models
{
    public class CardEntity
    {
        public int Id { get; set; }
        public Card Card { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}
