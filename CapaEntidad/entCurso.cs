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
        public entDocente docente { get; set; } // llave foranea
        public entGradoAcademico gradoAcademico { get; set; } // llave foranea
        public entAsignatura asignatura { get; set; } // llave foranea
        public bool EstadoCurso { get; set; }

        public entCurso()
        {
            docente = new entDocente();
            gradoAcademico = new entGradoAcademico();
            asignatura = new entAsignatura();
        }
    }
}
