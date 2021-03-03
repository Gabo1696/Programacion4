using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntidadCliente
    {
        public int id_Cliente { get; set; }
        public int cedula_cliente { get; set; }
        public string nombre_Cliente { get; set; }
        public string correo_Cliente { get; set; }
        public string telefono_Cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string contrasena { get; set; }
    }
}
