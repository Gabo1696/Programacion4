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
    
    public partial class EMPLEADO
    {
        public int ID_EMPLEADO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO1 { get; set; }
        public string APELLIDO2 { get; set; }
        public int TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public int SALARIO { get; set; }
        public Nullable<int> ID_ROL { get; set; }
    
        public virtual ROL ROL { get; set; }
    }
}
