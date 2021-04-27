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
    public class EMPLEADOController : Controller
    {
        private ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        // GET: EMPLEADO
        public ActionResult Index()
        {
            var eMPLEADO = db.EMPLEADO.Include(e => e.ROL);
            return View(eMPLEADO.ToList());
        }

        // GET: EMPLEADO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLEADO eMPLEADO = db.EMPLEADO.Find(id);
            if (eMPLEADO == null)
            {
                return HttpNotFound();
            }
            return View(eMPLEADO);
        }

        // GET: EMPLEADO/Create
        public ActionResult Create()
        {
            ViewBag.ID_ROL = new SelectList(db.ROL, "ID_ROL", "DESCRIPCION");
            return View();
        }

        // POST: EMPLEADO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_EMPLEADO,NOMBRE,APELLIDO1,APELLIDO2,TELEFONO,EMAIL,SALARIO,ID_ROL")] EMPLEADO eMPLEADO)
        {
            if (ModelState.IsValid)
            {
                if (db.EMPLEADO.Any(x => x.ID_EMPLEADO == eMPLEADO.ID_EMPLEADO))
                {
                    ModelState.AddModelError("", "Ya existe el id");
                }
                else
                {
                    db.EMPLEADO.Add(eMPLEADO);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.ID_ROL = new SelectList(db.ROL, "ID_ROL", "DESCRIPCION", eMPLEADO.ID_ROL);
            return View(eMPLEADO);
        }

        // GET: EMPLEADO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLEADO eMPLEADO = db.EMPLEADO.Find(id);
            if (eMPLEADO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ROL = new SelectList(db.ROL, "ID_ROL", "DESCRIPCION", eMPLEADO.ID_ROL);
            return View(eMPLEADO);
        }

        // POST: EMPLEADO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_EMPLEADO,NOMBRE,APELLIDO1,APELLIDO2,TELEFONO,EMAIL,SALARIO,ID_ROL")] EMPLEADO eMPLEADO)
        {
            if (ModelState.IsValid)
            {

                db.Entry(eMPLEADO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.ID_ROL = new SelectList(db.ROL, "ID_ROL", "DESCRIPCION", eMPLEADO.ID_ROL);
            return View(eMPLEADO);
        }

        // GET: EMPLEADO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLEADO eMPLEADO = db.EMPLEADO.Find(id);
            if (eMPLEADO == null)
            {
                return HttpNotFound();
            }
            return View(eMPLEADO);
        }

        // POST: EMPLEADO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLEADO eMPLEADO = db.EMPLEADO.Find(id);
            db.EMPLEADO.Remove(eMPLEADO);
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
