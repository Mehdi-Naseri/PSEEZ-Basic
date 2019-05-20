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
    public class FamilialTypesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: FamilialTypes
        public ActionResult Index()
        {
            return View(db.FamilialTypes.ToList());
        }

        // GET: FamilialTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilialType familialType = db.FamilialTypes.Find(id);
            if (familialType == null)
            {
                return HttpNotFound();
            }
            return View(familialType);
        }

        // GET: FamilialTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilialTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,TimeStamp,Describer")] FamilialType familialType)
        {
            if (ModelState.IsValid)
            {
                db.FamilialTypes.Add(familialType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familialType);
        }

        // GET: FamilialTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilialType familialType = db.FamilialTypes.Find(id);
            if (familialType == null)
            {
                return HttpNotFound();
            }
            return View(familialType);
        }

        // POST: FamilialTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,TimeStamp,Describer")] FamilialType familialType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familialType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familialType);
        }

        // GET: FamilialTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilialType familialType = db.FamilialTypes.Find(id);
            if (familialType == null)
            {
                return HttpNotFound();
            }
            return View(familialType);
        }

        // POST: FamilialTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FamilialType familialType = db.FamilialTypes.Find(id);
            db.FamilialTypes.Remove(familialType);
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
