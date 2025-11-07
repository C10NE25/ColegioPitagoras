using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDocente
    {
        public int IdDocente { get; set; }
        public string DniDoc { get; set; }
        public string NombreDoc { get; set; }
        public string ApellidosPatDoc { get; set; }
        public string ApellidosMatDoc { get; set; }
        public string NumCelularDoc { get; set; }
        public string DireccionDoc { get; set; }
        public bool EstadoDoc { get; set; }
    }
}
