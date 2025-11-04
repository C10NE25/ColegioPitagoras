using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCurso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int IdDocente { get; set; } // llave foranea
        public int IdGrado { get; set; } // llave foranea
        public bool EstadoCurso { get; set; }
    }
}
