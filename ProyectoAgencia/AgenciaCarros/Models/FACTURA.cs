//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaCarros.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        public int ID_FACTURA { get; set; }
        public System.DateTime FECHA { get; set; }
        public int IMPORTE_TOTAL { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public Nullable<int> ID_REPUESTO { get; set; }
        public Nullable<int> ID_VEHICULO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual REPUESTO REPUESTO { get; set; }
        public virtual VEHICULO VEHICULO { get; set; }
    }
}
