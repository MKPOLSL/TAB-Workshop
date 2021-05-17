using System.ComponentModel.DataAnnotations;

namespace Workshop.Enums
{
    public enum Status
    {
        [Display(Name = "Oczekujące")]
        Pending = 0,
        [Display(Name = "W trakcie")]
        InProgress = 1,
        [Display(Name = "Zakończone")]
        Finished = 2,
        [Display(Name = "Anulowane")]
        Canceled = 3
    }
}
