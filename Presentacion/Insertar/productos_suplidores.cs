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
using System.Collections;


namespace Presentacion.Insertar
{
    public partial class productos_suplidores : Form
    {
        public productos_suplidores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Esuplidores suplidor;
        Eproductos producto;
        int id_suplidor;
        int id_producto;

        private void habilitarText()
        {
            txtDescri.Enabled = true;
            txtRef.Enabled = true;
            txtMarca.Enabled = true;
            txtFabri.Enabled = true;
            txtCan.Enabled = true;
            txtPreMa.Enabled = true;
            txtPreCom.Enabled = true;
            txtPreVen.Enabled = true;
            btnAdd.Enabled = false;
            btnAgregar.Enabled = false;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            if (suplidor == null) suplidor = new Esuplidores();

            suplidor.a = "Buscar";
            suplidor.nombre = txtDescR.Text;
            

            if (Acceso_Suplidores.BuscarSuplidor(suplidor))
            {

                gvDatosSuplidor.DataSource = Acceso_Suplidores.datos;
                
                id_suplidor = int.Parse(gvDatosSuplidor.CurrentRow.Cells["id_suplidor"].Value.ToString());
                txtNombre.Text = gvDatosSuplidor.CurrentRow.Cells["nombre"].Value.ToString();
                txtDireccion.Text = gvDatosSuplidor.CurrentRow.Cells["direccion"].Value.ToString();
                txtTel.Text = gvDatosSuplidor.CurrentRow.Cells["telefono"].Value.ToString();
                txtCiudad.Text = gvDatosSuplidor.CurrentRow.Cells["ciudad"].Value.ToString();
                txtDescRProducto.Enabled = true;
                btnBuscarPro.Enabled = true;
                txtDescR.Enabled = false;
                btnBuscar.Enabled = false;
                txtDescRProducto.Focus();

            }
            else
                MessageBox.Show("ESTE SUPLIDOR NO EXISTE", "PARA CONTINUAR:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (producto == null) producto = new Eproductos();


            #region No duplicar valor en dataGrid
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (txtDescRProducto.Text == row.Cells["referencia"].Value.ToString())
                    {
                       
                        MessageBox.Show("YA SE INSERTO ESTE PRODUCTO");
                        txtDescRProducto.Clear();
                        txtDescRProducto.Focus();
                        return;
                                              
                    }
                }
              
            }
            catch { }
            #endregion;

            producto.a = "Buscar";
            producto.descripcion = txtDescRProducto.Text;
            producto.refencia = txtDescRProducto.Text;

            if (Acceso_Productos.BuscarProductos(producto))
            {

                gvDatos.DataSource = Acceso_Productos.datos;
                id_producto = int.Parse(gvDatos.CurrentRow.Cells["id_producto"].Value.ToString());
                txtDescri.Text = gvDatos.CurrentRow.Cells["descripcion"].Value.ToString();
                txtRef.Text = gvDatos.CurrentRow.Cells["referencia"].Value.ToString();
                txtMarca.Text = gvDatos.CurrentRow.Cells["marca"].Value.ToString();
                txtFabri.Text = gvDatos.CurrentRow.Cells["fabricante"].Value.ToString();
                txtCan.Text = gvDatos.CurrentRow.Cells["cantidad"].Value.ToString();
                txtPreCom.Text = gvDatos.CurrentRow.Cells["precio_compra"].Value.ToString();
                txtPreMa.Text = gvDatos.CurrentRow.Cells["precio_por_mayor"].Value.ToString();
                txtPreVen.Text = gvDatos.CurrentRow.Cells["precio_venta"].Value.ToString();

                btnAdd.Enabled = true;
                txtDescu.Enabled = true;

            }
            else
               if( MessageBox.Show("ESTE PRODUCTO NO EXISTE DESEA AGREGAR ESTE PRODUCTO", "PARA CONTINUAR:", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes) {
                habilitarText();
            }
        }

