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
    
    public partial class CANTON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANTON()
        {
            this.DISTRITO = new HashSet<DISTRITO>();
            this.DETALLE_DIRECCION = new HashSet<DETALLE_DIRECCION>();
        }
    
        public int ID_CANTON { get; set; }
        public string NOMBRE_CANTON { get; set; }
        public Nullable<int> ID_PROVINCIA { get; set; }
    
        public virtual PROVINCIA PROVINCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRITO> DISTRITO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_DIRECCION> DETALLE_DIRECCION { get; set; }
    }
}