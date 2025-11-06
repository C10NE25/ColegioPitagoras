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
    public class datNivelAcademico
    {
        #region singleton
        private static readonly datNivelAcademico _instancia = new datNivelAcademico();
        public static datNivelAcademico Instancia
        {
            get
            {
                return datNivelAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entNivelAcademico> listarNivelAcademico()
        {
            SqlCommand cmd = null;
            List<entNivelAcademico> lista = new List<entNivelAcademico>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarNivelAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNivelAcademico Na = new entNivelAcademico();
                    Na.IdNivelAcademico = Convert.ToInt32(dr["idNivelAcademico"]);
                    Na.NombreNivelAcademico = dr["nombreNivelAcademico"].ToString();
                    Na.EstadoNivelAcademico = Convert.ToBoolean(dr["estadoNivelAcademico"]);
                    lista.Add(Na);
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


        public Boolean InsertarNivelAcademico(entNivelAcademico Na)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNivelAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreNivelAcademico", Na.NombreNivelAcademico);
                cmd.Parameters.AddWithValue("@estadoNivelAcademico", Na.EstadoNivelAcademico);
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

        public Boolean EditarNivelAcademico(entNivelAcademico Na)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarNivelAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNivelAcademico", Na.IdNivelAcademico);
                cmd.Parameters.AddWithValue("@nombreNivelAcademico", Na.NombreNivelAcademico);
                cmd.Parameters.AddWithValue("@estadoNivelAcademico", Na.EstadoNivelAcademico);
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

        public Boolean DeshabilitarNivelAcademico(entNivelAcademico Na)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarNivelAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNivelAcademico", Na.IdNivelAcademico);
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
