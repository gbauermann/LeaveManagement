﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name= "Default Number of Days")]
        [Range(1, 25, ErrorMessage = "Please enter a value between 1 and 25")]
        public int DefaultDays { get; set; }
    }
}
