using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "You must a first name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter a last name")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "You must enter an email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must enter a password")]
        public String Password { get; set; }
    }
}
