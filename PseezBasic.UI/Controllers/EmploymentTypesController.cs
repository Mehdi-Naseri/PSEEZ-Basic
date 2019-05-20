using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PseezBasic.UI.Models;

namespace PseezBasic.UI.Controllers
{
    public class EmploymentTypesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: EmploymentTypes
        public ActionResult Index()
        {
            return View(db.EmploymentTypes.ToList());
        }

        // GET: EmploymentTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentType employmentType = db.EmploymentTypes.Find(id);
            if (employmentType == null)
            {
                return HttpNotFound();
            }
            return View(employmentType);
        }

        // GET: EmploymentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmploymentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,EmploymentState_Id,IsActive")] EmploymentType employmentType)
        {
            if (ModelState.IsValid)
            {
                db.EmploymentTypes.Add(employmentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employmentType);
        }

        // GET: EmploymentTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentType employmentType = db.EmploymentTypes.Find(id);
            if (employmentType == null)
            {
                return HttpNotFound();
            }
            return View(employmentType);
        }

        // POST: EmploymentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,EmploymentState_Id,IsActive")] EmploymentType employmentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employmentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employmentType);
        }

        // GET: EmploymentTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentType employmentType = db.EmploymentTypes.Find(id);
            if (employmentType == null)
            {
                return HttpNotFound();
            }
            return View(employmentType);
        }

        // POST: EmploymentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EmploymentType employmentType = db.EmploymentTypes.Find(id);
            db.EmploymentTypes.Remove(employmentType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
