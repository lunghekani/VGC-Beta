using System;
using System.ComponentModel.DataAnnotations;
namespace VGC.Models
{
	public class CreateAssessment
	{
		[Key]
		
		public string AssessmentName { get; set; }
		public string AssessmentDesc { get; set; }
		public string AssessmentCode { get; set; }
	}
}

