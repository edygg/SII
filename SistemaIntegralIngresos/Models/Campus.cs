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
        public String Code { get; set; }
        [Required]
        public String Name { get; set; }
        public String Details { get; set; }
    }
}