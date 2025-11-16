using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logApoderado
    {
        #region singleton

        private static readonly logApoderado _instancia = new logApoderado();

        public static logApoderado Instancia
        {
            get
            {
                return logApoderado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///Listado de Apoderados
        public List<entApoderado> ListarApoderados()
        {
            return datApoderado.Instancia.ListarApoderados();
        }

        ///Insertar Apoderado
        public void InsertarApoderado(entApoderado Apo)
        {
            datApoderado.Instancia.insertarApoderado(Apo);
        }
        ///Editar Apoderado
        public void EditarApoderado(entApoderado Apo)
        {
            datApoderado.Instancia.editarApoderado(Apo);
        }

        ///Deshabilitar Apoderado
        public void DeshabilitarApoderado(entApoderado Apo)
        {
            datApoderado.Instancia.deshabilitarApoderado(Apo);
        }

        public entApoderado BuscarApoderadoPorDni(string dni)
        {
            return datApoderado.Instancia.buscarApoderadoPorDni(dni);
        }
        #endregion metodos

    }
}
