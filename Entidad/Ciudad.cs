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
    
    public partial class Ciudad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudad()
        {
            this.AsistenciaGeneral = new HashSet<AsistenciaGeneral>();
            this.FuanAfiliado = new HashSet<FuanAfiliado>();
            this.FuanBeneficiariosAfiliado = new HashSet<FuanBeneficiariosAfiliado>();
            this.FuanEmpleadorAfiliado = new HashSet<FuanEmpleadorAfiliado>();
            this.FuanEntidadTerritorial = new HashSet<FuanEntidadTerritorial>();
            this.InfoHfdfr = new HashSet<InfoHfdfr>();
            this.InfoPurisu = new HashSet<InfoPurisu>();
            this.Ips = new HashSet<Ips>();
        }
    
        public short idCiudad { get; set; }
        public byte idDepartamento { get; set; }
        public string codigoCiudad { get; set; }
        public string nombreCiudad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaGeneral> AsistenciaGeneral { get; set; }
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanAfiliado> FuanAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanBeneficiariosAfiliado> FuanBeneficiariosAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanEmpleadorAfiliado> FuanEmpleadorAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanEntidadTerritorial> FuanEntidadTerritorial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoHfdfr> InfoHfdfr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoPurisu> InfoPurisu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ips> Ips { get; set; }
    }
}
