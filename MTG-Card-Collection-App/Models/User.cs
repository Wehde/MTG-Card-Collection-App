using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTG_Card_Collection_App.Models
{
    public class User : IdentityUser
    {   
        [NotMapped]
        public IList<string> RoleNames { get; set; }

        public List<CardCollection> Cards { get; set; }
    }
}
