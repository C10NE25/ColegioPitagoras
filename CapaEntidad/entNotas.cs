using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNotas
    {
        public int IdNota { get; set; }
        public entEstudiante estudiante { get; set; }
        public entTipoEvaluacion tipoEvaluacion { get; set; }
        public decimal NumNota { get; set; }
        public DateTime FechaNota { get; set; }
        public bool EstadoNota { get; set; }
        public entNotas()
        {
            estudiante = new entEstudiante();
            tipoEvaluacion = new entTipoEvaluacion();
        }
    }
}
