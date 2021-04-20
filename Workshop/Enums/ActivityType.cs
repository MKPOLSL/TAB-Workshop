using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Enums
{
    public enum ActivityType
    {
        [Display(Name = "Repair")]
        Repair = 0,
        [Display(Name = "Correction")]
        Correction = 1,
        [Display(Name = "Warranty")]
        Warranty = 1
    }
}
