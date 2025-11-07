using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datTipoCargo
    {
        #region singleton
        private static readonly datTipoCargo _instancia = new datTipoCargo();
        public static datTipoCargo Instancia
        {
            get
            {
                return datTipoCargo._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entTipoCargo> listarTipoCargo()
        {
            SqlCommand cmd = null;
            List<entTipoCargo> lista = new List<entTipoCargo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoCargo Tc = new entTipoCargo();
                    Tc.IdTipoCargo = Convert.ToInt32(dr["idTipoCargo"]);
                    Tc.NombreTipoCargo = dr["nombreTipoCargo"].ToString();
                    Tc.IdTarifa = Convert.ToInt32(dr["idTarifa"]);
                    Tc.EstadoTipoCargo = Convert.ToBoolean(dr["estadoTipoCargo"]);
                    lista.Add(Tc);
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

        public Boolean InsertarTipoCargo(entTipoCargo Tc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreTipoCargo", Tc.NombreTipoCargo);
                cmd.Parameters.AddWithValue("@idTarifa", Tc.IdTarifa);
                cmd.Parameters.AddWithValue("@estadoTipoCargo", Tc.EstadoTipoCargo);
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

        public Boolean EditarTipoCargo(entTipoCargo Tc)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoCargo", Tc.IdTipoCargo);
                cmd.Parameters.AddWithValue("@nombreTipoCargo", Tc.NombreTipoCargo);
                cmd.Parameters.AddWithValue("@idTarifa", Tc.IdTarifa);
                cmd.Parameters.AddWithValue("@estadoTipoCargo", Tc.EstadoTipoCargo);
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

        public Boolean deshabilitarTipoCargo(entTipoCargo Tc)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoCargo", Tc.IdTipoCargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
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
            return deshabilitar;
        }
        #endregion metodos
    }
}
