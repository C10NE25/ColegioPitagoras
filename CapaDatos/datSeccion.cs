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
    public class datSeccion
    {
        #region singleton
        private static readonly datSeccion _instancia = new datSeccion();
        public static datSeccion Instancia
        {
            get
            {
                return datSeccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        
        public List<entSeccion> listarSeccion()
        {
            SqlCommand cmd = null;
            List<entSeccion> lista = new List<entSeccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarSeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSeccion Sec = new entSeccion();
                    Sec.IdSeccion = Convert.ToInt32(dr["idSeccion"]);
                    Sec.NombreSeccion = dr["nombreSeccion"].ToString();
                    Sec.EstadoSeccion = Convert.ToBoolean(dr["estadoSeccion"]);
                    lista.Add(Sec);
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


        public Boolean InsertarSeccion(entSeccion Sec)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarSeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreSeccion", Sec.NombreSeccion);
                cmd.Parameters.AddWithValue("@estadoSeccion", Sec.EstadoSeccion);
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

        public Boolean EditarSeccion(entSeccion Sec)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarSeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSeccion", Sec.IdSeccion);
                cmd.Parameters.AddWithValue("@nombreSeccion", Sec.NombreSeccion);
                cmd.Parameters.AddWithValue("@estadoSeccion", Sec.EstadoSeccion);
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

        public Boolean DeshabilitarNivelAcademico(entSeccion Sec)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarSeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSeccion", Sec.IdSeccion);
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
