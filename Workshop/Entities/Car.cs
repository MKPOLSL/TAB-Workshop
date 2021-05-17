using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Workshop.Enums;

namespace Workshop.Entities
{
    [Table("Cars")]
    public class Car : HideableEntity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Numer rejestracyjny jest wymagany")]
        [RegularExpression(@"[A-Za-z0-9]{4,7}", ErrorMessage = "Numer jest niepoprawny")]
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Rok produkcji jest niepoprawny")]
        public int ProductionYear { get; set; }
        [Required]
        public CarType CarType { get; set; }

        [Required]
        public virtual Client Client { get; set; }
        public virtual IEnumerable<Request> Requests { get; set; }
    }
}