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
    public class PeopleController : Controller
    {
        private PseezBasicDbContext db = new PseezBasicDbContext();

        // GET: People
        public ActionResult Index()
        {
            //var people = db.People.Include(p => p.City).Include(p => p.Employee).Include(p => p.Gender);
            var people = db.People.Include(p => p.City).Include(p => p.Gender);
            return View(people.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            ViewBag.City_Id = new SelectList(db.Cities, "Id", "Code");
            ViewBag.Id = new SelectList(db.Employees, "Id", "Code");
            ViewBag.Gender_Id = new SelectList(db.Genders, "Id", "Title");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Family,FatherName,BirthDate,City_Id,IdNumber,NationalCode,Gender_Id,Mobile")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.City_Id = new SelectList(db.Cities, "Id", "Code", person.City_Id);
            ViewBag.Id = new SelectList(db.Employees, "Id", "Code", person.Id);
            ViewBag.Gender_Id = new SelectList(db.Genders, "Id", "Title", person.Gender_Id);
            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            ViewBag.City_Id = new SelectList(db.Cities, "Id", "Code", person.City_Id);
            ViewBag.Id = new SelectList(db.Employees, "Id", "Code", person.Id);
            ViewBag.Gender_Id = new SelectList(db.Genders, "Id", "Title", person.Gender_Id);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Family,FatherName,BirthDate,City_Id,IdNumber,NationalCode,Gender_Id,Mobile")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.City_Id = new SelectList(db.Cities, "Id", "Code", person.City_Id);
            ViewBag.Id = new SelectList(db.Employees, "Id", "Code", person.Id);
            ViewBag.Gender_Id = new SelectList(db.Genders, "Id", "Title", person.Gender_Id);
            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
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
