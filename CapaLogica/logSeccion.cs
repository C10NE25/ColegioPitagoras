using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logSeccion
    {
        #region singleton

        private static readonly logSeccion _instancia = new logSeccion();

        public static logSeccion Instancia
        {
            get
            {
                return logSeccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entSeccion> ListarSeccion()
        {
            return datSeccion.Instancia.listarSeccion();
        }

        public void InsertarSeccion(entSeccion Sec)
        {
            datSeccion.Instancia.InsertarSeccion(Sec);
        }

        public void editarSeccion(entSeccion Sec)
        {
            datSeccion.Instancia.EditarSeccion(Sec);
        }

        public void DeshabilitarSeccion(entSeccion Sec)
        {
            datSeccion.Instancia.DeshabilitarSeccion(Sec);
        }
        #endregion metodos
    }
}
