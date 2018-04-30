using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.GestorReportes.Modelo
{
    public class GestionFormato
    {
        public DateTime fecha { get; set; }
        public string formato { get; set; }
        public int conteo { get; set; }
        public string nombreCompletoUsuario { get; set; }
    }
}