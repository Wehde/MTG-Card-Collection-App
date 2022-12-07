using Microsoft.AspNetCore.Identity;
using System.ComponenetModel.DataAnnotations.Schema;

namespace MTG_Card_Collection_App.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
