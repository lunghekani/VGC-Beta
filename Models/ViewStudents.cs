using System;
using System.ComponentModel.DataAnnotations;
namespace VGC.Models
{
	public class ViewStudents
	{
		[Key]

		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public string StudentSurname { get; set; }
		public string StudentMarks { get; set; }



	}
}

