using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class ReporteFichaIdentificacion
    {
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; } 
        public DateTime fechaInfoIfppir { get; set; } 
        public string numCarnetFuanAfiliado { get; set; } 
        public string codigoTipoIdentificacion { get; set; } 
        public string identificacionFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string nombreCompletoAfiliado { get; set; }
	    public DateTime fechaNacimientoFuanAfiliado { get; set; } 
        public string codigoTipoSexo { get; set; } 
        public int edadAfiliado { get; set; } 
        public DateTime fechaAplicacionIfppir { get; set; }
	    public decimal pesoIfppir { get; set; } 
        public short tallaIfppir { get; set; } 
        public short perimetroAbdominalIfppir { get; set; } 
        public short sistolicaIfppir { get; set; } 
        public short diastolicaIfppir { get; set; } 
        public decimal masaCorporalIfppir { get; set; }
	    public string diligenciadoPor { get; set; }
	    public string digitadoPor { get; set; }
	    public DateTime fechaDigitacion { get; set; }
    }
}