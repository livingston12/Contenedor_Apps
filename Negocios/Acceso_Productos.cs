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
   public class Acceso_Productos
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarProductos(Eproductos producto)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(producto.descripcion)) stringBuilder.Append("El campo DESCRIPCION es obligatorio");
            if (string.IsNullOrEmpty(producto.fabricante)) stringBuilder.Append(Environment.NewLine + "El campo FABRICANTE es obligatorio");
            if (string.IsNullOrEmpty(producto.marca)) stringBuilder.Append(Environment.NewLine + "El campo MARCA es obligatorio");
            if (string.IsNullOrEmpty(producto.cantidad.ToString())) stringBuilder.Append(Environment.NewLine + "El campo CANTIDAD es obligatorio");
            if (string.IsNullOrEmpty(producto.precio_mayor.ToString())) stringBuilder.Append(Environment.NewLine + "El campo PRECIO POR MAYOR es obligatorio");
            if (string.IsNullOrEmpty(producto.precio_venta.ToString())) stringBuilder.Append(Environment.NewLine + "El campo PRECIO VENTA es obligatorio");
            if (string.IsNullOrEmpty(producto.precio_compra.ToString())) stringBuilder.Append(Environment.NewLine + "El campo PRECIO COMPRA es obligatorio");
            return stringBuilder.Length == 0;
        }

        public void InsertarProductos(Eproductos producto)
        {
            if (ValidarProductos(producto))
                acceso_datos.InsertarProductos(producto);
        }

        public static bool BuscarProductos(Eproductos producto)
        {
            datos = acceso_datos.BuscarProductos(producto);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }

        public static bool ActualizarProductos(Eproductos producto)
        {
            datos = acceso_datos.ActualizarProductos(producto);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }

    }
}
