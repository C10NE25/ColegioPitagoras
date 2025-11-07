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
    public class datTarifa
    {
        #region singleton
        private static readonly datTarifa _instancia = new datTarifa();
        public static datTarifa Instancia
        {
            get
            {
                return datTarifa._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTarifa> listarTarifa()
        {
            SqlCommand cmd = null;
            List<entTarifa> lista = new List<entTarifa>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTarifa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTarifa Tar = new entTarifa();
                    Tar.IdTarifa = Convert.ToInt32(dr["idTarifa"]);
                    Tar.NombreTarifa = dr["nombreTarifa"].ToString();
                    Tar.MontoTarifa = Convert.ToDecimal(dr["montoTarifa"]);
                    Tar.IdPeriodoAcademico = Convert.ToInt32(dr["idPeriodoAcademico"]);
                    Tar.EstadoTarifa = Convert.ToBoolean(dr["estadoTarifa"]);
                    lista.Add(Tar);
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

        public Boolean InsertarTarifa(entTarifa Tar)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTarifa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreTarifa", Tar.NombreTarifa);
                cmd.Parameters.AddWithValue("@montoTarifa", Tar.MontoTarifa);
                cmd.Parameters.AddWithValue("@idPeriodoAcademico", Tar.IdPeriodoAcademico);
                cmd.Parameters.AddWithValue("@estadoTarifa", Tar.EstadoTarifa);
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

        public Boolean EditarTarifa(entTarifa Tar)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTarifa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarifa", Tar.IdTarifa);
                cmd.Parameters.AddWithValue("@nombreTarifa", Tar.NombreTarifa);
                cmd.Parameters.AddWithValue("@montoTarifa", Tar.MontoTarifa);
                cmd.Parameters.AddWithValue("@idPeriodoAcademico", Tar.IdPeriodoAcademico);
                cmd.Parameters.AddWithValue("@estadoTarifa", Tar.EstadoTarifa);
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

        public Boolean deshabilitarTarifa(entTarifa Tar)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTarifa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarifa", Tar.IdTarifa);
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
