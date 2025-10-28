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
                    Apo.IdApoderado = Convert.ToInt32(dr["IdApoderado"]);
                    Apo.DniApo = dr["DniApo"].ToString();
                    Apo.NombreApo = dr["NombreApo"].ToString();
                    Apo.ApellidosApo = dr["ApellidosApo"].ToString();
                    Apo.NumCelularApo = dr["NumCelularApo"].ToString();
                    Apo.DireccionApo= dr["DireccionApo"].ToString();
                    Apo.EstadoApot = Convert.ToBoolean(dr["EstadoApot"]);
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

        #endregion metodo

    }
}
