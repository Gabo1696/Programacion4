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

    public partial class EMPLEADO
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int ID_EMPLEADO { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string NOMBRE { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]

        public string APELLIDO1 { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]

        public string APELLIDO2 { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(8, 10, ErrorMessage = "Debe digitar entre 8 a 10 numeros")]
        public int TELEFONO { get; set; }
        [EmailAddress]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int SALARIO { get; set; }
        public Nullable<int> ID_ROL { get; set; }
    
        public virtual ROL ROL { get; set; }
    }
}
