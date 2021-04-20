using System.ComponentModel.DataAnnotations;

namespace Workshop.Enums
{
    public enum Status
    {
        [Display(Name = "Pending")]
        Pending = 0,
        [Display(Name = "In Progress")]
        InProgress = 1,
        [Display(Name = "Finished")]
        Finished = 2,
        [Display(Name = "Canceled")]
        Canceled = 3
    }
}
