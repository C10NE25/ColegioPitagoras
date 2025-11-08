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
    public class datNotas
    {
        #region singleton
        private static readonly datNotas _instancia = new datNotas();
        public static datNotas Instancia
        {
            get
            {
                return datNotas._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entNotas> ListarNotas()
        {
            SqlCommand cmd = null;
            List<entNotas> lista = new List<entNotas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarNotas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotas Nt = new entNotas();
                    Nt.IdNota = Convert.ToInt32(dr["idNota"]);
                    Nt.IdEstudiante = Convert.ToInt32(dr["idEstudiante"]);
                    Nt.IdTipoEvaluacion = Convert.ToInt32(dr["idTipoEvaluacion"]);
                    Nt.NumNota = Convert.ToDecimal(dr["numNota"]);
                    Nt.FechaNota = Convert.ToDateTime(dr["fechaNota"]);
                    Nt.EstadoNota = Convert.ToBoolean(dr["estadoNota"]);
                    lista.Add(Nt);
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

        public Boolean InsertarNotas(entNotas Nt)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", Nt.IdEstudiante);
                cmd.Parameters.AddWithValue("@idTipoEvaluacion", Nt.IdTipoEvaluacion);
                cmd.Parameters.AddWithValue("@numNota", Nt.NumNota);
                cmd.Parameters.AddWithValue("@fechaNota", Nt.FechaNota);
                cmd.Parameters.AddWithValue("@estadoNota", Nt.EstadoNota);
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

        public Boolean DeshabilitarNotas(entNotas Nt)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarNotas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNota", Nt.IdNota);
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
