//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coomuce.GestorReportes.Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class EncuestaCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncuestaCategoria()
        {
            this.EncuestaPregunta = new HashSet<EncuestaPregunta>();
        }
    
        public byte idEncuestaCategoria { get; set; }
        public string idDomVista { get; set; }
        public string codigoEncuestaCategoria { get; set; }
        public string nombreEncuestaCategoria { get; set; }
        public byte ordenEncuestaCategoria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaPregunta> EncuestaPregunta { get; set; }
    }
}