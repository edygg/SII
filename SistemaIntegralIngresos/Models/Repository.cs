using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIntegralIngresos.Models
{
    public interface Repository
    {
        List<Campus> GetAllCampus();
    }
}
