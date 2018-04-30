using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class ReporteFraminghamModel
    {
        public DateTime fechaAplicacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public DateTime fechaNacimientoFuanAfiliado { get; set; }
        public int edadAfiliado { get; set; }
        public string codigoTipoSexo { get; set; }
        public string nombreGrupoPoblacional { get; set; }       
        public string nombreCondicionDiscapacidad { get; set; }
        public string nombreTipoZona { get; set; }
        public string direccionFuanAfiliado { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string hta { get; set; }
        public int colesterolTotal { get; set; }
        public int colesterolH { get; set; }
        public int puntajeTotal { get; set; }
        public string clasificacionIMC { get; set; }
        public int puntajeIMC { get; set; }
        public short? perimetroAbdominalIfppir { get; set; }
        public int puntajePerimetroAbdominalIfppir { get; set; }
        public int puntajeFR { get; set; }
        public string clasificacionFR { get; set; }
        public string IPS { get; set; }
        public string cicloVital { get; set; }
        public int totalPuntaje { get; set; }
    }
}