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
    
    public partial class EncuestaEps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncuestaEps()
        {
            this.EncuestaEpsRespLiteral = new HashSet<EncuestaEpsRespLiteral>();
            this.EncuestaEpsRespPregunta = new HashSet<EncuestaEpsRespPregunta>();
        }
    
        public int idEncuestaEps { get; set; }
        public System.DateTime fechaHoraEncuestaEps { get; set; }
        public int idFuanAfiliado { get; set; }
        public int idIps { get; set; }
        public string observacionEncuestaEps { get; set; }
        public int idUsuario { get; set; }
    
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        public virtual Ips Ips { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaEpsRespLiteral> EncuestaEpsRespLiteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaEpsRespPregunta> EncuestaEpsRespPregunta { get; set; }
    }
}
