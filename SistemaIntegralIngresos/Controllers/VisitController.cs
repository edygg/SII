using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaIntegralIngresos.Models;

namespace SistemaIntegralIngresos.Controllers
{
    public class VisitController : Controller
    {
        private SIIDbContext db = new SIIDbContext();
          private IVisit repository;

          public VisitController(IVisit repository) 
        {
            this.repository = repository;
        }

        public VisitController()
        {
            this.repository = new VisitOperationRepo();
        }
      
        //
        // GET: /Visit/

        public ActionResult Index()
        {
            return View(db.Visits.ToList());
        }

        //
        // GET: /Visit/Details/5

        public ActionResult Details(int id = 0)
        {
            Visit visit = db.Visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        //
        // GET: /Visit/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Visit/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Visits.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visit);
        }

        //
        // GET: /Visit/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Visit visit = db.Visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        //
        // POST: /Visit/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visit);
        }

        //
        // GET: /Visit/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Visit visit = db.Visits.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        //
        // POST: /Visit/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visit visit = db.Visits.Find(id);
            db.Visits.Remove(visit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}