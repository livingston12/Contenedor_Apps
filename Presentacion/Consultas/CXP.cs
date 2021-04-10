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
    public partial class CXP : Form
    {
        public CXP()
        {
            InitializeComponent();
        }

        private void CXP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_escolarDataSet2.CXP' Puede moverla o quitarla según sea necesario.
            this.cXPTableAdapter.Fill(this.sistema_escolarDataSet2.CXP);

        }

        Ecxp cxp = new Ecxp();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cxp.a = "Buscar";
            cxp.suplidor = txtDescR.Text;
            if (Acceso_Compras.BuscarCxp(cxp))
                gvDatos.DataSource =Acceso_Compras.datos;
            else {
                MessageBox.Show("NO EXISTE ESTE COMPRA");
                txtDescR.Clear();
                txtDescR.Focus();
            }
                
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            cxp.a = "Todos";
            cxp.suplidor = "";
            if (Acceso_Compras.BuscarCxp(cxp))
                gvDatos.DataSource = Acceso_Compras.datos;
            else
                MessageBox.Show("NO EXISTE NINGUNA COMPRA");
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
