using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace KooliProjekt.Application.Data
{   


    public class Leping
    {
        public int Id { get; set; }

        [Required]

      
        [StringLength(255)]


        public string Too { get; set; }




        public decimal Makse { get; set; }

        [Required]


        [StringLength(255)]
        public string Kirjeldus { get; set; }

   
        public decimal Grandtotal { get; set; }
    }
}
