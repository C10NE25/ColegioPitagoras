using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Notas
    {
        public int IdNota { get; set; }
        public int IdEstudiante { get; set; }
        public int IdTipoEvaluacion { get; set; }
        public decimal NumNota { get; set; }
        public DateTime FechaNota { get; set; }
        public bool EstadoNota { get; set; }
    }
}
