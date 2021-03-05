using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class EntidadFactura
    {
        public int id_factura { get; set; }
        public int fecha_factura { get; set; }
        public float monto_factura { get; set; }
        public int id_cliente { get; set; }

       public int id_vehiculo { get; set; } 
    }
}
