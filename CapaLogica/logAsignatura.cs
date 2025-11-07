using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CapaLogica
{
    public class logAsignatura
    {
        #region singleton

        private static readonly logAsignatura _instancia = new logAsignatura();

        public static logAsignatura Instancia
        {
            get
            {
                return logAsignatura._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entAsignatura> ListarAsignatura()
        {
            return datAsignatura.Instancia.listarAsignatura();
        }

        public void insertarAsignatura(entAsignatura Asig)
        {
            datAsignatura.Instancia.InsertarAsignatura(Asig);
        }

        public void editarAsignatura(entAsignatura Asig)
        {
            datAsignatura.Instancia.EditarAsignatura(Asig);
        }

        public void DeshabilitarAsignatura(entAsignatura Asig)
        {
            datAsignatura.Instancia.DeshabilitarAsignatura(Asig);
        }
        #endregion metodos  
    }
}
