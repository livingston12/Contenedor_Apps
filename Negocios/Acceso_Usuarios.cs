using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Data;
using Entidade;

namespace Negocios
{
   public class Acceso_Usuarios
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();
       
        private static Acceso_Datos acceso_Dato = new Acceso_Datos();
       
        public static DataTable datos;

        public static bool login(string usuario, string pass, string tipo)
        {
            
            return Acceso_Datos.login(usuario, pass, tipo);

        }
        private  bool ValidarUsuario(Eusuario usuario)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(usuario.Usuario)) stringBuilder.Append("El campo USUARIO es obligatorio");
            if (string.IsNullOrEmpty(usuario.pass)) stringBuilder.Append(Environment.NewLine + "El campo CONTRASEÑA es obligatorio");
            if (string.IsNullOrEmpty(usuario.nombre)) stringBuilder.Append(Environment.NewLine + "El campo NOMBRE es obligatorio");
            if (string.IsNullOrEmpty(usuario.apellido)) stringBuilder.Append(Environment.NewLine + "El campo APELLIDO es obligatorio");

            return stringBuilder.Length == 0;
        }
        public void InsertarUsuario(Eusuario usuario)
        {
            if (ValidarUsuario(usuario))
            {
                acceso_Dato.InsertarUsuario(usuario);
            }
        }
        public static bool BuscarUsuario(Eusuario usuario)
        {
            datos = acceso_Dato.BuscarUsuario(usuario);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }

        
       
    }
}
