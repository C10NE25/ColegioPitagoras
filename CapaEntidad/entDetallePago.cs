using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetallePago
    {
        public int IdDetallePago { get; set; }
        public entPago pago { get; set; }
        public entTipoCargo tipoCargo { get; set; }
        public decimal MontoPagado { get; set; }
        public bool EstadoDetallePago { get; set; }

        public entDetallePago() { 
            pago = new entPago();
            tipoCargo = new entTipoCargo();
        }
    }
}
