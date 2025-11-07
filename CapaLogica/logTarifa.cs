using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTarifa
    {
        #region singleton

        private static readonly logTarifa _instancia = new logTarifa();

        public static logTarifa Instancia
        {
            get
            {
                return logTarifa._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTarifa> ListarTarifa()
        {
            return datTarifa.Instancia.listarTarifa();
        }

        public void InsertarTarifa(entTarifa Tar)
        {
            datTarifa.Instancia.InsertarTarifa(Tar);
        }

        public void editarTarifa(entTarifa Tar)
        {
            datTarifa.Instancia.EditarTarifa(Tar);
        }

        public void DeshabilitarTarifa(entTarifa Tar)
        {
            datTarifa.Instancia.deshabilitarTarifa(Tar);
        }
        #endregion metodos
    }
}
