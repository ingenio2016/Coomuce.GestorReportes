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
    
    public partial class InfoHfdfr
    {
        public int idInfoHfdfr { get; set; }
        public string tipoDiligenciamientoHfdfr { get; set; }
        public System.DateTime fechaVisitaHfdfr { get; set; }
        public string horaInicioHfdfr { get; set; }
        public string horaFinHfdfr { get; set; }
        public int idFuanAfiliado { get; set; }
        public short idCiudad { get; set; }
        public string veredaInfoHfdfr { get; set; }
        public string barrioInfoHfdfr { get; set; }
        public string telefonoInfoHfdfr { get; set; }
        public string historiaInfoHfdfr { get; set; }
        public string archivoAudioHfdfr { get; set; }
        public string firmaHfdfr { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<System.DateTime> fechaInfoHfdfr { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}