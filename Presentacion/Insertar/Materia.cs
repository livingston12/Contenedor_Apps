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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private Ematerias materia;
        private static Acceso_Materias acceso_materia = new Acceso_Materias();
        private void Guardar()
        {
            try
            {
                if (materia == null) materia = new Ematerias();

                materia.cod_materia = txtCod.Text;
                materia.nombre = txtNombre.Text;
                materia.descripcion = txtDescri.Text;

                acceso_materia.InsertarMaterias(materia);

                if (acceso_materia.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_materia.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
                e.Handled = true;

            else e.Handled = false;
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
