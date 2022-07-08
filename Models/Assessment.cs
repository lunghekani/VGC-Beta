using System;
using System.ComponentModel.DataAnnotations;
namespace VGC.Models
{
	public class Assessment
	{
		[Key]
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
		public string AssessmentDesc { get; set; }
		public string AssessmentCode { get; set; }
		public int AssessmentWeight { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DueDate { get; set; }
       

    }
}

