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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        Ecursos curso = new Ecursos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            curso.a = "Buscar";
            curso.nombre = txtDescR.Text;
            if (Acceso_Cursos.BuscarCursos(curso))
                gvDatos.DataSource = Acceso_Cursos.datos;
            else
            {
                MessageBox.Show("NO EXISTE ESTE CURSO");
                txtDescR.Clear();
                txtDescR.Focus();
            }
                

            
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            curso.a = "Todos";
            curso.nombre = "";
            if (Acceso_Cursos.BuscarCursos(curso))
                gvDatos.DataSource = Acceso_Cursos.datos;
            else
                MessageBox.Show("NO CONTIENE DATOS");
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

        private void Cursos_Load(object sender, EventArgs e)
        {

        }
    }
}
