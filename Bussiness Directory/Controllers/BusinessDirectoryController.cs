using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bussiness_Directory.Models;

namespace Bussiness_Directory.Controllers
{
    public class BusinessDirectoryController : Controller
    {
        private BusinessDBContext db = new BusinessDBContext();

        // GET: BusinessDirectory
        public ActionResult Index()
        {
            return View(db.Bussinesses.ToList());
        }

        // GET: BusinessDirectory/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bussiness bussiness = db.Bussinesses.Find(id);
            if (bussiness == null)
            {
                return HttpNotFound();
            }
            return View(bussiness);
        }

        // GET: BusinessDirectory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessDirectory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bussinessId,Bussname,location,BussPhoneNumber,Busslogo,discription")] Bussiness bussiness)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Bussinesses.Add(bussiness);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("~Views/BusinessDirectory/Error.cshtml");
                }
            }

            return View(bussiness);
        }

        // GET: BusinessDirectory/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bussiness bussiness = db.Bussinesses.Find(id);
            if (bussiness == null)
            {
                return HttpNotFound();
            }
            return View(bussiness);
        }

        // POST: BusinessDirectory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Bussname,location,BussPhoneNumber,Busslogo,discription")] Bussiness bussiness)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bussiness).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bussiness);
        }

        // GET: BusinessDirectory/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bussiness bussiness = db.Bussinesses.Find(id);
            if (bussiness == null)
            {
                return HttpNotFound();
            }
            return View(bussiness);
        }

        // POST: BusinessDirectory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Bussiness bussiness = db.Bussinesses.Find(id);
            db.Bussinesses.Remove(bussiness);
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
