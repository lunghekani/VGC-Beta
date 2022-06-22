using Microsoft.AspNetCore.Identity;

namespace VGC.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string  Address { get; set; }
    }
}
