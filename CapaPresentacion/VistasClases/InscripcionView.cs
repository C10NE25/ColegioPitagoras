using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.VistasClases
{
    public class InscripcionView
    {
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Estado { get; set; }
    }
}
