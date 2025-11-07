using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            /*Data Source= Nombre de su servidor, 
            * Initial Catalog= Nombre de la base de datos*/
            cn.ConnectionString =
                "Data Source=C10N3\\USERDP; " +
                "Initial Catalog = ColegioPitagoras4;" +
                "Integrated Security=true";

            return cn;
        }
    }
}
