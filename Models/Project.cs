﻿using System.ComponentModel.DataAnnotations;

namespace VGC.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
