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
        public int IdEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTipoAsistencia { get; set; }
    }
}
