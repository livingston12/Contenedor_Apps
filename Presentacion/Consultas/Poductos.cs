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
    public partial class Poductos : Form
    {
        public Poductos()
        {
            InitializeComponent();
        }

        Eproductos producto = new Eproductos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            producto.a = "Buscar";
            producto.descripcion = txtDescR.Text;
            producto.refencia = txtDescR.Text;

            if (Acceso_Productos.BuscarProductos(producto))
                gvDatos.DataSource = Acceso_Productos.datos;
            else
            {
                MessageBox.Show("ESTE PRODUCTO NO EXISTE", "PARA CONTINUAR:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescR.Clear();
                txtDescR.Focus();
            }
            }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            producto.a = "Todos";
            producto.descripcion = "";
            producto.refencia = "";

            if (Acceso_Productos.BuscarProductos(producto))
                gvDatos.DataSource = Acceso_Productos.datos;
            else
                MessageBox.Show("NO EXISTEN NINGUN PRODUCTO", "PARA CONTINUAR:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
