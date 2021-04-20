using System.ComponentModel.DataAnnotations;

namespace Workshop.Enums
{
    public enum CarType
    {
        [Display(Name = "Private Car")]
        Private = 0,
        [Display(Name = "Company Car")]
        Company = 1
    }
}
