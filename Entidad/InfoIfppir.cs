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
    
    public partial class InfoIfppir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoIfppir()
        {
            this.IfppirRespuestaFactor = new HashSet<IfppirRespuestaFactor>();
        }
    
        public int idInfoIfppir { get; set; }
        public Nullable<System.DateTime> fechaInfoIfppir { get; set; }
        public string tipoDiligenciamientoIfppir { get; set; }
        public int idFuanAfiliado { get; set; }
        public string numCarneIfppir { get; set; }
        public string ipsPrimariaIfppir { get; set; }
        public string razaIfppir { get; set; }
        public string escolaridadIfppir { get; set; }
        public string familiarCercanoIfppir { get; set; }
        public string telefonoFamiliarIfppir { get; set; }
        public bool gestanteIfppir { get; set; }
        public System.DateTime fechaAplicacionIfppir { get; set; }
        public Nullable<decimal> pesoIfppir { get; set; }
        public Nullable<short> tallaIfppir { get; set; }
        public Nullable<decimal> masaCorporalIfppir { get; set; }
        public Nullable<short> perimetroAbdominalIfppir { get; set; }
        public Nullable<short> sistolicaIfppir { get; set; }
        public Nullable<short> diastolicaIfppir { get; set; }
        public Nullable<System.DateTime> furIfppir { get; set; }
        public Nullable<System.DateTime> fppIfppir { get; set; }
        public string colesterolTotalIfppir { get; set; }
        public string colesterolLdlIfppir { get; set; }
        public string colesterolHdlIfppir { get; set; }
        public string glicemiaIfppir { get; set; }
        public string gIfppir { get; set; }
        public string pIfppir { get; set; }
        public string cIfppir { get; set; }
        public string aIfppir { get; set; }
        public string nacidoVivoIfppir { get; set; }
        public string observacionIfppir { get; set; }
        public string archivoAudioIfppir { get; set; }
        public string firmaIfppir { get; set; }
        public Nullable<int> idUsuario { get; set; }
    
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IfppirRespuestaFactor> IfppirRespuestaFactor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}