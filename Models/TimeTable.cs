﻿using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class TimeTable
    {
        [Key]

        public int TimeTableId { get; set; }
        public string CourseName  { get; set; }
        public string LecturerName { get; set; }
        public double Classtime { get; set; }
    }
}
