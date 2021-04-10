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
    public partial class Excursiones : Form
    {
        public Excursiones()
        {
            InitializeComponent();
        }
        private Eexcursiones excursion;
        private static Acceso_Excursiones acceso_excursiones = new Acceso_Excursiones();
        private void Guardar()
        {
            try
            {
                if (excursion == null) excursion = new Eexcursiones();

                excursion.a = "Insertar";
                excursion.descripcion = txtDescri.Text;
                excursion.referencia = txtRefe.Text;
                excursion.precio = int.Parse(txtPre.Text);
                excursion.fecha = txtFecha.Text;

                acceso_excursiones.InsertarExcursiones(excursion);

                if (acceso_excursiones.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_excursiones.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtRefe_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
