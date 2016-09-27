//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaboratorioMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persona()
        {
            this.cuenta = new HashSet<cuenta>();
            this.telefono = new HashSet<telefono>();
        }

        [StringLength(20)]
        [Required(ErrorMessage = "El nombre es un campo requerido.")]
        [Display(Name = "Nombre:")]
        [RegularExpression(@"^[a-zA-Z''-'\s]+$", ErrorMessage = "El nombre solo puede estar compuesto por letras")]
        public string nombre { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "El apellido es un campo requerido.")]
        [Display(Name = "Nombre:")]
        [RegularExpression(@"^[a-zA-Z''-'\s]+$", ErrorMessage = "El apellido solo puede estar compuesto por letras")]
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuenta> cuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<telefono> telefono { get; set; }
    }
}
