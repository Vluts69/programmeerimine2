using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Data
{

    public class Auto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
                public string Mark { get; set; }

                [Required]
        [StringLength(255)]
        public string Mudel { get; set; }

        [Required]
        [StringLength(255)]
        public string Registreerimisnumber { get; set; } 

        [Required]
        [StringLength(255)]
        public string VIN { get; set; }
    }
}