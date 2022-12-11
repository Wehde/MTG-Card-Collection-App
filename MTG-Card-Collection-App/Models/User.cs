using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTG_Card_Collection_App.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Cards = new List<CardCollection>();
        }

        public ICollection<CardCollection> Cards { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }

        
    }
}
