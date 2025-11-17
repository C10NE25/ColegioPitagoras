using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPago
    {
        public int IdPago { get; set; }
        public int IdEstudiante { get; set; }
        public DateTime FechaPago { get; set; }
        public int IdModalidadPago { get; set; }
        public bool EstadoPago { get; set; }
        public string NombreCompleto
        {
            get { return $"{IdPago}"; }
        }
    }
}
