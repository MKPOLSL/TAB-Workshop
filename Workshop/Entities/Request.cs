using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Request : HideableEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        [Required]
        public Status Status { get; set; }
        public DateTime Reqistered { get; set; }
        public DateTime FinishedOrCancelled { get; set; }

        [Required]
        public virtual Car Car { get; set; }
        [Required]
        public virtual Employee Manager { get; set; }
        public virtual IEnumerable<Activity> Activities { get; set; }
    }
}
