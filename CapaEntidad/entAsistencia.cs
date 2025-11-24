using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAsistencia
    {
        public int IdAsistencia { get; set; }
        public entEstudiante estudiante { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTipoAsistencia { get; set; }
        public bool EstadoAsistencia { get; set; }

        public entAsistencia()
        {
            estudiante = new entEstudiante();
        }
    }
}
