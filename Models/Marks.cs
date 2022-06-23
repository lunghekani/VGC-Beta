using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class Marks
    {
        [Key]
        public int MarkId { get; set; }
        public string  Activity { get; set; }
        public string Description { get; set; }
        public string Mark { get; set; }
    }
}
