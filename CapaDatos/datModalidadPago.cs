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
    public class datModalidadPago
    {
        #region singleton
        private static readonly datModalidadPago _instancia = new datModalidadPago();
        public static datModalidadPago Instancia
        {
            get
            {
                return datModalidadPago._instancia;
            }
        }
        #endregion singleton


        #region metodos

        public List<entModalidadPago> listarModalidadPago()
        {
            SqlCommand cmd = null;
            List<entModalidadPago> lista = new List<entModalidadPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarModalidadPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entModalidadPago Mp = new entModalidadPago();
                    Mp.idModalidadPago = Convert.ToInt32(dr["idModalidadPago"]);
                    Mp.TipoModalidadPago = dr["tipoModalidadPago"].ToString();
                    Mp.EstadoModalidadPago = Convert.ToBoolean(dr["estadoModalidadPago"]);
                    lista.Add(Mp);
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


        public Boolean InsertarModalidadPago(entModalidadPago Mp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarModalidadPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoModalidadPago", Mp.TipoModalidadPago);
                cmd.Parameters.AddWithValue("@estadoModalidadPago", Mp.EstadoModalidadPago);
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

        public Boolean EditarModalidadPago(entModalidadPago Mp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarModalidadPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idModalidadPago", Mp.idModalidadPago);
                cmd.Parameters.AddWithValue("@tipoModalidadPago", Mp.TipoModalidadPago);
                cmd.Parameters.AddWithValue("@estadoModalidadPago", Mp.EstadoModalidadPago);
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

        public Boolean DeshabilitarModalidadPago(entModalidadPago Mp)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarModalidadPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idModalidadPago", Mp.idModalidadPago);
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

