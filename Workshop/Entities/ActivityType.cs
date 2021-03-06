using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Entities
{
    [Table("ActivityTypes")]
    public class ActivityType : HideableEntity
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string ActivityName { get; set; }
    }
}
