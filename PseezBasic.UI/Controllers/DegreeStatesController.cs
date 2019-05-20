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
    public class DegreeStatesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: DegreeStates
        public ActionResult Index()
        {
            return View(db.DegreeStates.ToList());
        }

        // GET: DegreeStates/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeState degreeState = db.DegreeStates.Find(id);
            if (degreeState == null)
            {
                return HttpNotFound();
            }
            return View(degreeState);
        }

        // GET: DegreeStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DegreeStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Describer")] DegreeState degreeState)
        {
            if (ModelState.IsValid)
            {
                db.DegreeStates.Add(degreeState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(degreeState);
        }

        // GET: DegreeStates/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeState degreeState = db.DegreeStates.Find(id);
            if (degreeState == null)
            {
                return HttpNotFound();
            }
            return View(degreeState);
        }

        // POST: DegreeStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Describer")] DegreeState degreeState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(degreeState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(degreeState);
        }

        // GET: DegreeStates/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeState degreeState = db.DegreeStates.Find(id);
            if (degreeState == null)
            {
                return HttpNotFound();
            }
            return View(degreeState);
        }

        // POST: DegreeStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DegreeState degreeState = db.DegreeStates.Find(id);
            db.DegreeStates.Remove(degreeState);
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
