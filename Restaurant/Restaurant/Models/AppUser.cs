using Microsoft.AspNetCore.Identity;

namespace Restaurant.Models
{
    public class AppUser : IdentityUser
    { 
        public string FullName { get; set; }
        public string Image { get; set; }
        public bool IsDeactive { get; set; }
    }
}
