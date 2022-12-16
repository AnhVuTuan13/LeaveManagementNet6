﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name ="Default number of Days")]
        public int DefaultDays { get; set; }
    }
}
