using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using System.Data;
using Data;


namespace Negocios
{
    public class Acceso_Suplidores
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();


        public static bool BuscarSuplidor(Esuplidores suplidor)
        {
            datos = acceso_datos.BuscarSuplidores(suplidor);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }
       

        private bool ValidarSuplidor(Esuplidores suplidor)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(suplidor.nombre)) stringBuilder.Append("El campo NOMBRE es obligatorio");
            if (string.IsNullOrEmpty(suplidor.direccion)) stringBuilder.Append(Environment.NewLine + "El campo DIRECCION es obligatorio");
            if (string.IsNullOrEmpty(suplidor.telefono)) stringBuilder.Append(Environment.NewLine + "El campo TELEFONO es obligatorio");
                       return stringBuilder.Length == 0;
        }
        public void InsertarSuplidor(Esuplidores suplidor)
        {
            if (ValidarSuplidor(suplidor))
            {
                acceso_datos.InsertarSuplidores(suplidor);
            }
        }
    }
}
