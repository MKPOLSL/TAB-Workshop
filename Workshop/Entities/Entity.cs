using System;
using System.ComponentModel.DataAnnotations;

namespace Workshop.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsHidden { get; set; }
    }
}
