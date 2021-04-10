using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using Data;
using System.Data;

namespace Negocios
{
   public class Acceso_Materias
    {

        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarMaterias(Ematerias materia)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(materia.cod_materia)) stringBuilder.Append("El campo COD_MATERIA es obligatorio");
            if (string.IsNullOrEmpty(materia.nombre)) stringBuilder.Append(Environment.NewLine + "El campo NOMBRE es obligatorio");
            if (string.IsNullOrEmpty(materia.descripcion)) stringBuilder.Append(Environment.NewLine + "El campo DESCRIPCION es obligatorio");
            
            return stringBuilder.Length == 0;
        }

        public void InsertarMaterias(Ematerias materia)
        {
            if (ValidarMaterias(materia))
                acceso_datos.InsertarMaterias(materia);
        }
        public static bool BuscarMaterias(Ematerias materia)
        {
            datos = acceso_datos.BuscarMaterias(materia);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }
       
    }
}
