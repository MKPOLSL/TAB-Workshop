using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Activity : HideableEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public Status Status { get; set; }
        public DateTime Reqistered { get; set; }
        public DateTime FinishedOrCancelled { get; set; }
        public ActivityType ActivityType { get; set; }

        public virtual Request Request { get; set; }
        public virtual Employee Worker { get; set; }
    }
}
