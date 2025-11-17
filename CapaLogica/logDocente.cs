using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDocente
    {
        #region singleton
        private static readonly logDocente _instancia = new logDocente();
        public static logDocente Instancia
        {
            get
            {
                return logDocente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///Listado de Docentes
        public List<entDocente> listarDocentes()
        {
            return datDocente.Instancia.listarDocentes();
        }

        ///Insertar Docente
        public void insertarDocente(entDocente Doc)
        {
            datDocente.Instancia.InsertarDocente(Doc);
        }

        ///editar Docente
        public void editarDocente(entDocente Doc)
        {
            datDocente.Instancia.EditarDocente(Doc);
        }

        ///deshabilitar Docente
        public void deshabilitarDocente(entDocente Doc)
        {
            datDocente.Instancia.DeshabilitarDocente(Doc);
        }

        public entDocente searchDocente(string dni)
        {
            return datDocente.Instancia.buscarDocenteDni(dni);
        }
        #endregion metodos
    }
}
