using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoEvaluacion
    {
        #region singleton
        private static readonly logTipoEvaluacion _instancia = new logTipoEvaluacion();
        public static logTipoEvaluacion Instancia
        {
            get
            {
                return logTipoEvaluacion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTipoEvaluacion> ListarTipoEvaluacion()
        {
            return datTipoEvaluacion.Instancia.ListarTipoEvaluacion();
        }

        public void InsertarTipoEvaluacion(entTipoEvaluacion TE)
        {
            datTipoEvaluacion.Instancia.InsertarTipoEvaluacion(TE);
        }

        public void EditarTipoEvaluacion(entTipoEvaluacion TE)
        {
            datTipoEvaluacion.Instancia.EditarTipoEvaluacion(TE);
        }

        public void deshabilitarTipoEvaluacion(entTipoEvaluacion TE)
        {
            datTipoEvaluacion.Instancia.DeshabilitarTipoEvaluacion(TE);
        }
        #endregion metodos
    }
}
