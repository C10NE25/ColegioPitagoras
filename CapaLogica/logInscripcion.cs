using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInscripcion
    {
        #region singleton
        private static readonly logInscripcion _instancia = new logInscripcion();
        public static logInscripcion Instancia
        {
            get
            {
                return logInscripcion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entInscripcion> ListarInscripcion()
        {
            return datInscripcion.Instancia.ListarInscripcion();
        }

        public void InsertarInscripcion(entInscripcion I)
        {
            datInscripcion.Instancia.InsertarInscripcion(I);
        }

        public void DeshabilitarInscripcion(entInscripcion I)
        {
            datInscripcion.Instancia.DeshabilitarInscripcion(I);
        }
        #endregion metodos
    }
}
