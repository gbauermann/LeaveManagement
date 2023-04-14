using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "From")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "To")]
        public DateTime? EndDate { get; set; }
        
        [Display(Name = "Leave Type")]
        public SelectList? LeaveTypes { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }

        [Display(Name = "Comments")]
        public string RequestComent { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("Start Date Cannot be after End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
