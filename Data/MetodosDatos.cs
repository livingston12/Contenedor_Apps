using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Data
{
   public class MetodosDatos
    {
        public static SqlCommand CrearComando()
        {
            string Cadenaconexion = Conexion.cadenaConexion;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Cadenaconexion;
            SqlCommand comando = new SqlCommand();
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;

        }

        public static DataTable ejecutarComandoSelect(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                comando.Connection.Close();
            }
            return tabla;
        }

    }
}
