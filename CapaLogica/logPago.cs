using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPago
    {
        #region singleton
        private static readonly logPago _instancia = new logPago();
        public static logPago Instancia
        {
            get
            {
                return logPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entPago> ListarPago()
        {
            return datPago.Instancia.ListarPago();
        }

        public void InsertarPago(entPago P)
        {
            datPago.Instancia.InsertarPago(P);
        }

        public void DeshabilitarPago(entPago P)
        {
            datPago.Instancia.DeshabilitarPago(P);
        }  
        #endregion metodos
    }
}
