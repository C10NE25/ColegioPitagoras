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
    public class datDocente
    {
        #region singleton
        private static readonly datDocente _instancia = new datDocente();
        public static datDocente Instancia
        {
            get
            {
                return datDocente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///Listado de Docentes
        public List<entDocente> listarDocentes()
        {
            SqlCommand cmd = null;
            List<entDocente> lista = new List<entDocente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDocente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDocente Doc= new entDocente();
                    Doc.IdDocente = Convert.ToInt32(dr["idDocente"]);
                    Doc.DniDoc = dr["dniDoc"].ToString();
                    Doc.NombreDoc = dr["nombreDoc"].ToString();
                    Doc.ApellidosDoc = dr["apellidosDoc"].ToString();
                    Doc.NumCelularDoc = dr["numCelularDoc"].ToString();
                    Doc.DireccionDoc= dr["direccionDoc"].ToString();
                    Doc.EstadoDoc = Convert.ToBoolean(dr["estadoDoc"]);
                    lista.Add(Doc);
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

        ///Insertar Docente
        public Boolean InsertarDocente(entDocente Doc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDocente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniDoc", Doc.DniDoc);
                cmd.Parameters.AddWithValue("@nombreDoc", Doc.NombreDoc);
                cmd.Parameters.AddWithValue("@apellidosDoc", Doc.ApellidosDoc);
                cmd.Parameters.AddWithValue("@numCelularDoc", Doc.NumCelularDoc);
                cmd.Parameters.AddWithValue("@direccionDoc", Doc.DireccionDoc);
                cmd.Parameters.AddWithValue("@estadoDoc", Doc.EstadoDoc);
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

        ///Editar Docente
        public Boolean EditarDocente(entDocente Doc)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarDocente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDocente", Doc.IdDocente);
                cmd.Parameters.AddWithValue("@dniDoc", Doc.DniDoc);
                cmd.Parameters.AddWithValue("@nombreDoc", Doc.NombreDoc);
                cmd.Parameters.AddWithValue("@apellidosDoc", Doc.ApellidosDoc);
                cmd.Parameters.AddWithValue("@numCelularDoc", Doc.NumCelularDoc);
                cmd.Parameters.AddWithValue("@direccionDoc", Doc.DireccionDoc);
                cmd.Parameters.AddWithValue("@estadoDoc", Doc.EstadoDoc);
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

        ///deshabilitar Docente
        public Boolean DeshabilitarDocente(entDocente doc)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarDocente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDocente", doc.IdDocente);
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
