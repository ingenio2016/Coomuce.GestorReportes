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
    
    public partial class InfoPurisu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoPurisu()
        {
            this.Purisu = new HashSet<Purisu>();
        }
    
        public int idInfoPurisu { get; set; }
        public short idCiudad { get; set; }
        public System.DateTime fechaAtencionPurisu { get; set; }
        public int idUsuario { get; set; }
        public string archivoAudioInfoPurisu { get; set; }
        public string tipoDiligenciamientoInfoPurisu { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purisu> Purisu { get; set; }
    }
}
