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
        public int IdInscripcion { get; set; }
        public int IdGradoAcademico { get; set; }
        public DateTime FechaMatricula { get; set; }
        public bool EstadoMatricula { get; set; }
    }
}
