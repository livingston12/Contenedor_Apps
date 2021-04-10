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
   public class Acceso_Compras
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        public static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarCompras(Ecompras compra)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(compra.suplidor)) stringBuilder.Append("El campo SUPLIDOR es obligatorio");
            if (string.IsNullOrEmpty(compra.total_pagar.ToString())) stringBuilder.Append("ES OBLIGATORIO AGREGAR PRODUCTOS");

            return stringBuilder.Length == 0;
        }

        public  void InsertarCompras(Ecompras compra)
        {
            if (ValidarCompras(compra))
                acceso_datos.InsertarCompras(compra);
        }

        public static bool BuscarCxp(Ecxp cxp)
        {
            datos = acceso_datos.BuscarCxp(cxp);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }

    }
}
