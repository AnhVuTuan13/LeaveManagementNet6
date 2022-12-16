using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name="Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Default number of Days")]
        [Required]
        [Range(1,25,ErrorMessage ="Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}

