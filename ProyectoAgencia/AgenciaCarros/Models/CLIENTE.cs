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
    using System.ComponentModel.DataAnnotations;

    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.FACTURA = new HashSet<FACTURA>();
        }

        [Required(ErrorMessage = "El ID es obligatorio")]
        public int ID_CLIENTE { get; set; }
        [Required(ErrorMessage = "La cedula es obligatoria")]
        [MaxLength(9)]
        [MinLength(9)]
        public int CEDULA { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(30)]
        public string NOMBRE { get; set; }
        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [MaxLength(30)]
        public string APELLIDO1 { get; set; }
        [Required(ErrorMessage = "El segundo apellido es obligatorio")]
        [MaxLength(30)]
        public string APELLIDO2 { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [MaxLength(30)]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public int TELEFONO { get; set; }
        public Nullable<int> ID_DIRECCION { get; set; }
    
        public virtual INGRESO INGRESO { get; set; }
        public virtual DETALLE_DIRECCION DETALLE_DIRECCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA> FACTURA { get; set; }
    }
}
