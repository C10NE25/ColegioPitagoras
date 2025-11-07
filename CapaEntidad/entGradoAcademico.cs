using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entGradoAcademico
    {
        public int IdGradoAcademico { get; set; }
        public string NombreGradoAcademico { get; set; }
        public int IdNivelAcademico { get; set; }   // llave foranea
        public int IdSeccion { get; set; } // llave foranea
        public bool EstadoGradoAcademico { get; set; }
    }
}
