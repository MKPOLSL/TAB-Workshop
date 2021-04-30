using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Car : HideableEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        [Required]
        public CarType CarType { get; set; }

        public virtual Client Client { get; set; }
        public virtual IEnumerable<Request> Requests { get; set; }
    }
}