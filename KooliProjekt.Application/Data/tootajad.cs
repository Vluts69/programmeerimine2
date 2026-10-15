using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Data
  {   
 
    public class Tootaja
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nimi { get; set; } 
        [Required]
        [StringLength(255)]
        public string Kasutaja { get; set; }
        [Required]
        [StringLength(255)]
        public string Roll { get; set; } 
    }
 }