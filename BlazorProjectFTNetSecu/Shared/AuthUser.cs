using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectFTNetSecu.Shared
{
    public class AuthUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        [MinLength(10)]
        public string SecretMessage { get; set; }

    }
}
