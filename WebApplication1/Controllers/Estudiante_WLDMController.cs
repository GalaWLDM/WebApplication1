using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Estudiante_WLDMController : Controller
    {
        private UNACDBEntities1 db = new UNACDBEntities1();

        // GET: Estudiante_WLDM
        public ActionResult Index()
        {
            return View(db.Estudiante_WLDM.ToList());
        }

        // GET: Estudiante_WLDM/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante_WLDM estudiante_WLDM = db.Estudiante_WLDM.Find(id);
            if (estudiante_WLDM == null)
            {
                return HttpNotFound();
            }
            return View(estudiante_WLDM);
        }

        // GET: Estudiante_WLDM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante_WLDM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Nombre,Id,Telefono,Edad")] Estudiante_WLDM estudiante_WLDM)
        {
            if (ModelState.IsValid)
            {
                db.Estudiante_WLDM.Add(estudiante_WLDM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estudiante_WLDM);
        }

        // GET: Estudiante_WLDM/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante_WLDM estudiante_WLDM = db.Estudiante_WLDM.Find(id);
            if (estudiante_WLDM == null)
            {
                return HttpNotFound();
            }
            return View(estudiante_WLDM);
        }

        // POST: Estudiante_WLDM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Nombre,Id,Telefono,Edad")] Estudiante_WLDM estudiante_WLDM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudiante_WLDM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estudiante_WLDM);
        }

        // GET: Estudiante_WLDM/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudiante_WLDM estudiante_WLDM = db.Estudiante_WLDM.Find(id);
            if (estudiante_WLDM == null)
            {
                return HttpNotFound();
            }
            return View(estudiante_WLDM);
        }

        // POST: Estudiante_WLDM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Estudiante_WLDM estudiante_WLDM = db.Estudiante_WLDM.Find(id);
            db.Estudiante_WLDM.Remove(estudiante_WLDM);
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
