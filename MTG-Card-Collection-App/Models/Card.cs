using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MTG_Card_Collection_App.Models
{
    public class Card
    {
        public Card()
        {
            Users = new List<CardCollection>();
        }
        public string Id { get; set; } //Mulitverse ID
        public string Name { get; set; }
        public string? ManaCost { get; set; }
        public float? CMC { get; set; }
        public List<string>? Colors { get; set; }
        public List<string>? ColorIdentity { get; set; }
        public string Type { get; set; }
        public List<string>? Supertypes { get; set; }
        public List<string> Types { get; set; }
        public List<string>? Subtypes { get; set; }
        [MaxLength(14)]
        public string Rarity { get; set; }
        [MaxLength(8)]
        public string Set { get; set; }
        public string SetName { get; set; }
        public string? Text { get; set; }
        public string Artist { get; set; }
        [MaxLength(5)]
        public string Number { get; set; }
        [MaxLength(3)]
        public string? Power { get; set; }
        [MaxLength(3)]
        public string? Toughness { get; set; }
        public string Layout { get; set; }
        public string ImageUrl { get; set; }
        public List<string>? Printings { get; set; }
        public ICollection<CardCollection>? Users { get; set; }

        public string GetManaCostIcons()
        {
            string icons = ManaCost.ToLower();
            icons = icons.Replace("/", "")
                .Replace("{", "<i class=\"ms ms-")
                .Replace("}", " ms-cost\"></i>");
            
            return icons;
        }

        public string GetSetIcon()
        {
            return "<i class=\"ss ss-" + Set.ToLower() + " ss-" + Rarity.ToLower() + "\"></i>";
        }

        public string GetSetIcon(string set, string rarity)
        {
            return "<i class=\"ss ss-" + set.ToLower() + " ss-" + rarity.ToLower() + "\"></i>";
        }

        public string GetTextIcons()
        {
            string icons = Text.Replace("\n", "<br />");
            icons = Regex.Replace(icons, @"{(.*?)}", m => m.ToString().ToLower()
                .Replace("/", "")
                .Replace("t", "tap")
                .Replace("q", "untap"))
                .Replace("{", "<i class=\"ms ms-")
                .Replace("}", " ms-cost\"></i>");

            return icons;
        }
    }
}
