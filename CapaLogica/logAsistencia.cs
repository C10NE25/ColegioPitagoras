using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logAsistencia
    {
        #region singleton
        private static readonly logAsistencia _instancia = new logAsistencia();
        public static logAsistencia Instancia
        {
            get
            {
                return logAsistencia._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAsistencia> ListarAsistencia()
        {
            return datAsistencia.Instancia.ListarAsistencia();
        }

        public void InsertarAsistencia(entAsistencia A)
        {
            datAsistencia.Instancia.InsertarAsistencia(A);
        }

        public void DeshabilitarAsistencia(entAsistencia A)
        {
            datAsistencia.Instancia.DeshabilitarAsistencia(A);
        }
        #endregion metodos
    }
}
