using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Dtos
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Proszę wpisać nazwę użytkownika")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Proszę wpisać hasło")]
        public string Password { get; set; }
    }
}
