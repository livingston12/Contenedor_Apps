using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Conexion
    {
        static string cadenacnx = @"Data Source=DESKTOP-6A156AS\LIVINGSTON;Initial Catalog=sistema_escolar;Integrated Security=True";
        public static string cadenaConexion
        {
            get { return cadenacnx; }
        }

    }
}
