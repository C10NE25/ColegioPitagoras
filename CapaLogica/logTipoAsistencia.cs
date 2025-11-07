using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoAsistencia
    {
        #region singleton
        private static readonly logTipoAsistencia _instancia = new logTipoAsistencia();

        public static logTipoAsistencia Instancia
        {
            get
            {
                return logTipoAsistencia._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTipoAsistencia> ListarTipoAsistencia()
        {
            return datTipoAsistencia.Instancia.ListarTipoAsistencia();
        }

        public void InsertarTipoAsistencia(entTipoAsistencia TA)
        {
            datTipoAsistencia.Instancia.insertarTipoAsistencia(TA);
        }

        public void EditarTipoAsistencia(entTipoAsistencia TA)
        {
            datTipoAsistencia.Instancia.editarTipoAsistencia(TA);
        }

        public void DeshabilitarTipoAsistencia(entTipoAsistencia TA)
        {
            datTipoAsistencia.Instancia.deshabilitarTipoAsistencia(TA);
        }
        #endregion metodos
    }
}
