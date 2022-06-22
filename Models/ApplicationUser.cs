using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        public string?  Address { get; set; }
    }
}
