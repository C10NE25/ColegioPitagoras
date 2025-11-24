using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMatricula
    {
        public int IdMatricula { get; set; }
        public entInscripcion inscripcion { get; set; }
        public entGradoAcademico gradoAcademico { get; set; }
        public DateTime FechaMatricula { get; set; }
        public bool EstadoMatricula { get; set; }

        public entMatricula()
        {
            inscripcion = new entInscripcion();
            gradoAcademico = new entGradoAcademico();
        }
    }
}
