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
 public  class Accceso_Profesores
    {
        public static DataTable datos;
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private static Acceso_Datos acceso_datos = new Acceso_Datos();

        private bool ValidarProfesor( Eprofesores profesor)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(profesor.nombre)) stringBuilder.Append("El campo NOMBRE es obligatorio");
            if (string.IsNullOrEmpty(profesor.apellido)) stringBuilder.Append(Environment.NewLine + "El campo APELLIDO es obligatorio");
            if (string.IsNullOrEmpty(profesor.cedula)) stringBuilder.Append(Environment.NewLine + "El campo CEDULA es obligatorio");
            if (string.IsNullOrEmpty(profesor.telefono)) stringBuilder.Append(Environment.NewLine + "El campo TELEFONO es obligatorio");
                        if (string.IsNullOrEmpty(profesor.direccion)) stringBuilder.Append(Environment.NewLine + "El campo DIRECCION es obligatorio");
            if (string.IsNullOrEmpty(profesor.fecha)) stringBuilder.Append(Environment.NewLine + "El campo FECHA_NACIMIENTO es obligatorio");
            return stringBuilder.Length == 0;
        }

        public void InsertarProfesores(Eprofesores profesor)
        {
            if (ValidarProfesor(profesor))
            {
                acceso_datos.InsertarProfesores(profesor);
            }
        }

        public static bool BuscarProfesores(Eprofesores profesor)
        {
            datos = acceso_datos.BuscarProfesores(profesor);
            if (datos.Rows.Count > 0) return true;
            else return false;
                       
        }

       
    }
}
