using System.ComponentModel.DataAnnotations;

namespace VGC.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
