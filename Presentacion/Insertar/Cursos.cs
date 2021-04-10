using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidade;

namespace Presentacion.Insertar
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        private Ecursos curso;
        private static Acceso_Cursos acceso_curso = new Acceso_Cursos();
        private void Guardar()
        {
            try
            {
                if (curso == null) curso = new Ecursos();
                curso.a = "Insertar";
                curso.nombre = txtCurso.Text;
                curso.horas = int.Parse(txtHoras.Text);

                acceso_curso.InsertarCursos(curso);
                if (acceso_curso.stringBuilder.Length != 0)
                    MessageBox.Show(acceso_curso.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("CURSO REGISTRADO CORRECTAMENTE", "CURSO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
           btnAgregar.BorderStyle= BorderStyle.Fixed3D;
       
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
