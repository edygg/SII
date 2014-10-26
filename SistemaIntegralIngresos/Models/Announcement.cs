using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaIntegralIngresos.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Display(Name = "Observaciones")]
        public String Observations { get; set; }
        [Required]
        [Display(Name = "Fecha Inicio")]
        public DateTime InitialDate { get; set; }
        [Display(Name = "Fecha Final")]
        public DateTime FinalDate { get; set; }
        [Display(Name = "Dias Específicos")]
        public String SpecificDays { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}