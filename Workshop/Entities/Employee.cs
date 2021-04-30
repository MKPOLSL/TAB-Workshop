using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Employee : HideableEntity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Rola jest wymagana")]
        public Role Role { get; set; }

        public virtual IEnumerable<Request> Requests { get; set; }
        public virtual IEnumerable<Activity> Activities { get; set; }
    }
}
