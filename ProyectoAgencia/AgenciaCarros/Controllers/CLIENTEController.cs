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
    public class CLIENTEController : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: CLIENTE
        public ActionResult Index()
        {
            var cLIENTE = db.CLIENTE.Include(c => c.INGRESO).Include(c => c.DETALLE_DIRECCION);
            return View(cLIENTE.ToList());
        }

        // GET: CLIENTE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // GET: CLIENTE/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTE = new SelectList(db.INGRESO, "ID_CLIENTE", "USUARIO");
            ViewBag.ID_DIRECCION = new SelectList(db.DETALLE_DIRECCION, "ID_DIRECCION", "DESCRIPCION");
            return View();
        }

        // POST: CLIENTE/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CLIENTE,CEDULA,NOMBRE,APELLIDO1,APELLIDO2,EMAIL,TELEFONO,ID_DIRECCION")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTE.Add(cLIENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTE = new SelectList(db.INGRESO, "ID_CLIENTE", "USUARIO", cLIENTE.ID_CLIENTE);
            ViewBag.ID_DIRECCION = new SelectList(db.DETALLE_DIRECCION, "ID_DIRECCION", "DESCRIPCION", cLIENTE.ID_DIRECCION);
            return View(cLIENTE);
        }

        // GET: CLIENTE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTE = new SelectList(db.INGRESO, "ID_CLIENTE", "USUARIO", cLIENTE.ID_CLIENTE);
            ViewBag.ID_DIRECCION = new SelectList(db.DETALLE_DIRECCION, "ID_DIRECCION", "DESCRIPCION", cLIENTE.ID_DIRECCION);
            return View(cLIENTE);
        }

        // POST: CLIENTE/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CLIENTE,CEDULA,NOMBRE,APELLIDO1,APELLIDO2,EMAIL,TELEFONO,ID_DIRECCION")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTE = new SelectList(db.INGRESO, "ID_CLIENTE", "USUARIO", cLIENTE.ID_CLIENTE);
            ViewBag.ID_DIRECCION = new SelectList(db.DETALLE_DIRECCION, "ID_DIRECCION", "DESCRIPCION", cLIENTE.ID_DIRECCION);
            return View(cLIENTE);
        }

        // GET: CLIENTE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // POST: CLIENTE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CLIENTE cLIENTE = db.CLIENTE.Find(id);
            db.CLIENTE.Remove(cLIENTE);
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
