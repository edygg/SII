using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaIntegralIngresos.Models
{
    public class Visit
    {
        public int Id { get; set; }
        [Required]
        public int AnnouncementId { get; set; }
        [Required]
        public String FullName { get; set; }
        [Required]
        public String TypeEntrance { get; set; }
    }
}