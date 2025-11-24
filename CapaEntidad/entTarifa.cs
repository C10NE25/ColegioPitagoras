using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTarifa
    {
        public int IdTarifa { get; set; }
        public string NombreTarifa { get; set; }
        public decimal MontoTarifa { get; set; }
        public entPeriodoAcademico periodoAcademico { get; set; }
        public bool EstadoTarifa { get; set; }
        public entTarifa()
        {
            periodoAcademico = new entPeriodoAcademico();
        }
        public string NombreCompleto
        {
            get { return $"{NombreTarifa} - {MontoTarifa}"; }
        }
    }
}
