using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNivelAcademico
    {
        #region singleton

        private static readonly logNivelAcademico _instancia = new logNivelAcademico();

        public static logNivelAcademico Instancia
        {
            get
            {
                return logNivelAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entNivelAcademico> ListarNivelAcademico()
        {
            return datNivelAcademico.Instancia.listarNivelAcademico();
        }

        public void InsertarNivelAcademico(entNivelAcademico Na)
        {
            datNivelAcademico.Instancia.InsertarNivelAcademico(Na);
        }

        public void EditarNivelAcademico(entNivelAcademico Na)
        {
            datNivelAcademico.Instancia.EditarNivelAcademico(Na);
        }

        public void DeshabilitarNivelAcademico(entNivelAcademico Na)
        {
            datNivelAcademico.Instancia.DeshabilitarNivelAcademico(Na);
        }
        #endregion metodos
    }
}
