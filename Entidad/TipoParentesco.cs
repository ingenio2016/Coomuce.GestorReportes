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
    
    public partial class TipoParentesco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoParentesco()
        {
            this.FuanBeneficiariosAfiliado = new HashSet<FuanBeneficiariosAfiliado>();
        }
    
        public byte idTipoParentesco { get; set; }
        public string codigoTipoParentesco { get; set; }
        public string nombreTipoParentesco { get; set; }
        public string descripcionTipoParentesco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanBeneficiariosAfiliado> FuanBeneficiariosAfiliado { get; set; }
    }
}