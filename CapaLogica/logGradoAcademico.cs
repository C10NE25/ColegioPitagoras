using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logGradoAcademico
    {
        #region singleton
        private static readonly logGradoAcademico _instancia = new logGradoAcademico();
        public static logGradoAcademico Instancia
        {
            get
            {
                return logGradoAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entGradoAcademico> ListarGradoAcademico()
        {
            return datGradoAcademico.Instancia.ListarGradoAcademico();
        }

        public void InsertarGradoAcademico(entGradoAcademico Ga)
        {
            datGradoAcademico.Instancia.InsertarGradoAcademico(Ga);
        }

        public void EditarGradoAcademico(entGradoAcademico Ga)
        {
            datGradoAcademico.Instancia.EditarGradoAcademico(Ga);
        }

        public void DeshabilitarGradoAcademico(entGradoAcademico Ga)
        {
            datGradoAcademico.Instancia.DeshabilitarGradoAcademico(Ga);
        }

        #endregion metodos
    }
}
