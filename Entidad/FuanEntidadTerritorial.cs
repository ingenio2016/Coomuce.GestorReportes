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
    
    public partial class FuanEntidadTerritorial
    {
        public int idFuan { get; set; }
        public short idCiudad { get; set; }
        public string numFichaSisbenFuanEntidadTerritorial { get; set; }
        public string puntajeSisbenFuanEntidadTerritorial { get; set; }
        public string nivelSisbenFuanEntidadTerritorial { get; set; }
        public System.DateTime fechaRadicacionFuanEntidadTerritorial { get; set; }
        public System.DateTime fechaValidacionFuanEntidadTerritorial { get; set; }
        public int idUsuario { get; set; }
        public string observacionFuanEntidadTerritorial { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual Fuan Fuan { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
