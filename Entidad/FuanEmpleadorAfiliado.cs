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
    
    public partial class FuanEmpleadorAfiliado
    {
        public int idFuanEmpleadorAfiliado { get; set; }
        public int idFuanAfiliado { get; set; }
        public string nombreFuanEmpleadorAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string identificacionFuanEmpleadorAfiliado { get; set; }
        public string tipoPagadorFuanEmpleadorAfiliado { get; set; }
        public string direccionFuanEmpleadorAfiliado { get; set; }
        public string telefonoFuanEmpleadorAfiliado { get; set; }
        public string emailFuanEmpleadorAfiliado { get; set; }
        public short idCiudad { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
    }
}
