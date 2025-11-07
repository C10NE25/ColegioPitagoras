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
    public class datTipoEvaluacion
    {
        #region singleton
        private static readonly datTipoEvaluacion _instancia = new datTipoEvaluacion();
        public static datTipoEvaluacion Instancia
        {
            get
            {
                return datTipoEvaluacion._instancia;
            }
        }
        #endregion singleton
        // Métodos relacionados con TipoEvaluacion se agregarían aquí
        #region metodos
        public List<entTipoEvaluacion> ListarTipoEvaluacion()
        {
            SqlCommand cmd = null;
            List<entTipoEvaluacion> lista = new List<entTipoEvaluacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEvaluacion TE = new entTipoEvaluacion();
                    TE.IdTipoEvaluacion = Convert.ToInt32(dr["idTipoEvaluacion"]);
                    TE.NomTipoNota = dr["nomTipoNota"].ToString();
                    TE.EstadoTipoEvaluacion = Convert.ToBoolean(dr["estadoTipoEvaluacion"]);
                    lista.Add(TE);
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

        public Boolean InsertarTipoEvaluacion(entTipoEvaluacion TE)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomTipoNota", TE.NomTipoNota);
                cmd.Parameters.AddWithValue("@estadoTipoEvaluacion", TE.EstadoTipoEvaluacion);
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

        public Boolean EditarTipoEvaluacion(entTipoEvaluacion TE)
        {
            SqlCommand cmd = null;
            Boolean edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoEvaluacion", TE.IdTipoEvaluacion);
                cmd.Parameters.AddWithValue("@nomTipoNota", TE.NomTipoNota);
                cmd.Parameters.AddWithValue("@estadoTipoEvaluacion", TE.EstadoTipoEvaluacion);
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

        public Boolean DeshabilitarTipoEvaluacion(entTipoEvaluacion TE)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoEvaluacion", TE.IdTipoEvaluacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilito = true;
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
            return deshabilito;
        }
        #endregion metodos
    }
}
