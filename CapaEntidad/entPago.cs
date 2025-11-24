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
        public entEstudiante estudiante { get; set; }
        public DateTime FechaPago { get; set; }
        public entModalidadPago modalidadPago { get; set; }
        public bool EstadoPago { get; set; }
        public entPago()
        {
            estudiante = new entEstudiante();
            modalidadPago = new entModalidadPago();
        }
        public string NombreCompleto
        {
            get { return $"{IdPago}"; }
        }
    }
}
