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
                SqlConnection cn = Conexion.Instancia.Conectar();
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
                    Est.ApellidosPatEst = dr["apellidosPatEst"].ToString();
                    Est.ApellidosMatEst = dr["apellidosMatEst"].ToString();
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

        ///Insertar Estudiante
        public Boolean InsertarEstudiante(entEstudiante Est)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniEst", Est.DniEst);
                cmd.Parameters.AddWithValue("@nombreEst", Est.NombreEst);
                cmd.Parameters.AddWithValue("@apellidoPatEst", Est.ApellidosPatEst);
                cmd.Parameters.AddWithValue("@apellidoMatEst", Est.ApellidosMatEst);
                cmd.Parameters.AddWithValue("@fechaNacEst", Est.FechaNacEst);
                cmd.Parameters.AddWithValue("@direccionEst", Est.DireccionEst);
                cmd.Parameters.AddWithValue("@idApoderado", Est.IdApoderado);
                cmd.Parameters.AddWithValue("@estadoEst", Est.EstadoEst);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
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
            return inserto;
        }

        ///Editar Estudiante
        public Boolean EditarEstudiante(entEstudiante Est)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", Est.IdEstudiante);
                cmd.Parameters.AddWithValue("@dniEst", Est.DniEst);
                cmd.Parameters.AddWithValue("@nombreEst", Est.NombreEst);
                cmd.Parameters.AddWithValue("@apellidoPatEst", Est.ApellidosPatEst);
                cmd.Parameters.AddWithValue("@apellidoMatEst", Est.ApellidosMatEst);
                cmd.Parameters.AddWithValue("@fechaNacEst", Est.FechaNacEst);
                cmd.Parameters.AddWithValue("@direccionEst", Est.DireccionEst);
                cmd.Parameters.AddWithValue("@idApoderado", Est.IdApoderado);
                cmd.Parameters.AddWithValue("@estadoEst", Est.EstadoEst);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }

        ///deshabilitar Estudiante
        public Boolean DeshabilitarEstudiante(entEstudiante Est)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", Est.IdEstudiante);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
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
            return deshabilita;
        }

        #endregion metodos
    }
}
