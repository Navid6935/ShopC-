using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using General.Models;

namespace General.Controllers
{
    public class BaseSalariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BaseSalaries
        public ActionResult Index()
        {
            var baseSalaries = db.BaseSalaries.Include(b => b.Year);
            return View(baseSalaries.ToList());
        }

        // GET: BaseSalaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseSalary baseSalary = db.BaseSalaries.Find(id);
            if (baseSalary == null)
            {
                return HttpNotFound();
            }
            return View(baseSalary);
        }

        // GET: BaseSalaries/Create
        public ActionResult Create()
        {
            ViewBag.YearID = new SelectList(db.Years, "ID", "Years");
            return View();
        }

        // POST: BaseSalaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,YearID,SalaryID,BaseSalaryDaily,HomeSalary,NovSalary,BonSalary,EzafehTimeSalary,RestSalary,KasrGheybat,SaftePrice,LevelPrice")] BaseSalary baseSalary)
        {
            if (ModelState.IsValid)
            {
                db.BaseSalaries.Add(baseSalary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.YearID = new SelectList(db.Years, "ID", "Years", baseSalary.YearID);
            return View(baseSalary);
        }

        // GET: BaseSalaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseSalary baseSalary = db.BaseSalaries.Find(id);
            if (baseSalary == null)
            {
                return HttpNotFound();
            }
            ViewBag.YearID = new SelectList(db.Years, "ID", "Years", baseSalary.YearID);
            return View(baseSalary);
        }

        // POST: BaseSalaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,YearID,SalaryID,BaseSalaryDaily,HomeSalary,NovSalary,BonSalary,EzafehTimeSalary,RestSalary,KasrGheybat,SaftePrice,LevelPrice")] BaseSalary baseSalary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baseSalary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.YearID = new SelectList(db.Years, "ID", "Years", baseSalary.YearID);
            return View(baseSalary);
        }

        // GET: BaseSalaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseSalary baseSalary = db.BaseSalaries.Find(id);
            if (baseSalary == null)
            {
                return HttpNotFound();
            }
            return View(baseSalary);
        }

        // POST: BaseSalaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaseSalary baseSalary = db.BaseSalaries.Find(id);
            db.BaseSalaries.Remove(baseSalary);
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
