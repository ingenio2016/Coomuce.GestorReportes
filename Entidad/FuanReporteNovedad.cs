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
    
    public partial class FuanReporteNovedad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FuanReporteNovedad()
        {
            this.FuanTipoNovedad = new HashSet<FuanTipoNovedad>();
        }
    
        public int idFuanReporteNovedad { get; set; }
        public System.DateTime fechaFuanReporteNovedad { get; set; }
        public int idFuanAfiliado { get; set; }
        public string antesFuanReporteNovedad { get; set; }
        public string despuesFuanReporteNovedad { get; set; }
        public int idUsuario { get; set; }
    
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanTipoNovedad> FuanTipoNovedad { get; set; }
    }
}
