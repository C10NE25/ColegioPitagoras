using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEstudiante
    {
        #region singleton
        private static readonly logEstudiante _instancia = new logEstudiante();
        public static logEstudiante Instancia
        {
            get
            {
                return logEstudiante._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///Listado de Estudiantes
        public List<entEstudiante> ListarEstudiantes()
        {
            return datEstudiante.Instancia.ListarEstudiantes();
        }

        public void InsertarEstudiante(entEstudiante Est)
        {
            datEstudiante.Instancia.InsertarEstudiante(Est);
        }

        public void EditarEstudiante(entEstudiante Est)
        {
            datEstudiante.Instancia.EditarEstudiante(Est);
        }

        public void DeshabilitarEstudiante(entEstudiante Est)
        {
            datEstudiante.Instancia.DeshabilitarEstudiante(Est);
        }
        
        public entEstudiante BuscarEstudiantePorDni(string dniEst)
        {
            return datEstudiante.Instancia.buscarEstudiantePorDni(dniEst);
        }
        #endregion metodos
    }
}
