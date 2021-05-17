using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Entities
{
    [Table("Clients")]
    public class Client : HideableEntity
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [RegularExpression(@"[a-zA-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]{3,20}", ErrorMessage = "Dozwolone tylko litery")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [RegularExpression(@"[a-zA-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]{3,20}", ErrorMessage = "Dozwolone tylko litery")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [RegularExpression(@"^\+?[0-9]{2}-?[0-9]{7}$", ErrorMessage = "Numer jest niepoprawny")]
        public string PhoneNumber { get; set; }

        public virtual IEnumerable<Car> Cars { get; set; }
    }
}
