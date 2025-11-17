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
    public class datCurso
    {
        #region singleton
        private static readonly datCurso _instancia = new datCurso();

        public static datCurso Instancia
        {
            get
            {
                return datCurso._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entCurso> ListarCurso()
        {
            SqlCommand cmd = null;
            List<entCurso> lista = new List<entCurso>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCurso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCurso C = new entCurso();
                    C.IdCurso = Convert.ToInt32(dr["idCurso"]);
                    C.NombreCurso = dr["nombreCurso"].ToString();
                    C.IdDocente = Convert.ToInt32(dr["idDocente"]);
                    C.IdGradoAcademico = Convert.ToInt32(dr["idGradoAcademico"]);
                    C.IdAsignatura = Convert.ToInt32(dr["idAsignatura"]);
                    C.EstadoCurso = Convert.ToBoolean(dr["estadoCurso"]);
                    lista.Add(C);
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

        public Boolean InsertarCurso(entCurso C)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCurso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCurso", C.NombreCurso);
                cmd.Parameters.AddWithValue("@idDocente", C.IdDocente);
                cmd.Parameters.AddWithValue("@idGradoAcademico", C.IdGradoAcademico);
                cmd.Parameters.AddWithValue("@idAsignatura", C.IdAsignatura);
                cmd.Parameters.AddWithValue("@estadoCurso", C.EstadoCurso);
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

        public Boolean EditarCurso(entCurso C)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCurso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCurso", C.IdCurso);
                cmd.Parameters.AddWithValue("@nombreCurso", C.NombreCurso);
                cmd.Parameters.AddWithValue("@idDocente", C.IdDocente);
                cmd.Parameters.AddWithValue("@idGradoAcademico", C.IdGradoAcademico);
                cmd.Parameters.AddWithValue("@idAsignatura", C.IdAsignatura);
                cmd.Parameters.AddWithValue("@estadoCurso", C.EstadoCurso);
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

        public Boolean DeshabilitarCurso(entCurso C)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCurso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCurso", C.IdCurso);
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
