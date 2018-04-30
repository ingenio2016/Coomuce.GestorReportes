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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.AsistenciaGeneral = new HashSet<AsistenciaGeneral>();
            this.EncuestaEps = new HashSet<EncuestaEps>();
            this.EncuestaIps = new HashSet<EncuestaIps>();
            this.Fuan = new HashSet<Fuan>();
            this.FuanEntidadTerritorial = new HashSet<FuanEntidadTerritorial>();
            this.FuanReporteNovedad = new HashSet<FuanReporteNovedad>();
            this.InfoHfdfr = new HashSet<InfoHfdfr>();
            this.InfoIfppir = new HashSet<InfoIfppir>();
            this.InfoPurisu = new HashSet<InfoPurisu>();
        }
    
        public int idUsuario { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string identificacionUsuario { get; set; }
        public string primerApellidoUsuario { get; set; }
        public string segundoApellidoUsuario { get; set; }
        public string primerNombreUsuario { get; set; }
        public string segundoNombreUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string celularUsuario { get; set; }
        public byte idRol { get; set; }
        public string loginUsuario { get; set; }
        public string passwordUsuario { get; set; }
        public string passwordHashUsuario { get; set; }
        public string passwordSaltUsuario { get; set; }
        public bool esTemporalUsuario { get; set; }
        public bool estaHabilitadoUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaGeneral> AsistenciaGeneral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaEps> EncuestaEps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaIps> EncuestaIps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fuan> Fuan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanEntidadTerritorial> FuanEntidadTerritorial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanReporteNovedad> FuanReporteNovedad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoHfdfr> InfoHfdfr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoIfppir> InfoIfppir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoPurisu> InfoPurisu { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        public virtual Rol Rol { get; set; }
    }
}