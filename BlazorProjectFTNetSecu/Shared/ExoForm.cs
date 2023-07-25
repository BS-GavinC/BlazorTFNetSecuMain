using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectFTNetSecu.Shared
{
    public class ExoForm
    {
        /*
         * 
         * Nom EMail Tel Message Color
         * 
         */

        [Required]
        public string Name { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [MinLength(10)]
        public string Tel { get; set; }


        [Required]
        public string Message { get; set; }


        [Required]
        [StringLength(7)]
        public string Color { get; set; }

        


    }
}
