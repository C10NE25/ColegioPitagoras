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
    public class datParentesco
    {
        #region singleton

        private static readonly datParentesco _instancia = new datParentesco();

        public static datParentesco Instancia
        {
            get
            {
                return datParentesco._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///Listado de Apoderados
        // Listar Parentescos
        public List<entParentesco> ListarParentesco()
        {
            SqlCommand cmd = null;
            List<entParentesco> lista = new List<entParentesco>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarParentesco", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entParentesco par = new entParentesco();
                    par.IdParentesco = Convert.ToInt32(dr["idParentesco"]);
                    par.TipoParentesco = dr["tipoParentesco"].ToString();
                    par.EstadoParentesco = Convert.ToBoolean(dr["estadoParentesco"]);

                    lista.Add(par);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }

            return lista;
        }

        // Insertar Parentesco
        public bool InsertarParentesco(entParentesco par)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarParentesco", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tipoParentesco", par.TipoParentesco);
                cmd.Parameters.AddWithValue("@estadoParentesco", par.EstadoParentesco);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                inserta = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }

            return inserta;
        }

        // Editar Parentesco
        public bool EditarParentesco(entParentesco par)
        {
            SqlCommand cmd = null;
            bool edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarParentesco", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idParentesco", par.IdParentesco);
                cmd.Parameters.AddWithValue("@tipoParentesco", par.TipoParentesco);
                cmd.Parameters.AddWithValue("@estadoParentesco", par.EstadoParentesco);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                edita = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }

            return edita;
        }

        // Deshabilitar Parentesco
        public bool DeshabilitarParentesco(entParentesco par)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarParentesco", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idParentesco", par.IdParentesco);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                deshabilita = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }

            return deshabilita;
        }

        #endregion metodo
    }
}
