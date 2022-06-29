using System.ComponentModel.DataAnnotations;

namespace VGC.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Role name is required")]
        public string Name { get; set; }
        public List<string> Users { get; set; }
    }
}
