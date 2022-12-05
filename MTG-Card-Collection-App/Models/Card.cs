namespace MTG_Card_Collection_App.Models
{
    public class Card
    {
        public string Id { get; set; } //Mulitverse ID
        public string Name { get; set; }
        public string? ManaCost { get; set; }
        public double CMC { get; set; }
        public List<string>? Colors { get; set; }
        public List<string>? ColorIdentity { get; set; }
        public string Type { get; set; }
        public List<string>? Supertypes { get; set; }
        public List<string> Types { get; set; }
        public List<string>? Subtypes { get; set; }
        public string Rarity { get; set; }
        public string Set { get; set; }
        public string SetName { get; set; }
        public string? Text { get; set; }
        public string Artist { get; set; }
        public string Number { get; set; }
        public string? Power { get; set; }
        public string? Toughness { get; set; }
        public string Layout { get; set; }
        public string ImageUrl { get; set; }
        public List<string>? Printings { get; set; }
    }
}
