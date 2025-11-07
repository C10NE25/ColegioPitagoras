using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCurso
    {
        #region singleton
        private static readonly logCurso _instancia = new logCurso();

        public static logCurso Instancia
        {
            get
            {
                return logCurso._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entCurso> ListarCurso()
        {
            return datCurso.Instancia.ListarCurso();
        }

        public void InsertarCurso(entCurso C)
        {
            datCurso.Instancia.InsertarCurso(C);
        }

        public void EditarCurso(entCurso C)
        {
            datCurso.Instancia.EditarCurso(C);
        }
        public void DeshabilitarCurso(entCurso C)
        {
            datCurso.Instancia.DeshabilitarCurso(C);
        }
        #endregion metodos
    }
}
