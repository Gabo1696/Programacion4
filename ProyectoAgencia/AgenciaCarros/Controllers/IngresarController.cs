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
        public ActionResult Login(Persona usuario, string url)
        {
            if (IsValid(usuario)){
                FormsAuthentication.SetAuthCookie(usuario.USUARIO, false);
                if (url != null)
                {
                    return Redirect(url);
                }
                return RedirectToAction("Index", "Home");
            }
            TempData["Mensaje"] = "Credenciales Incorrectas";
            return View(usuario);
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