using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class ReporteGestanteModel
    {
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public string nombreCompletoAfiliado { get; set; }
        public int edadAfiliado { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public DateTime fechaAplicacionIfppir { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string celularFuanAfiliado { get; set; }
        public DateTime? furIfppir { get; set; }
        public DateTime? fppIfppir { get; set; }
        public int pregunta92 { get; set; }
        public int pregunta93 { get; set; }
        public int pregunta95 { get; set; }
        public int pregunta97 { get; set; }
        public int pregunta98 { get; set; }
        public int pregunta99 { get; set; }
        public int pregunta101 { get; set; }
        public int pregunta102 { get; set; }
        public int pregunta103 { get; set; }
        public int pregunta104 { get; set; }
        public int pregunta105 { get; set; }
        public int pregunta106 { get; set; }
        public int pregunta107 { get; set; }
        public int pregunta108 { get; set; }
        public int pregunta109 { get; set; }
        public int pregunta110 { get; set; }
        public int pregunta111 { get; set; }
        public int pregunta120 { get; set; }
        public int totalRiesgo { get; set; }
        public int edadGestacional { get; set; }
        public string ipsPrimaria { get; set; }
    }
}