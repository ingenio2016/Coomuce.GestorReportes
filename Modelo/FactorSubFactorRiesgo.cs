using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class FactorSubFactorRiesgo
    {
        public byte idFactorRiesgo { get; set; }
        public string codigoFactorRiesgo { get; set; }
        public string nombreFactorRiesgo { get; set; }
        public string codigoSubFactorRiesgo { get; set; }
        public string nombreSubFactorRiesgo { get; set; }
    }
}