using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Enums
{
    public enum Role
    {
        [Display(Name = "Manager")]
        Manager = 0,
        [Display(Name = "Worker")]
        Worker = 1,
        [Display(Name = "Administrator")]
        Administrator = 2
    }
}
