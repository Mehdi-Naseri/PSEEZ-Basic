﻿using System;
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
    public class ReligionsController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: Religions
        public ActionResult Index()
        {
            return View(db.Religions.ToList());
        }

        // GET: Religions/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion religion = db.Religions.Find(id);
            if (religion == null)
            {
                return HttpNotFound();
            }
            return View(religion);
        }

        // GET: Religions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Religions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,TimeStamp")] Religion religion)
        {
            if (ModelState.IsValid)
            {
                db.Religions.Add(religion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(religion);
        }

        // GET: Religions/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion religion = db.Religions.Find(id);
            if (religion == null)
            {
                return HttpNotFound();
            }
            return View(religion);
        }

        // POST: Religions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,TimeStamp")] Religion religion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(religion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(religion);
        }

        // GET: Religions/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Religion religion = db.Religions.Find(id);
            if (religion == null)
            {
                return HttpNotFound();
            }
            return View(religion);
        }

        // POST: Religions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Religion religion = db.Religions.Find(id);
            db.Religions.Remove(religion);
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
