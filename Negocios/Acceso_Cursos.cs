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
  public class Acceso_Cursos
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        public static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarCursos(Ecursos curso)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(curso.nombre)) stringBuilder.Append("El campo NOMBRE es obligatorio");
            return stringBuilder.Length == 0;
        }

        public void InsertarCursos(Ecursos curso)
        {
            if (ValidarCursos(curso))
                acceso_datos.InsertarCursos(curso);
        }

        public static bool BuscarCursos(Ecursos curso)
        {
            datos = acceso_datos.BuscarCursos(curso);
            if (datos.Rows.Count > 0) return true;
            else return false;
        }

    }
}
