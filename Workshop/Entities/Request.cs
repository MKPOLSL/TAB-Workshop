using System;
using System.Collections.Generic;
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
        public Status Status { get; set; }
        public DateTime Reqistered { get; set; }
        public DateTime FinishedOrCancelled { get; set; }

        public virtual Car Car { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual IEnumerable<Activity> Activities { get; set; }
    }
}
