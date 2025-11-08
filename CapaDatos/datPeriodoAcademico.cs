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
    public class datPeriodoAcademico
    {
        #region singleton
        private static readonly datPeriodoAcademico _instancia = new datPeriodoAcademico();
        public static datPeriodoAcademico Instancia
        {
            get
            {
                return datPeriodoAcademico._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entPeriodoAcademico> listarPeriodoAcademico()
        {
            SqlCommand cmd = null;
            List<entPeriodoAcademico> lista = new List<entPeriodoAcademico>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPeriodoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPeriodoAcademico Pa = new entPeriodoAcademico();
                    Pa.IdPeriodoAcademico = Convert.ToInt32(dr["idPeriodoAcademico"]);
                    Pa.anioPeriodoAcademico = Convert.ToInt32(dr["anioPeriodoAcademico"]);
                    Pa.NombrePeriodoAcademico = dr["nombrePeriodoAcademico"].ToString();
                    Pa.EstadoPeriodoAcademico = Convert.ToBoolean(dr["estadoPeriodoAcademico"]);
                    lista.Add(Pa);
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


        public Boolean InsertarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPeriodoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anioPeriodoAcademico", Pa.anioPeriodoAcademico);
                cmd.Parameters.AddWithValue("@nombrePeriodoAcademico", Pa.NombrePeriodoAcademico);
                cmd.Parameters.AddWithValue("@estadoPeriodoAcademico", Pa.EstadoPeriodoAcademico);
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

        public Boolean EditarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPeriodoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPeriodoAcademico", Pa.IdPeriodoAcademico);
                cmd.Parameters.AddWithValue("@anioPeriodoAcademico", Pa.anioPeriodoAcademico);
                cmd.Parameters.AddWithValue("@nombrePeriodoAcademico", Pa.NombrePeriodoAcademico);
                cmd.Parameters.AddWithValue("@estadoPeriodoAcademico", Pa.EstadoPeriodoAcademico);
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

        public Boolean DeshabilitarPeriodoAcademico(entPeriodoAcademico Pa)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPeriodoAcademico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPeriodoAcademico", Pa.IdPeriodoAcademico);
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
