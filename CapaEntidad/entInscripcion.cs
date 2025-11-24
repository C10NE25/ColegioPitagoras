using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entInscripcion
    {
        public int IdInscripcion { get; set; }
        public entEstudiante estudiante { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool EstadoInscripcion { get; set; }
        public entInscripcion()
        {
            estudiante = new entEstudiante();
        }
    }
}
