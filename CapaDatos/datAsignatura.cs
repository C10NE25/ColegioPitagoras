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
    public class datAsignatura
    {
        #region singleton
        private static readonly datAsignatura _instancia = new datAsignatura();
        public static datAsignatura Instancia
        {
            get
            {
                return datAsignatura._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entAsignatura> listarAsignatura()
        {
            SqlCommand cmd = null;
            List<entAsignatura> lista = new List<entAsignatura>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarAsignatura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAsignatura Asig = new entAsignatura();
                    Asig.IdAsignatura = Convert.ToInt32(dr["idAsignatura"]);
                    Asig.NombreAsignatura = dr["nombreAsignatura"].ToString();
                    Asig.EstadoAsignatura = Convert.ToBoolean(dr["estadoAsignatura"]);
                    lista.Add(Asig);
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


        public Boolean InsertarAsignatura(entAsignatura Asig)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAsignatura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreAsignatura", Asig.NombreAsignatura);
                cmd.Parameters.AddWithValue("@estadoAsignatura", Asig.EstadoAsignatura);
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

        public Boolean EditarAsignatura(entAsignatura Asig)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarAsignatura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsignatura", Asig.IdAsignatura);
                cmd.Parameters.AddWithValue("@nombreAsignatura", Asig.NombreAsignatura);
                cmd.Parameters.AddWithValue("@estadoAsignatura", Asig.EstadoAsignatura);
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

        public Boolean DeshabilitarAsignatura(entAsignatura Asig)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarAsignatura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsignatura", Asig.IdAsignatura);
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
