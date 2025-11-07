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
    public class datPago
    {
        #region singleton
        private static readonly datPago _instancia = new datPago();

        public static datPago Instancia
        {
            get
            {
                return datPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entPago> ListarPago()
        {
            SqlCommand cmd = null;
            List<entPago> lista = new List<entPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPago P = new entPago();
                    P.IdPago = Convert.ToInt32(dr["idPago"]);
                    P.IdEstudiante = Convert.ToInt32(dr["idEstudiante"]);
                    P.FechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    P.IdModalidadPago = Convert.ToInt32(dr["idModalidadPago"]);
                    P.EstadoPago = Convert.ToBoolean(dr["estadoPago"]);
                    lista.Add(P);
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

        public Boolean InsertarPago(entPago P)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", P.IdEstudiante);
                cmd.Parameters.AddWithValue("@fechaPago", P.FechaPago);
                cmd.Parameters.AddWithValue("@idModalidadPago", P.IdModalidadPago);
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

        public Boolean DeshabilitarPago(entPago P)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", P.IdPago);
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
