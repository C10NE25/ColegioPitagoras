using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logParentesco
    {
        #region singleton

        private static readonly logParentesco _instancia = new logParentesco();

        public static logParentesco Instancia
        {
            get
            {
                return logParentesco._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entParentesco> ListarParentesco()
        {
            return datParentesco.Instancia.ListarParentesco();
        }

        public void InsertarParentesco(entParentesco par)
        {
            datParentesco.Instancia.InsertarParentesco(par);
        }
        public void EditarParentesco(entParentesco par)
        {
            datParentesco.Instancia.EditarParentesco(par);
        }

        public void DeshabilitarParentesco(entParentesco par)
        {
            datParentesco.Instancia.DeshabilitarParentesco(par);
        }
        #endregion metodos
    }
}
