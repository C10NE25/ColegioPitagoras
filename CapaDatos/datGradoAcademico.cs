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
    public class datGradoAcademico
    {
        #region singleton
        private static readonly datGradoAcademico _instancia = new datGradoAcademico();

        public static datGradoAcademico Instancia
        {
            get
            {
                return datGradoAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entGradoAcademico> ListarGradoAcademico()
        {
            SqlCommand cmd = null;
            List<entGradoAcademico> lista = new List<entGradoAcademico>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarGradoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entGradoAcademico Ga = new entGradoAcademico();
                    Ga.IdGradoAcademico = Convert.ToInt32(dr["idGradoAcademico"]);
                    Ga.NombreGradoAcademico = dr["nombreGradoAcademico"].ToString();
                    Ga.IdNivelAcademico = Convert.ToInt32(dr["idNivelAcademico"]);
                    Ga.IdSeccion = Convert.ToInt32(dr["idSeccion"]);
                    Ga.EstadoGradoAcademico= Convert.ToBoolean(dr["estadoGradoAcademico"]);
                    lista.Add(Ga);
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

        public Boolean InsertarGradoAcademico(entGradoAcademico Ga)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarGradoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreGradoAcademico", Ga.NombreGradoAcademico);
                cmd.Parameters.AddWithValue("@idNivelAcademico", Ga.IdNivelAcademico);
                cmd.Parameters.AddWithValue("@idSeccion", Ga.IdSeccion);
                cmd.Parameters.AddWithValue("@estadoGradoAcademico", Ga.EstadoGradoAcademico);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
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
            return inserta;
        }

        public Boolean EditarGradoAcademico(entGradoAcademico Ga)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarGradoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGradoAcademico", Ga.IdGradoAcademico);
                cmd.Parameters.AddWithValue("@nombreGradoAcademico", Ga.NombreGradoAcademico);
                cmd.Parameters.AddWithValue("@idNivelAcademico", Ga.IdNivelAcademico);
                cmd.Parameters.AddWithValue("@idSeccion", Ga.IdSeccion);
                cmd.Parameters.AddWithValue("@estadoGradoAcademico", Ga.EstadoGradoAcademico);
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

        public Boolean DeshabilitarGradoAcademico(entGradoAcademico Ga)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarGradoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGradoAcademico", Ga.IdGradoAcademico);
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
