using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPeriodoAcademico
    {
        public int IdPeriodoAcademico { get; set; }

        public int anioPeriodoAcademico { get; set; }
        public string NombrePeriodoAcademico { get; set; }
        public bool EstadoPeriodoAcademico { get; set; }
        public string NombreCompleto
        {
            get { return $"{anioPeriodoAcademico} - {NombrePeriodoAcademico}"; }
        }
    }
}
