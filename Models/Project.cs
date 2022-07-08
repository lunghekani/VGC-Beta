using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateCreated { get; set; }
        public int likes { get; set; }
        public string comments { get; set; }
        public int views { get; set; }
        public char Html { get; set; }
        public char CSS { get; set; }
        public char JS { get; set; }

    }
}
