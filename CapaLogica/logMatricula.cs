using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMatricula
    {
        #region singleton
        private static readonly logMatricula _instancia = new logMatricula();
        public static logMatricula Instancia
        {
            get
            {
                return logMatricula._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entMatricula> ListarMatricula()
        {
            return datMatricula.Instancia.ListarMatricula();
        }

        public void InsertarMatricula(entMatricula M)
        {
            datMatricula.Instancia.InsertarMatricula(M);
        }

        public void deshabilitarMatricula(entMatricula M)
        {
            datMatricula.Instancia.DeshabilitarMatricula(M);
        }
        #endregion metodos

    }
}
