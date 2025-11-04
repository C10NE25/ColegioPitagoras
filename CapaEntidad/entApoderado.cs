using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entApoderado
    {
        public int IdApoderado { get; set; }
        public string DniApo { get; set; }
        public string NombreApo { get; set; }
        public string ApellidosPatApo { get; set; }
        public string ApellidosMatApo { get; set; }
        public string NumCelularApo { get; set; }
        public string DireccionApo { get; set; }
        public int IdParentesco { get; set; }
        public bool EstadoApot { get; set; }
    }
}
