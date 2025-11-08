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
    public class datAsistencia
    {
        #region singleton
        private static readonly datAsistencia _instancia = new datAsistencia();
        public static datAsistencia Instancia
        {
            get
            {
                return datAsistencia._instancia;
            }
        }
        #endregion singleton
        // Métodos relacionados con Asistencia se agregarían aquí
        #region metodos
        public List<entAsistencia> ListarAsistencia()
        {
            SqlCommand cmd = null;
            List<entAsistencia> lista = new List<entAsistencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAsistencia Asis = new entAsistencia();
                    Asis.IdAsistencia= Convert.ToInt32(dr["idAsistencia"]);
                    Asis.IdEstudiante = Convert.ToInt32(dr["idEstudiante"]);
                    Asis.Fecha = Convert.ToDateTime(dr["fecha"]);
                    Asis.IdTipoAsistencia = Convert.ToInt32(dr["idTipoAsistencia"]);
                    Asis.EstadoAsistencia = Convert.ToBoolean(dr["estadoAsistencia"]);
                    lista.Add(Asis);
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

        public Boolean InsertarAsistencia(entAsistencia Asis)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", Asis.IdEstudiante);
                cmd.Parameters.AddWithValue("@fecha", Asis.Fecha);
                cmd.Parameters.AddWithValue("@idTipoAsistencia", Asis.IdTipoAsistencia);
                cmd.Parameters.AddWithValue("@estadoAsistencia", Asis.EstadoAsistencia);
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

        public Boolean DeshabilitarAsistencia(entAsistencia P)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsistencia", P.IdAsistencia);
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
