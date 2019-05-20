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
    public class DegreeTypesController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: DegreeTypes
        public ActionResult Index()
        {
            return View(db.DegreeTypes.ToList());
        }

        // GET: DegreeTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeType degreeType = db.DegreeTypes.Find(id);
            if (degreeType == null)
            {
                return HttpNotFound();
            }
            return View(degreeType);
        }

        // GET: DegreeTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DegreeTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] DegreeType degreeType)
        {
            if (ModelState.IsValid)
            {
                db.DegreeTypes.Add(degreeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(degreeType);
        }

        // GET: DegreeTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeType degreeType = db.DegreeTypes.Find(id);
            if (degreeType == null)
            {
                return HttpNotFound();
            }
            return View(degreeType);
        }

        // POST: DegreeTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] DegreeType degreeType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(degreeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(degreeType);
        }

        // GET: DegreeTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeType degreeType = db.DegreeTypes.Find(id);
            if (degreeType == null)
            {
                return HttpNotFound();
            }
            return View(degreeType);
        }

        // POST: DegreeTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DegreeType degreeType = db.DegreeTypes.Find(id);
            db.DegreeTypes.Remove(degreeType);
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
