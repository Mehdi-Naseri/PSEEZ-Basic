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
    public class EmploymentStatesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: EmploymentStates
        public ActionResult Index()
        {
            return View(db.EmploymentStates.ToList());
        }

        // GET: EmploymentStates/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentState employmentState = db.EmploymentStates.Find(id);
            if (employmentState == null)
            {
                return HttpNotFound();
            }
            return View(employmentState);
        }

        // GET: EmploymentStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmploymentStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Describer")] EmploymentState employmentState)
        {
            if (ModelState.IsValid)
            {
                db.EmploymentStates.Add(employmentState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employmentState);
        }

        // GET: EmploymentStates/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentState employmentState = db.EmploymentStates.Find(id);
            if (employmentState == null)
            {
                return HttpNotFound();
            }
            return View(employmentState);
        }

        // POST: EmploymentStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Describer")] EmploymentState employmentState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employmentState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employmentState);
        }

        // GET: EmploymentStates/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploymentState employmentState = db.EmploymentStates.Find(id);
            if (employmentState == null)
            {
                return HttpNotFound();
            }
            return View(employmentState);
        }

        // POST: EmploymentStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EmploymentState employmentState = db.EmploymentStates.Find(id);
            db.EmploymentStates.Remove(employmentState);
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
