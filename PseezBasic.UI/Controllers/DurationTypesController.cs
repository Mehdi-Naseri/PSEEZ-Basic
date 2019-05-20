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
    public class DurationTypesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: DurationTypes
        public ActionResult Index()
        {
            return View(db.DurationTypes.ToList());
        }

        // GET: DurationTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DurationType durationType = db.DurationTypes.Find(id);
            if (durationType == null)
            {
                return HttpNotFound();
            }
            return View(durationType);
        }

        // GET: DurationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DurationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] DurationType durationType)
        {
            if (ModelState.IsValid)
            {
                db.DurationTypes.Add(durationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(durationType);
        }

        // GET: DurationTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DurationType durationType = db.DurationTypes.Find(id);
            if (durationType == null)
            {
                return HttpNotFound();
            }
            return View(durationType);
        }

        // POST: DurationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] DurationType durationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(durationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(durationType);
        }

        // GET: DurationTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DurationType durationType = db.DurationTypes.Find(id);
            if (durationType == null)
            {
                return HttpNotFound();
            }
            return View(durationType);
        }

        // POST: DurationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DurationType durationType = db.DurationTypes.Find(id);
            db.DurationTypes.Remove(durationType);
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
