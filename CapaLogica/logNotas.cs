using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNotas
    {
        #region singleton
        private static readonly logNotas _instancia = new logNotas();
        public static logNotas Instancia
        {
            get
            {
                return logNotas._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entNotas> ListarNotas()
        {
            return datNotas.Instancia.ListarNotas();
        }
        public void InsertarNotas(entNotas N)
        {
            datNotas.Instancia.InsertarNotas(N);
        }

        public void DeshabilitarNotas(entNotas N)
        {
            datNotas.Instancia.DeshabilitarNotas(N);
        }



        #endregion metodos
    }
}
