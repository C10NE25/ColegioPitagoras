using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logModalidadPago
    {
        #region singleton

        private static readonly logModalidadPago _instancia = new logModalidadPago();

        public static logModalidadPago Instancia
        {
            get
            {
                return logModalidadPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entModalidadPago> ListarModalidadPago()
        {
            return datModalidadPago.Instancia.listarModalidadPago();
        }

        public void insertarModalidadPago(entModalidadPago Mp)
        {
            datModalidadPago.Instancia.InsertarModalidadPago(Mp);
        }

        public void editarModalidadPago(entModalidadPago Mp)
        {
            datModalidadPago.Instancia.EditarModalidadPago(Mp);
        }

        public void DeshabilitarModalidadPago(entModalidadPago Mp)
        {
            datModalidadPago.Instancia.DeshabilitarModalidadPago(Mp);
        }
        #endregion metodos
    }
}
