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

namespace Presentacion.Consultas
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        Eprofesores profesor = new Eprofesores();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            profesor.a = "Buscar";
            profesor.cedula = txtCedula.Text;
            if (Accceso_Profesores.BuscarProfesores(profesor))
                gvDatos.DataSource = Accceso_Profesores.datos;
            else
            {
                MessageBox.Show("NO SE ENCUENTRA ESTE PROFESOR");
                txtCedula.Clear();
                txtCedula.Focus();
            }
            }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            profesor.a = "TODOS";
            profesor.cedula = "";
            if (Accceso_Profesores.BuscarProfesores(profesor))
                gvDatos.DataSource = Accceso_Profesores.datos;
            else
                MessageBox.Show("NO EXISTEN PROFESORES!");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(null, null);
            }
        }
    }
}
