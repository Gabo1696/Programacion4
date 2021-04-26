using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgenciaCarros.Models;

namespace AgenciaCarros.Clases
{
    public class Persona
    {
        public int ID_CLIENTE { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }

        ProyectoAgenciaEntities db = new ProyectoAgenciaEntities();

        public bool Autenticar()
        {
            return db.INGRESO.Where(u => u.USUARIO == this.USUARIO && u.CONTRASENA == this.CONTRASENA).FirstOrDefault()!=null;
        }
    }
}