using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class ReporteFindriskModel
    {
        public DateTime fechaAplicacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public DateTime fechaNacimientoFuanAfiliado { get; set; }
        public int edadAfiliado { get; set; }
        public int puntajeEdad { get; set; }
        public string codigoTipoSexo { get; set; }
        public string nombreGrupoPoblacional { get; set; }       
        public string nombreCondicionDiscapacidad { get; set; }
        public string nombreTipoZona { get; set; }
        public string direccionFuanAfiliado { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public decimal? pesoIfppir { get; set; }
        public short? tallaIfppir { get; set; }
        public int clasificacionCorporal { get; set; }
        public string clasificacionIMC { get; set; }
        public short? perimetroAbdominalIfppir { get; set; }
        public int pregunta27 { get; set; }
        public int pregunta26 { get; set; }
        public int pregunta125 { get; set; }
        public int pregunta126 { get; set; }
        public int pregunta127 { get; set; }
        public int pregunta128 { get; set; }
        public int pregunta130 { get; set; }
        public int pregunta131 { get; set; }
        public int pregunta132 { get; set; }
        public int totalPuntajeEdad { get; set; }
        public int riesgoDiabeticoEdad { get; set; }
        public string clasificacionFindrisk { get; set; }
        public decimal? masaCorporalIfppir { get; set; }
        public string IPS { get; set; }
        public string cicloVital { get; set; }
        public int totalPuntaje { get; set; }
    }
}