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
    public class datInscripcion
    {
        #region singleton
        private static readonly datInscripcion _instancia = new datInscripcion();

        public static datInscripcion Instancia
        {
            get
            {
                return datInscripcion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entInscripcion> ListarInscripcion()
        {
            SqlCommand cmd = null;
            List<entInscripcion> lista = new List<entInscripcion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarInscripcion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInscripcion Ins = new entInscripcion();
                    Ins.IdInscripcion = Convert.ToInt32(dr["idInscripcion"]);
                    Ins.IdEstudiante = Convert.ToInt32(dr["idEstudiante"]);
                    Ins.FechaInscripcion = Convert.ToDateTime(dr["fechaInscripcion"]);
                    Ins.EstadoInscripcion = Convert.ToBoolean(dr["estadoInscripcion"]);
                    lista.Add(Ins);
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

        public Boolean InsertarInscripcion(entInscripcion Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInscripcion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstudiante", Ins.IdEstudiante);
                cmd.Parameters.AddWithValue("@fechaInscripcion", Ins.FechaInscripcion);
                cmd.Parameters.AddWithValue("@estadoInscripcion", Ins.EstadoInscripcion);
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

        public Boolean DeshabilitarInscripcion(entInscripcion Ins)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarInscripcion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInscripcion", Ins);
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
