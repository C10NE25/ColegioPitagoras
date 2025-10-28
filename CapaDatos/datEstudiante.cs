using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEstudiante
    {
        #region singleton
        private static readonly datEstudiante _instancia = new datEstudiante();

        public static datEstudiante Instancia
        {
            get
            {
                return datEstudiante._instancia;
            }
        }

        #endregion singleton

        #region metodos
        ///Listar Estudiantes
        
        public List<entEstudiante> ListarEstudiantes()
        {
            SqlCommand cmd = null;
            List<entEstudiante> lista = new List<entEstudiante>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstudiante Est = new entEstudiante();
                    Est.IdEstudiante = Convert.ToInt32(dr["idEstudiante"]);
                    Est.DniEst = dr["dniEst"].ToString();
                    Est.NombreEst = dr["nombreEst"].ToString();
                    Est.ApellidosEst = dr["apellidosEst"].ToString();
                    Est.FechaNacEst = Convert.ToDateTime(dr["fechaNacEst"]);
                    Est.DireccionEst = dr["direccionEst"].ToString();
                    Est.IdApoderado = Convert.ToInt32(dr["idApoderado"]);
                    Est.EstadoEst = Convert.ToBoolean(dr["estadoEst"]);
                    lista.Add(Est);
                }                            
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        #endregion metodos
    }
}
