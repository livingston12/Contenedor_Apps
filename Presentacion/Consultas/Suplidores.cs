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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }
        private Esuplidores supli = new Esuplidores();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            supli.a = "Buscar";
            supli.nombre = txtBuscar.Text;
            if (Acceso_Suplidores.BuscarSuplidor(supli))
                gvDatos.DataSource = Acceso_Suplidores.datos;
            else
            {
                txtBuscar.Clear();
                txtBuscar.Focus();
                MessageBox.Show("NO SE ENCUENTRA ESTE SUPLIDOR");
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            supli.a = "Todos";
            if (Acceso_Suplidores.BuscarSuplidor(supli))
            {
                gvDatos.DataSource = Acceso_Suplidores.datos;
            }
            else MessageBox.Show("NO EXISTEN SUPLIDORES!");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(null, null);
            }
        }
    }
}
