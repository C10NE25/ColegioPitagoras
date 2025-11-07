using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetallePago
    {
        #region singleton
        private static readonly logDetallePago _instancia = new logDetallePago();
        public static logDetallePago Instancia
        {
            get
            {
                return logDetallePago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entDetallePago> ListarDetallePago()
        {
            return datDetallePago.Instancia.ListarDetallePago();
        }

        public void InsertarDetallePago(entDetallePago DP)
        {
            datDetallePago.Instancia.insertarDetallePago(DP);
        }

        public void EditarDetallePago(entDetallePago DP)
        {
            datDetallePago.Instancia.editarDetallePago(DP);
        }

        public void DeshabilitarDetallePago(entDetallePago DP)
        {
            datDetallePago.Instancia.deshabilitarDetallePago(DP);
        }
        #endregion metodos

    }
}
