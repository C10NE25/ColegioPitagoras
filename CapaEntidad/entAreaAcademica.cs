using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAreaAcademica
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public bool EstadoAsignatura { get; set; }


        public string NombreCompleto
        {
            get { return $"{IdAsignatura} - {NombreAsignatura}"; }
        }
    }
}
