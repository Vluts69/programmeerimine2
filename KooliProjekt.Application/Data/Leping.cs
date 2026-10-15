using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Leping
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Too { get; set; }

         [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Makse { get; set; }
        [Required]
        [StringLength(255)]
        public string Kirjeldus { get; set; }

         [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Grandtotal { get; set; }
    }