        private Ecompras compra;
        private static Acceso_Compras acceso_compra = new Acceso_Compras();
        private  void Guardar()
        {
            try
            {
                if (compra == null) compra = new Ecompras();
                compra.a = "Insertar";
                compra.suplidor = txtNombre.Text;
              compra.tipo_compra = txtTipo.Text;
                compra.total_pagar = int.Parse(txtTotal.Text);

                acceso_compra.InsertarCompras(compra);
                if (acceso_compra.stringBuilder.Length != 0)
                    MessageBox.Show(acceso_compra.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("COMPRA REGISTRADA CORRECTAMENTE", "COMPRA REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarDatagrid()
        {
            dataGridView1.Rows.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region Editar Todos Los Productos Ingresados
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try {
                    int id = 0;
                    id = Convert.ToInt32(row.Cells["idproducto"].Value);
                    producto.a = "Editar";
                    producto.Id = id;
                    
                    producto.cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    if (Acceso_Productos.ActualizarProductos(producto))
                    {
                        gvDatos.DataSource = Acceso_Productos.datos;
                    }
                } catch { }



            }
            #endregion

            if(txtTipo.Text == "CREDITO")
            {
                Guardar();
                BorrarDatagrid();
                Limpiar();

            }else
            {
                Consultas.Pago_Compras pago = new Consultas.Pago_Compras();
                producto.total = int.Parse(txtTotal.Text);
                MessageBox.Show(producto.total.ToString());
                pago.textBox1.Text = producto.total.ToString();
                pago.ShowDialog();
                Guardar();
                BorrarDatagrid();
            }
            

           
            
          
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
           btnBuscarPro.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarPro.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void productos_suplidores_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btnCancelar.Width, btnCancelar.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btnCancelar.Region = new Region(gp);
            txtTipo.SelectedIndex = 0;
        }

        private void txtPreVen_TextChanged(object sender, EventArgs e)
        {
            try {
                
                int cant = 0;
                int precio = 0;

                cant = int.Parse(txtCan.Text);
                precio = int.Parse(txtPreVen.Text);

                
                    txtSub.Text = (cant * precio).ToString();
                


            }
            catch { }
            
        }

        private void txtDescu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sub;
                int des;
                int tt;
                int tdes;
                sub = int.Parse(txtSub.Text);
                des = int.Parse(txtDescu.Text);
                
                    
                if (des >= 0 && des <= 100)
                {

                    txtTipo.SelectedIndex = 2;
                    tdes = (sub * des) / 100;
                    tt = sub - tdes;
                    txtTotalDes.Text = tdes.ToString();
                    txtTotal.Text = tt.ToString();
                }
                else 
                {
                    MessageBox.Show("NO ACEPTA UN VALOR MAYOR QUE 100");
                    txtDescu.Clear();
                    txtTotalDes.Clear();
                    

                }

            }
            catch {
                txtTotal.Text = txtSub.Text;
                txtTotalDes.Text = "0";
                txtTipo.SelectedIndex = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            int total=0;
            if (id_producto > 0)
            {
               
                 
                dataGridView1.Rows.Add(id_producto.ToString(), txtDescri.Text, txtRef.Text, txtCan.Text, txtPreVen.Text, txtSub.Text);
                btnAgregar.Enabled = true;
                btnDelete.Enabled = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                  
                   total += Convert.ToInt32(row.Cells["total"].Value);
                }
                txtSub.Text = Convert.ToString(total);
                gvDatos.DataSource = null;
                txtDescri.Clear();
                txtRef.Clear();
                txtMarca.Clear();
                txtFabri.Clear();
                txtCan.Clear();
                txtPreCom.Clear();
                txtPreMa.Clear();
                txtPreVen.Clear();
                txtDescRProducto.Clear();
                txtDescRProducto.Focus();
                id_producto = 0;
            }
            else MessageBox.Show("NO HAY PRODUCTO A AGREGAR","POR FAVOR INSERTE UNO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

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

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cant = 0;
                int precio = 0;
               
                cant = int.Parse(txtCan.Text);
                precio = int.Parse(txtPreVen.Text);
                
                if (cant > 0)
                {
                    txtSub.Text = (cant * precio).ToString(); 
                }

             }
            catch {
                
            }
        }

        private void txtSub_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = txtSub.Text; 
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch { }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                int total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += Convert.ToInt32(row.Cells["total"].Value);
                }
                txtSub.Text = Convert.ToString(total);
                if (dataGridView1.DataSource ==null)
                {
                    txtDescu.Text = "";
                    txtTotalDes.Text = "";
                }
            }
            catch { }
        }

        public void Limpiar()
        {
            txtDescR.Enabled = true;
            btnBuscar.Enabled = true;
            txtDescRProducto.Enabled = false;
            btnBuscarPro.Enabled = false;
            gvDatos.DataSource = null;
            txtDescri.Clear();
            txtRef.Clear();
            txtNombre.Clear();
           
            txtMarca.Clear();
            txtFabri.Clear();
            txtCan.Clear();
            txtPreCom.Clear();
            txtPreMa.Clear();
            txtPreVen.Clear();
            txtDescRProducto.Clear();
            txtDescR.Clear();
            id_producto = 0;
            dataGridView1.DataSource = null;
            gvDatosSuplidor.DataSource = null;
            txtSub.Clear();
            txtDescu.Clear();
            txtTotalDes.Clear();
            txtTotal.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTel.Clear();
            txtCiudad.Clear();
            txtDescR.Focus();
            //ENABLE ALL
            txtDescri.Enabled = false;
            txtRef.Enabled = false;
            txtMarca.Enabled = false;
            txtFabri.Enabled = false;
            txtCan.Enabled = false;
            txtPreMa.Enabled = false;
            txtPreCom.Enabled = false;
            txtPreVen.Enabled = false;
            btnAdd.Enabled = false;
            btnAgregar.Enabled = false;


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BorrarDatagrid();

        }
    }
}
