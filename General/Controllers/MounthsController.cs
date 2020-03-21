using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using General.Models;
using General.Models.Utilities;

namespace General.Controllers
{
    public class MounthsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Mounths
        public ActionResult Index()
        {
            return View(db.Mounths.ToList());
        }

        // GET: Mounths/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mounth mounth = db.Mounths.Find(id);
            if (mounth == null)
            {
                return HttpNotFound();
            }
            return View(mounth);
        }

        // GET: Mounths/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mounths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Mounth mounth)
        {
            if (ModelState.IsValid)
            {
                db.Mounths.Add(mounth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mounth);
        }

        // GET: Mounths/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mounth mounth = db.Mounths.Find(id);
            if (mounth == null)
            {
                return HttpNotFound();
            }
            return View(mounth);
        }

        // POST: Mounths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Mounth mounth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mounth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mounth);
        }

        // GET: Mounths/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mounth mounth = db.Mounths.Find(id);
            if (mounth == null)
            {
                return HttpNotFound();
            }
            return View(mounth);
        }

        // POST: Mounths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mounth mounth = db.Mounths.Find(id);
            db.Mounths.Remove(mounth);
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
