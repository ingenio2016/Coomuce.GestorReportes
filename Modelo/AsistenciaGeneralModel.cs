using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class AsistenciaGeneralModel
    {
        public string nombreDepartamento { get; set; } 
        public string nombreCiudad { get; set; } 
        public string grupoFocal { get; set; } 
	    public string temaAsistenciaGeneral { get; set; } 
        public string eje { get; set; }
	    public string unidad { get; set; }
        public string modulo { get; set; } 
        public string formadorAsistenciaGeneral { get; set; } 
        public DateTime fechaAsistenciaGeneral { get; set; }
	    public string nombreFuanAfiliado { get; set; }
	    public string codigoTipoIdentificacion { get; set; } 
        public string identificacionFuanAfiliado { get; set; } 
        public string areaEntidadListaAsistenciaGeneral { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string digitadoPor { get; set; }
    }
}