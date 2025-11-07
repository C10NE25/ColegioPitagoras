using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoCargo
    {
        #region singleton

        private static readonly logTipoCargo _instancia = new logTipoCargo();

        public static logTipoCargo Instancia
        {
            get
            {
                return logTipoCargo._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTipoCargo> ListarTipoCargo()
        {
            return datTipoCargo.Instancia.listarTipoCargo();
        }

        public void InsertarTipoCargo(entTipoCargo TC)
        {
            datTipoCargo.Instancia.InsertarTipoCargo(TC);
        }

        public void EditarTipoCargo(entTipoCargo TC)
        {
            datTipoCargo.Instancia.EditarTipoCargo(TC);
        }
        public void DeshabilitarTipoCargo(entTipoCargo TC)
        {
            datTipoCargo.Instancia.deshabilitarTipoCargo(TC);
        }
        #endregion

    }
}
