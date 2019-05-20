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
    public class BloodTypesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: BloodTypes
        public ActionResult Index()
        {
            return View(db.BloodTypes.ToList());
        }

        // GET: BloodTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodTypes.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // GET: BloodTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,TimeStamp,Describer")] BloodType bloodType)
        {
            if (ModelState.IsValid)
            {
                db.BloodTypes.Add(bloodType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloodType);
        }

        // GET: BloodTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodTypes.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // POST: BloodTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,TimeStamp,Describer")] BloodType bloodType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodType);
        }

        // GET: BloodTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodTypes.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // POST: BloodTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            BloodType bloodType = db.BloodTypes.Find(id);
            db.BloodTypes.Remove(bloodType);
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
