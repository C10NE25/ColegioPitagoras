using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEstudiante
    {
        public int IdEstudiante { get; set; }
        public string DniEst { get; set; }
        public string NombreEst { get; set; }
        public string ApellidosPatEst { get; set; }
        public string ApellidosMatEst { get; set; }
        public DateTime FechaNacEst { get; set; }
        public string DireccionEst { get; set; }
        public int IdApoderado { get; set; }   // llave foranea
        public bool EstadoEst { get; set; }

        public string NombreCompleto
        {
            get { return $"{NombreEst} {ApellidosPatEst} {ApellidosMatEst}"; }
        }


    }
}
