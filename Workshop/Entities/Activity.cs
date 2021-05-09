using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Workshop.Enums;

namespace Workshop.Entities
{
    [Table("Activities")]
    public class Activity : HideableEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        [Required]
        public Status Status { get; set; }
        public DateTime Registered { get; set; }
        public DateTime FinishedOrCancelled { get; set; }
        [Required]
        public int SequenceNumber { get; set; }
        [Required]
        public ActivityType ActivityType { get; set; }
        [Required]
        public virtual Request Request { get; set; }
        [Required]
        public virtual Employee Worker { get; set; }

    }
}
