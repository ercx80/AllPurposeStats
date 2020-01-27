using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "You must enter an email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must enter a password")]
        public String Password { get; set; }
    }
}
