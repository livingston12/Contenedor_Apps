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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        Eestudiantes estudiante = new Eestudiantes();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estudiante.a = "Buscar";
            estudiante.nombre = txtDescR.Text;
            estudiante.apellidos = txtDescR.Text;
            estudiante.curso = txtDescR.Text;
            estudiante.rne = txtDescR.Text;
            if (Acceso_Estudiantes.BuscarEstudiantes(estudiante))
                gvDatos.DataSource = Acceso_Estudiantes.datos;
            else {
                MessageBox.Show("NO EXISTE ESTE ESTUDIANTE", "PULSA PARA CONTINUAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescR.Clear();
                txtDescR.Focus();
            }

                
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            estudiante.a = "Todos";
            estudiante.nombre = "";
            estudiante.apellidos = "";
            estudiante.curso = "";
            estudiante.rne = "";
            if (Acceso_Estudiantes.BuscarEstudiantes(estudiante))
                gvDatos.DataSource = Acceso_Estudiantes.datos;
            else
            {
                MessageBox.Show("NO EXISTE ESTE ESTUDIANTE", "PULSA PARA CONTINUAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescR.Clear();
                txtDescR.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(null, null);
            }
        }
    }
}
