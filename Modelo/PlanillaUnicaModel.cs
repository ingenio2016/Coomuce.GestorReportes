using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class PlanillaUnicaModel
    {
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public DateTime fechaAtencionPurisu { get; set; }
	    public string primerApellidoFuanAfiliado { get; set; } 
        public string segundoApellidoFuanAfiliado { get; set; } 
        public string primerNombreFuanAfiliado { get; set; } 
        public string segundoNombreFuanAfiliado { get; set; } 
        public string codigoTipoIdentificacion { get; set; } 
        public string identificacionFuanAfiliado { get; set; } 
        public string numCarnetFuanAfiliado { get; set; } 
        public string codigoTipoSexo { get; set; } 
        public DateTime fechaNacimientoFuanAfiliado { get; set; } 
        public int edadFuanAfiliado { get; set; } 
        public string nombreTipoVisitaDomiciliaria { get; set; } 
        public bool usisPurisu { get; set; } 
        public bool ipsPrimariaPurisu { get; set; } 
        public bool telefonicaPurisu { get; set; } 
        public bool cauPurisu { get; set; } 
        public bool actividadExtramuralPurisu { get; set; } 
        public string descripcionProgramaResolucion412 { get; set; } 
        public string descripcionGrupoInteres { get; set; } 
        public string nombreSeguimientoProgramasIntervencionRiesgo { get; set; } 
	    public string motivoConsulta1 { get; set; }
	    public string motivoConsulta2 { get; set; }
	    public string motivoContacto1 { get; set; }
	    public string motivoContacto2 { get; set; }
	    public string numAutorizacionPurisu { get; set; } 
        public string nombreGruposFocales { get; set; } 
        public string nombreEje1 { get; set; } 
        public string nombreUnidad1 { get; set; } 
        public string nombreModulo1 { get; set; } 
        public string nombreEje2 { get; set; } 
        public string nombreUnidad2 { get; set; } 
        public string nombreModulo2 { get; set; }
	    public string piezaInformativa1 { get; set; } 
	    public string piezaInformativa2 { get; set; }
        public string piezaInformativa3 { get; set; }
        public string digitadoPor { get; set; }
    }
}