using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class ConsolidadoFactorRiesgo
    {
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public DateTime fechaVisitaHfdfr { get; set; }
	    public string diligenciadoPor { get; set; }
	    public string numCarnetFuanAfiliado { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
	    public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public bool estadoAfiliado { get; set; }
	    public string digitadoPor { get; set; }
	    public DateTime fechaDigitacion { get; set; }
    }
}