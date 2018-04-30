using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class IpsModel
    {
        public int idIps { get; set; }
        public string codigoIps { get; set; }
        public string razonIps { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionIps { get; set; }
        public string direccionIps { get; set; }
        public string telefonoIps { get; set; }
        public string nombreDepartamento { get; set; }
        public string nombreCiudad { get; set; }
        public string representanteIps { get; set; }
        public string nivelIps { get; set; }
        public string contactoIps { get; set; }
        public string emailIps { get; set; }
    }
}