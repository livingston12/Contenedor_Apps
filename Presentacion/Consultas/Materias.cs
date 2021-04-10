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

namespace Presentacion.Consultas
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }
        Ematerias materia = new Ematerias();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            materia.a = "Buscar";
            materia.cod_materia = txtDescR.Text;
            materia.nombre = txtDescR.Text;

            if (Acceso_Materias.BuscarMaterias(materia))
                gvDatos.DataSource = Acceso_Materias.datos;
            else
            {
                MessageBox.Show("NO SE ENCUENTRA ESTA MATERIA");
                txtDescR.Clear();
                txtDescR.Focus();
            }

            }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            materia.a = "Todos";
            materia.cod_materia = "";
            materia.nombre = "";

            if (Acceso_Materias.BuscarMaterias(materia))
                gvDatos.DataSource = Acceso_Materias.datos;
            else
                MessageBox.Show("NO SE ENCUENTRA ESTA MATERIA");
        }

        private void txtDescR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(null, null);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
