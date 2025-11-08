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
    public class datTipoAsistencia
    {
        #region singleton
        private static readonly datTipoAsistencia _instancia = new datTipoAsistencia();
        public static datTipoAsistencia Instancia
        {
            get
            {
                return datTipoAsistencia._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTipoAsistencia> ListarTipoAsistencia()
        {
            SqlCommand cmd = null;
            List<entTipoAsistencia> lista = new List<entTipoAsistencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListartipoAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoAsistencia Tas = new entTipoAsistencia();
                    Tas.IdTipoAsistencia = Convert.ToInt32(dr["idTipoAsistencia"]);
                    Tas.TipoAsistencia = dr["tipoAsistencia"].ToString();
                    Tas.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Tas);
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

        public Boolean insertarTipoAsistencia(entTipoAsistencia Tas)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoAsistencia", Tas.TipoAsistencia);
                cmd.Parameters.AddWithValue("@estado", Tas.estado);
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

        public Boolean editarTipoAsistencia(entTipoAsistencia Tas)
        {
            SqlCommand cmd = null;
            Boolean edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoAsistencia", Tas.IdTipoAsistencia);
                cmd.Parameters.AddWithValue("@tipoAsistencia", Tas.TipoAsistencia);
                cmd.Parameters.AddWithValue("@estado", Tas.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edito = true;
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
            return edito;
        }

        public void deshabilitarTipoAsistencia(entTipoAsistencia P)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoAsistencia", P.IdTipoAsistencia);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }




        #endregion metodos
    }
}
