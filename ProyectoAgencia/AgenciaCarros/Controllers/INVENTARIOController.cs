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
    public class INVENTARIOController : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: INVENTARIO
        public ActionResult Index()
        {
            var iNVENTARIO = db.INVENTARIO.Include(i => i.REPUESTO);
            return View(iNVENTARIO.ToList());
        }

        // GET: INVENTARIO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVENTARIO iNVENTARIO = db.INVENTARIO.Find(id);
            if (iNVENTARIO == null)
            {
                return HttpNotFound();
            }
            return View(iNVENTARIO);
        }

        // GET: INVENTARIO/Create
        public ActionResult Create()
        {
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE");
            return View();
        }

        // POST: INVENTARIO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_INVENTARIO,CANTIDAD,VALOR,ULTIMA_VENTA,ID_REPUESTO")] INVENTARIO iNVENTARIO)
        {
            if (ModelState.IsValid)
            {
                db.INVENTARIO.Add(iNVENTARIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", iNVENTARIO.ID_REPUESTO);
            return View(iNVENTARIO);
        }

        // GET: INVENTARIO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVENTARIO iNVENTARIO = db.INVENTARIO.Find(id);
            if (iNVENTARIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", iNVENTARIO.ID_REPUESTO);
            return View(iNVENTARIO);
        }

        // POST: INVENTARIO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_INVENTARIO,CANTIDAD,VALOR,ULTIMA_VENTA,ID_REPUESTO")] INVENTARIO iNVENTARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNVENTARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", iNVENTARIO.ID_REPUESTO);
            return View(iNVENTARIO);
        }

        // GET: INVENTARIO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVENTARIO iNVENTARIO = db.INVENTARIO.Find(id);
            if (iNVENTARIO == null)
            {
                return HttpNotFound();
            }
            return View(iNVENTARIO);
        }

        // POST: INVENTARIO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            try
            {
                INVENTARIO iNVENTARIO = db.INVENTARIO.Find(id);
                db.INVENTARIO.Remove(iNVENTARIO);
                db.SaveChanges();
                
            }
            catch(Exception e) {
                ViewData["data"] = "No se puede borrar porque existe un repuesto asociado";
                return View("Delete");
               
            }
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
