using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidade;
using System.Data;

namespace Negocios
{
    public class Acceso_Excursiones
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarExcursiones(Eexcursiones excursion)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(excursion.descripcion)) stringBuilder.Append("El campo DESCRIPCION es obligatorio");
            if (string.IsNullOrEmpty(excursion.referencia)) stringBuilder.Append(Environment.NewLine + "El campo REFERENCIA es obligatorio");
            return stringBuilder.Length == 0;
        }

        public void InsertarExcursiones(Eexcursiones excursion)
        {
            if (ValidarExcursiones(excursion))
                acceso_datos.InsertarExcursiones(excursion);

        }

        public static bool BuscarExcursiones(Eexcursiones excursion)
        {
            datos = acceso_datos.BuscarExcursiones(excursion);
            if (datos.Rows.Count > 0) return true;
            else return false;

        }

    }
}
