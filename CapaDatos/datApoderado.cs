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
    public class datApoderado
    {
        #region singleton
        
        private static readonly datApoderado _instancia = new datApoderado();

        public static datApoderado Instancia
        {
            get
            {
                return datApoderado._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///Listado de Apoderados
        public List<entApoderado> ListarApoderados()
        {
            SqlCommand cmd = null;
            List<entApoderado> lista = new List<entApoderado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarApoderado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entApoderado Apo = new entApoderado();
                    Apo.IdApoderado = Convert.ToInt32(dr["idApoderado"]);
                    Apo.DniApo = dr["dniApo"].ToString();
                    Apo.NombreApo = dr["nombreApo"].ToString();
                    Apo.ApellidosPatApo = dr["apellidosPatApo"].ToString();
                    Apo.ApellidosMatApo = dr["apellidosMatApo"].ToString();
                    Apo.NumCelularApo = dr["numCelularApo"].ToString();
                    Apo.DireccionApo= dr["direccionApo"].ToString();
                    Apo.parentesco.IdParentesco = Convert.ToInt32(dr["idParentesco"]);
                    Apo.EstadoApo = Convert.ToBoolean(dr["estadoApo"]);
                    lista.Add(Apo);
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

        ///Insertar Apoderado
        public Boolean insertarApoderado(entApoderado apo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarApoderado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniApo", apo.DniApo);
                cmd.Parameters.AddWithValue("@nombreApo", apo.NombreApo);
                cmd.Parameters.AddWithValue("@apellidosPatApo", apo.ApellidosPatApo);
                cmd.Parameters.AddWithValue("@apellidosMatApo", apo.ApellidosMatApo);
                cmd.Parameters.AddWithValue("@numCelularApo", apo.NumCelularApo);
                cmd.Parameters.AddWithValue("@direccionApo", apo.DireccionApo);
                cmd.Parameters.AddWithValue("@idParentesco", apo.parentesco.IdParentesco);
                cmd.Parameters.AddWithValue("@estadoApo", apo.EstadoApo);
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

        ///Editar Apoderado
        public Boolean editarApoderado(entApoderado apo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarApoderado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idApoderado", apo.IdApoderado);
                cmd.Parameters.AddWithValue("@dniApo", apo.DniApo);
                cmd.Parameters.AddWithValue("@nombreApo", apo.NombreApo);
                cmd.Parameters.AddWithValue("@apellidosPatApo", apo.ApellidosPatApo);
                cmd.Parameters.AddWithValue("@apellidosMatApo", apo.ApellidosPatApo);
                cmd.Parameters.AddWithValue("@numCelularApo", apo.NumCelularApo);
                cmd.Parameters.AddWithValue("@direccionApo", apo.DireccionApo);
                cmd.Parameters.AddWithValue("@estadoApo", apo.EstadoApo);
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

        ///Deshabilitar Apoderado
        public Boolean deshabilitarApoderado(entApoderado apo)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarApoderado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idApoderado", apo.IdApoderado);
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
        //BuscarApoderadoPorDni
        public entApoderado buscarApoderadoPorDni(string dniApo)
        {
            SqlCommand cmd = null;
            entApoderado apo = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spViewBasicApoderado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniApo", dniApo);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    apo = new entApoderado()
                    {
                        IdApoderado = Convert.ToInt32(dr["idApoderado"]),
                        NombreApo = dr["nombreApo"].ToString(),
                        ApellidosPatApo = dr["apellidosPatApo"].ToString(),
                        ApellidosMatApo = dr["apellidosMatApo"].ToString(),
                        DniApo = dr["dniApo"].ToString()
                    };
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                    cmd.Connection.Close();
            }
            return apo;
        }
        #endregion metodo

    }
}
