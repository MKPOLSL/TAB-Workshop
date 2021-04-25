using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Entities
{
    public class CarType : HideableEntity
    {
        [Key]
        public string Code { get; set; }
        public string TypeName { get; set; }
    }
}
