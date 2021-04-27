using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AgenciaCarros.Clases;
using AgenciaCarros.Models;

namespace AgenciaCarros.Controllers
{
    public class IngresarController : Controller
    {
        // GET: Ingresar
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Persona usuario)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = usuario.Autenticar();
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(usuario.USUARIO, false);
                    return RedirectToAction("Index", "CLIENTE");
                }
                
            }
            ModelState.AddModelError("", "error");
            return View();
        }

        public bool IsValid(Persona usuario)
        {
            return usuario.Autenticar();    
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}