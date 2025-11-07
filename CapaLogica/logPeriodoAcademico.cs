using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPeriodoAcademico
    {
        #region singleton

        private static readonly logPeriodoAcademico _instancia = new logPeriodoAcademico();

        public static logPeriodoAcademico Instancia
        {
            get
            {
                return logPeriodoAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entPeriodoAcademico> ListarPeriodoAcademico()
        {
            return datPeriodoAcademico.Instancia.listarPeriodoAcademico();
        }

        public void insertarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            datPeriodoAcademico.Instancia.InsertarPeriodoAcademico(Pa);
        }

        public void editarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            datPeriodoAcademico.Instancia.EditarPeriodoAcademico(Pa);
        }

        public void DeshabilitarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            datPeriodoAcademico.Instancia.DeshabilitarPeriodoAcademico(Pa);
        }
        #endregion metodos
    }
}
