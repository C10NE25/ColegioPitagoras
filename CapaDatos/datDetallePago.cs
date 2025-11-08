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
    public class datDetallePago
    {
        #region singleton
        private static readonly datDetallePago _instancia = new datDetallePago();
        public static datDetallePago Instancia
        {
            get
            {
                return datDetallePago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entDetallePago> ListarDetallePago()
        {
            SqlCommand cmd = null;
            List<entDetallePago> lista = new List<entDetallePago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDetallePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetallePago DP = new entDetallePago();
                    DP.IdDetallePago = Convert.ToInt32(dr["idDetallePago"]);
                    DP.IdPago = Convert.ToInt32(dr["idPago"]);
                    DP.IdTipoCargo = Convert.ToInt32(dr["idTipoCargo"]);
                    DP.MontoPagado = Convert.ToDecimal(dr["montoPagado"]);
                    DP.EstadoDetallePago = Convert.ToBoolean(dr["estadoDetallePago"]);
                    lista.Add(DP);
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

        public Boolean insertarDetallePago(entDetallePago DP)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetallePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", DP.IdPago);
                cmd.Parameters.AddWithValue("@idTipoCargo", DP.IdTipoCargo);
                cmd.Parameters.AddWithValue("@montoPagado", DP.MontoPagado);
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

        public Boolean editarDetallePago(entDetallePago DP)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarDetallePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetallePago", DP.IdDetallePago);
                cmd.Parameters.AddWithValue("@idPago", DP.IdPago);
                cmd.Parameters.AddWithValue("@idTipoCargo", DP.IdTipoCargo);
                cmd.Parameters.AddWithValue("@montoPagado", DP.MontoPagado);
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

        public Boolean deshabilitarDetallePago(entDetallePago P)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarDetallePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetallePago", P.IdDetallePago);
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
