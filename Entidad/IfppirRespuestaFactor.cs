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
    
    public partial class IfppirRespuestaFactor
    {
        public int idInfoIfppir { get; set; }
        public short idPreguntasSubFactorRiesgo { get; set; }
        public bool respuestaSiIfppirRespuestaFactor { get; set; }
        public bool respuestaNoIfppirRespuestaFactor { get; set; }
    
        public virtual InfoIfppir InfoIfppir { get; set; }
        public virtual PreguntasSubFactorRiesgo PreguntasSubFactorRiesgo { get; set; }
    }
}
