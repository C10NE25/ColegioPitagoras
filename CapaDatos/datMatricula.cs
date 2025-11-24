using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datMatricula
    {
        #region singleton
        private static readonly datMatricula _instancia = new datMatricula();

        public static datMatricula Instancia
        {
            get
            {
                return datMatricula._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entMatricula> ListarMatricula()
        {
            SqlCommand cmd = null;
            List<entMatricula> lista = new List<entMatricula>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMatricula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMatricula Mat = new entMatricula();
                    Mat.IdMatricula = Convert.ToInt32(dr["idMatricula"]);
                    Mat.inscripcion.IdInscripcion = Convert.ToInt32(dr["idInscripcion"]);
                    Mat.gradoAcademico.IdGradoAcademico = Convert.ToInt32(dr["idGradoAcademico"]);
                    Mat.FechaMatricula = Convert.ToDateTime(dr["fechaMatricula"]);
                    Mat.EstadoMatricula = Convert.ToBoolean(dr["estadoMatricula"]);
                    lista.Add(Mat);
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

        public Boolean InsertarMatricula(entMatricula Mat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMatricula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInscripcion", Mat.inscripcion.IdInscripcion);
                cmd.Parameters.AddWithValue("@idGradoAcademico", Mat.inscripcion.IdInscripcion);
                cmd.Parameters.AddWithValue("@fechaMatricula", Mat.FechaMatricula);
                cmd.Parameters.AddWithValue("@estadoMatricula", Mat.EstadoMatricula);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                inserta = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }
            return inserta;
        }

        public Boolean DeshabilitarMatricula(entMatricula Mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMatricula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMatricula", Mat.IdMatricula);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                deshabilita = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }
            return deshabilita;
        }
        #endregion metodos
    }
}
