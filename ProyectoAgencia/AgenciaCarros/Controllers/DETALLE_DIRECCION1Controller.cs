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
    public class DETALLE_DIRECCION1Controller : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: DETALLE_DIRECCION1
        public ActionResult Index()
        {
            var dETALLE_DIRECCION = db.DETALLE_DIRECCION.Include(d => d.CANTON).Include(d => d.PROVINCIA).Include(d => d.DISTRITO);
            return View(dETALLE_DIRECCION.ToList());
        }

        // GET: DETALLE_DIRECCION1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DETALLE_DIRECCION dETALLE_DIRECCION = db.DETALLE_DIRECCION.Find(id);
            if (dETALLE_DIRECCION == null)
            {
                return HttpNotFound();
            }
            return View(dETALLE_DIRECCION);
        }

        // GET: DETALLE_DIRECCION1/Create
        public ActionResult Create()
        {
            
            ViewBag.ID_CANTON = new SelectList(db.CANTON, "ID_CANTON", "NOMBRE_CANTON");
            ViewBag.ID_PROVINCIA = new SelectList(db.PROVINCIA, "ID_PROVINCIA", "NOMBRE_PROVINCIA");
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "NOMBRE_DISTRITO");
            return View();
        }

        // POST: DETALLE_DIRECCION1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DIRECCION,DESCRIPCION,ID_PROVINCIA,ID_CANTON,ID_DISTRITO")] DETALLE_DIRECCION dETALLE_DIRECCION)
        {
            if (ModelState.IsValid)
            {
                db.DETALLE_DIRECCION.Add(dETALLE_DIRECCION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CANTON = new SelectList(db.CANTON, "ID_CANTON", "NOMBRE_CANTON", dETALLE_DIRECCION.ID_CANTON);
            ViewBag.ID_PROVINCIA = new SelectList(db.PROVINCIA, "ID_PROVINCIA", "NOMBRE_PROVINCIA", dETALLE_DIRECCION.ID_PROVINCIA);
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "NOMBRE_DISTRITO", dETALLE_DIRECCION.ID_DISTRITO);
            return View(dETALLE_DIRECCION);
        }
       

        // GET: DETALLE_DIRECCION1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DETALLE_DIRECCION dETALLE_DIRECCION = db.DETALLE_DIRECCION.Find(id);
            if (dETALLE_DIRECCION == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CANTON = new SelectList(db.CANTON, "ID_CANTON", "NOMBRE_CANTON", dETALLE_DIRECCION.ID_CANTON);
            ViewBag.ID_PROVINCIA = new SelectList(db.PROVINCIA, "ID_PROVINCIA", "NOMBRE_PROVINCIA", dETALLE_DIRECCION.ID_PROVINCIA);
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "NOMBRE_DISTRITO", dETALLE_DIRECCION.ID_DISTRITO);
            return View(dETALLE_DIRECCION);
        }

        // POST: DETALLE_DIRECCION1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DIRECCION,DESCRIPCION,ID_PROVINCIA,ID_CANTON,ID_DISTRITO")] DETALLE_DIRECCION dETALLE_DIRECCION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dETALLE_DIRECCION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CANTON = new SelectList(db.CANTON, "ID_CANTON", "NOMBRE_CANTON", dETALLE_DIRECCION.ID_CANTON);
            ViewBag.ID_PROVINCIA = new SelectList(db.PROVINCIA, "ID_PROVINCIA", "NOMBRE_PROVINCIA", dETALLE_DIRECCION.ID_PROVINCIA);
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "NOMBRE_DISTRITO", dETALLE_DIRECCION.ID_DISTRITO);
            return View(dETALLE_DIRECCION);
        }

        // GET: DETALLE_DIRECCION1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DETALLE_DIRECCION dETALLE_DIRECCION = db.DETALLE_DIRECCION.Find(id);
            if (dETALLE_DIRECCION == null)
            {
                return HttpNotFound();
            }
            return View(dETALLE_DIRECCION);
        }

        // POST: DETALLE_DIRECCION1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DETALLE_DIRECCION dETALLE_DIRECCION = db.DETALLE_DIRECCION.Find(id);
            db.DETALLE_DIRECCION.Remove(dETALLE_DIRECCION);
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
