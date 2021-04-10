using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using Entidade;

namespace Negocios
{
  public class Acceso_Eventos
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarEvento(Eeventos evento)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(evento.descripcion)) stringBuilder.Append("El campo DESCRIPCION es obligatorio");
            if (string.IsNullOrEmpty(evento.referencia)) stringBuilder.Append(Environment.NewLine + "El campo REFERENCIA es obligatorio");
            return stringBuilder.Length == 0;
        }

        public void InsertarEventos(Eeventos evento)
        {
            if (ValidarEvento(evento))
                acceso_datos.InsertarEventos(evento);

        }

        public static bool BuscarEventos(Eeventos evento)
        {
            datos = acceso_datos.BuscarEventos(evento);
            if (datos.Rows.Count > 0) return true;
            else return false;

        }

    }
}
