using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaIntegralIngresos.Models
{
    public class Campus
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Código")]
        public String Code { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }
        [Display(Name = "Detalles")]
        public String Details { get; set; }

  
    }
}