using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoCargo
    {
        public int IdTipoCargo { get; set; }
        public string NombreTipoCargo { get; set; }
        public entTarifa tarifa { get; set; }
        public bool EstadoTipoCargo { get; set; }
        public entTipoCargo()
        {
            tarifa = new entTarifa();
        }
        public string NombreCompleto
        {
            get { return $"{IdTipoCargo} - {NombreTipoCargo}"; }
        }
    }
}
