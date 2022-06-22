using System;
using System.ComponentModel.DataAnnotations;
namespace VGC.Models
{
	public class AddCourseContent
	{
		
            [Key]

		public int Id { get; set; }
		public string CourseName { get; set; }
		public string CourseDesc { get; set; }
		public string LecturerName { get; set; }
        public string CourseCode { get; set; }

	}
	
}

