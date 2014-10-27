using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIntegralIngresos.Models
{
    interface IVisit
    {
        List<Visit> GetAllCampus();
        Boolean InsertVisit(Visit campus);
        Boolean DeleteVisit(int id);
        Visit FindByID(int id);
        Boolean EditVisit(Visit campus);
    }
}
