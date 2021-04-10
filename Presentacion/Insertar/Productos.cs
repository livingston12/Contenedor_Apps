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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        private Eproductos producto;
        private static Acceso_Productos acceso_producto = new Acceso_Productos();
        public void Insertar()
        {
            try
                {
                if (producto == null) producto = new Eproductos();
                producto.a = "Insertar";
                producto.descripcion = txtDescri.Text;
                producto.refencia = txtRef.Text;
                producto.marca = txtMarca.Text;
                producto.fabricante = txtFabri.Text;
                producto.cantidad = int.Parse(txtCan.Text);
                producto.precio_mayor = int.Parse(txtPreMa.Text);
                producto.precio_compra = int.Parse(txtPreCom.Text);
                producto.precio_venta = int.Parse(txtPreVen.Text);

                acceso_producto.InsertarProductos(producto);
                if (acceso_producto.stringBuilder.Length != 0)
                    MessageBox.Show(acceso_producto.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("PRODUCTO registrado correctamente", "PRODUCTO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            catch(Exception ex)
                {
                MessageBox.Show(string.Format("ERROR {0}", ex.Message), "ERROR INESPERADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPreMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtRef_KeyPress(object sender, KeyPressEventArgs e)
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
            btnLimpiar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtPreCom_TextChanged(object sender, EventArgs e)
        {
            int Pc;
            int pv;
            int v;
           
            Pc = int.Parse(txtPreCom.Text);
            if (Pc > 0)
            {
                v = (Pc * 20) / 100;
                pv = Pc + v; 
                txtPreVen.Text = pv.ToString();
            }
        }
    }
}
