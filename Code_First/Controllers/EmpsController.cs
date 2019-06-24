using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Code_First.Models;

namespace Code_First.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        commonContext db = new commonContext();
        public ActionResult Index()
        {

            return View(db.Emps.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,EmpName, EmpSalary ,EmpReport")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public ActionResult Delete(int ? Id)
        {
            Emp emp = db.Emps.Find(Id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
           
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Emp emp = db.Emps.Find(id);
            db.Emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            Emp emp = db.Emps.Find(Id);
            return View(emp);
        }
    }
}