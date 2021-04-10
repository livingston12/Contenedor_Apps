using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using Entidade;

namespace Negocios
{
   public class Acceso_Estudiantes
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        public static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarCursos(Eestudiantes estudiante)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(estudiante.nombre)) stringBuilder.Append("El campo NOMBRE es obligatorio");
            if (string.IsNullOrEmpty(estudiante.apellidos)) stringBuilder.Append("El campo APELLIDO es obligatorio");
            if (string.IsNullOrEmpty(estudiante.rne)) stringBuilder.Append("El campo RNE es obligatorio");
            if (string.IsNullOrEmpty(estudiante.fecha)) stringBuilder.Append("El campo FECHA NACIMIENTO es obligatorio");
            if (string.IsNullOrEmpty(estudiante.sexo)) stringBuilder.Append("El campo SEXO es obligatorio");
            if (string.IsNullOrEmpty(estudiante.direccion)) stringBuilder.Append("El campo DIRECCION es obligatorio");
            if (string.IsNullOrEmpty(estudiante.telefono)) stringBuilder.Append("El campo TELEFONO es obligatorio");
             if (string.IsNullOrEmpty(estudiante.tipo_sangre)) stringBuilder.Append("El campo TIPO DE SANGRE es obligatorio");
            if (string.IsNullOrEmpty(estudiante.ano.ToString())) stringBuilder.Append("El campo FECHA NAC. es obligatorio");
            if (string.IsNullOrEmpty(estudiante.tanda)) stringBuilder.Append("El campo TANDA es obligatorio");
            if (string.IsNullOrEmpty(estudiante.curso)) stringBuilder.Append("El campo CURSO es obligatorio");
           

            return stringBuilder.Length == 0;
        }

        public void InsertarEstudiantes(Eestudiantes estudiante)
        {
            if (ValidarCursos(estudiante))
                acceso_datos.InsertarEstudiantes(estudiante);
        }

        public static bool BuscarEstudiantes(Eestudiantes estudiante)
        {
            datos = acceso_datos.BuscarEstudiantes(estudiante);
            if (datos.Rows.Count > 0)
                return true;
            else return false;
        }

    }
}
