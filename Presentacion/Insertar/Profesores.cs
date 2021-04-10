using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;
using Negocios;

namespace Presentacion.Insertar
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }
        private Eprofesores profesor;
        private static Accceso_Profesores acceso_profesor = new Accceso_Profesores();
        private void Guardar()
        {
            try
            {
                if (profesor == null) profesor = new Eprofesores();

                profesor.nombre = txtNombre.Text;
                profesor.apellido = txtApellido.Text;
                profesor.cedula = txtCedula.Text;
                profesor.telefono = txtTel.Text;
                profesor.direccion = txtDire.Text;
                profesor.fecha = txtFecha.Text;

                acceso_profesor.InsertarProfesores(profesor);

                if (acceso_profesor.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_profesor.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE", "CLIENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
