using System;
using System.ComponentModel.DataAnnotations;
namespace VGC.Models
{
	public class ViewAssessment
    {
		[Key]

		public string AssessmentName { get; set; }
		public string AssessmentMark { get; set; }
		public string AssessmentCode { get; set; }
	}
}

