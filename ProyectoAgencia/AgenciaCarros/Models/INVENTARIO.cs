//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaCarros.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVENTARIO
    {
        public int ID_INVENTARIO { get; set; }
        public int CANTIDAD { get; set; }
        public int VALOR { get; set; }
        public System.DateTime ULTIMA_VENTA { get; set; }
        public Nullable<int> ID_REPUESTO { get; set; }
    
        public virtual REPUESTO REPUESTO { get; set; }
    }
}