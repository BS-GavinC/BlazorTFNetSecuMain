using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectFTNetSecu.Shared
{
    public class RegisterForm
    {
        [DisplayName("Prenom")]
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Attention, l'email est obligatoire !")]
        [EmailAddress]
        public string Email { get; set; }


        [Required] 
        public string Password { get; set; }


        [Required]
        [Compare("Password")]
        public string ConfirmationPassword { get; set; }
    }
}
