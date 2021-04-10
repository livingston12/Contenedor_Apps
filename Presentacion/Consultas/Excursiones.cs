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
    public partial class Excursiones : Form
    {
        public Excursiones()
        {
            InitializeComponent();
        }

        Eexcursiones excursion = new Eexcursiones();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            excursion.a = "Buscar";
            excursion.descripcion = txtDescR.Text;
            excursion.referencia = txtDescR.Text;

            if (Acceso_Excursiones.BuscarExcursiones(excursion))
                gvDatos.DataSource = Acceso_Excursiones.datos;
            else {
                MessageBox.Show("NO SE ENCUENTRA ESTA EXCURSION!");
                txtDescR.Clear();
                txtDescR.Focus();
            }
                
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            excursion.a = "Todos";
            excursion.descripcion = "";
            excursion.referencia = "";

            if (Acceso_Excursiones.BuscarExcursiones(excursion))
                gvDatos.DataSource = Acceso_Excursiones.datos;
            else
                MessageBox.Show("NO SE ENCUENTRAN DATOS ALMACENADOS");
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
