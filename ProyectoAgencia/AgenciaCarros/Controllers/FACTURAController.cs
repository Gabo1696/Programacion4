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
    public class FACTURAController : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: FACTURA
        public ActionResult Index()
        {
            var fACTURA = db.FACTURA.Include(f => f.CLIENTE).Include(f => f.REPUESTO).Include(f => f.VEHICULO);
            return View(fACTURA.ToList());
        }

        // GET: FACTURA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACTURA fACTURA = db.FACTURA.Find(id);
            if (fACTURA == null)
            {
                return HttpNotFound();
            }
            return View(fACTURA);
        }

        // GET: FACTURA/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE");
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE");
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULO, "ID_VEHICULO", "MARCA");
            return View();
        }

        // POST: FACTURA/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_FACTURA,FECHA,UNIDADES,IMPORTE_TOTAL,ID_CLIENTE,ID_REPUESTO,ID_VEHICULO")] FACTURA fACTURA)
        {
            if (ModelState.IsValid)
            {
                db.FACTURA.Add(fACTURA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", fACTURA.ID_CLIENTE);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", fACTURA.ID_REPUESTO);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULO, "ID_VEHICULO", "MARCA", fACTURA.ID_VEHICULO);
            return View(fACTURA);
        }

        // GET: FACTURA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACTURA fACTURA = db.FACTURA.Find(id);
            if (fACTURA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", fACTURA.ID_CLIENTE);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", fACTURA.ID_REPUESTO);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULO, "ID_VEHICULO", "MARCA", fACTURA.ID_VEHICULO);
            return View(fACTURA);
        }

        // POST: FACTURA/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_FACTURA,FECHA,UNIDADES,IMPORTE_TOTAL,ID_CLIENTE,ID_REPUESTO,ID_VEHICULO")] FACTURA fACTURA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fACTURA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", fACTURA.ID_CLIENTE);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", fACTURA.ID_REPUESTO);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULO, "ID_VEHICULO", "MARCA", fACTURA.ID_VEHICULO);
            return View(fACTURA);
        }

        // GET: FACTURA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACTURA fACTURA = db.FACTURA.Find(id);
            if (fACTURA == null)
            {
                return HttpNotFound();
            }
            return View(fACTURA);
        }

        // POST: FACTURA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FACTURA fACTURA = db.FACTURA.Find(id);
            db.FACTURA.Remove(fACTURA);
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
