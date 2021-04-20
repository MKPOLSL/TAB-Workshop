using System.ComponentModel.DataAnnotations;

namespace Workshop.Enums
{
    public enum Result
    {
        [Display(Name = "Cancelled")]
        Cancelled = 0,
        [Display(Name = "Completed")]
        Completed = 1,
    }
} 