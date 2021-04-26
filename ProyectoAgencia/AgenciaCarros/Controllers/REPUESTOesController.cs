using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AgenciaCarros.Models;

namespace AgenciaCarros.Controllers
{
    public class REPUESTOesController : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: REPUESTOes
        public ActionResult Index()
        {
            return View(db.REPUESTO.ToList());
        }

        // GET: REPUESTOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPUESTO rEPUESTO = db.REPUESTO.Find(id);
            if (rEPUESTO == null)
            {
                return HttpNotFound();
            }
            return View(rEPUESTO);
        }

        // GET: REPUESTOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: REPUESTOes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REPUESTO,NOMBRE,DESCRIPCION,PRECIO_UNITARIO")] REPUESTO rEPUESTO)
        {
            if (ModelState.IsValid)
            {
                db.REPUESTO.Add(rEPUESTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rEPUESTO);
        }

        // GET: REPUESTOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPUESTO rEPUESTO = db.REPUESTO.Find(id);
            if (rEPUESTO == null)
            {
                return HttpNotFound();
            }
            return View(rEPUESTO);
        }

        // POST: REPUESTOes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REPUESTO,NOMBRE,DESCRIPCION,PRECIO_UNITARIO")] REPUESTO rEPUESTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rEPUESTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rEPUESTO);
        }

        // GET: REPUESTOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPUESTO rEPUESTO = db.REPUESTO.Find(id);
            if (rEPUESTO == null)
            {
                return HttpNotFound();
            }
            return View(rEPUESTO);
        }

        // POST: REPUESTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REPUESTO rEPUESTO = db.REPUESTO.Find(id);
            db.REPUESTO.Remove(rEPUESTO);
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
