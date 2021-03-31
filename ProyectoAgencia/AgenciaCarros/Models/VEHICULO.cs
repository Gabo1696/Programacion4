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
    using System.ComponentModel.DataAnnotations;

    public partial class VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULO()
        {
            this.FACTURA = new HashSet<FACTURA>();
        }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int ID_VEHICULO { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int PLACA { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string MARCA { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string MODELO { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public Nullable<System.DateTime> ANNO { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int CILINDRAJE { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string COLOR { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string TIPO_COMBUSTIBLE { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int PRECIO_UNITARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA> FACTURA { get; set; }

        
    }
    public enum TIPO_COMBUSTIBLE
        {
            Gasolina,
            Diesel,
            Super
        }
}
