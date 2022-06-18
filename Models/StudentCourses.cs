using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class StudentCourses
    {
        [Key]
        public int Id { get; set; }
        public string StudentCourseName { get; set; }
        public  string StudentCourseDesc { get; set; }
        public string  LecturerName { get; set; }
        public double Duration { get; set; }
    }
}
