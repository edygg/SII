using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaIntegralIngresos.Models;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;

namespace SistemaIntegralIngresos.Controllers
{
    public class CampusController : Controller
    {
        private SIIDbContext db = new SIIDbContext();
        private Repository repository;

        public CampusController(Repository repository) 
        {
            this.repository = repository;
        }

        public CampusController()
        {
            this.repository = new WorkingCampusRepository();
        }

        //
        // GET: /Campus/

        public ActionResult Index()
        {
            //test CampusController
            //var Campus = repository.GetAllCampus();
           // return View(Campus);
            return View(db.Campus.ToList());
        }

        //this method is just for test index
        public ActionResult IndexForTest()
        {
            //test CampusController
            var Campus = repository.GetAllCampus();
            return View(Campus);
        }

        //
        // GET: /Campus/Details/5

        public ActionResult Details(int id = 0)
        {
            Campus campus = db.Campus.Find(id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            return View(campus);
        }

        //
        // GET: /Campus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Campus/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Campus campus)
        {
            if (ModelState.IsValid)
            {
                db.Campus.Add(campus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(campus);
        }

        //
        // GET: /Campus/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Campus campus = db.Campus.Find(id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            return View(campus);
        }

        //
        // POST: /Campus/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Campus campus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campus);
        }

        //
        // GET: /Campus/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Campus campus = db.Campus.Find(id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            return View(campus);
        }

        //
        // POST: /Campus/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Campus campus = db.Campus.Find(id);
            db.Campus.Remove(campus);
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