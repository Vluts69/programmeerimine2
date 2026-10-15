using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Data
  {   
 
    public class Autopark
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Staatus { get; set; }
        [Required]
        [StringLength(255)]
        public string Kirjeldus { get; set; } 
        

         [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Toohind { get; set; }
        [Required]
        [StringLength(255)]
        public string Broneering { get; set; }
    }
}