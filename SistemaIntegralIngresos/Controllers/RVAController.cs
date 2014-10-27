using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaIntegralIngresos.Models;

namespace SistemaIntegralIngresos.Controllers
{
    public class RVAController : Controller
    {
        private SIIDbContext db = new SIIDbContext();
        //
        // GET: /RVA/

        public ActionResult Index()
        {
            ViewBag.Campus = new SelectList(db.Campus, "Id", "Name");

            return View();
        }

    }
}
