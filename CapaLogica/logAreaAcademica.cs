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
    public class logAreaAcademica
    {
        #region singleton

        private static readonly logAreaAcademica _instancia = new logAreaAcademica();

        public static logAreaAcademica Instancia
        {
            get
            {
                return logAreaAcademica._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entAreaAcademica> ListarAsignatura()
        {
            return datAreaAcademica.Instancia.listarAsignatura();
        }

        public void insertarAsignatura(entAreaAcademica Asig)
        {
            datAreaAcademica.Instancia.InsertarAsignatura(Asig);
        }

        public void editarAsignatura(entAreaAcademica Asig)
        {
            datAreaAcademica.Instancia.EditarAsignatura(Asig);
        }

        public void DeshabilitarAsignatura(entAreaAcademica Asig)
        {
            datAreaAcademica.Instancia.DeshabilitarAsignatura(Asig);
        }
        #endregion metodos  
    }
}
