//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSignosVitales.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pacientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pacientes()
        {
            this.expediente = new HashSet<expediente>();
            this.sig_vit = new HashSet<sig_vit>();
        }
    
        public int Idpaciente { get; set; }
        public string Nombrepas { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Estadocivil { get; set; }
        public Nullable<System.DateTime> Fecha_nac { get; set; }
        public string Domicilio { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<expediente> expediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sig_vit> sig_vit { get; set; }
    }
}