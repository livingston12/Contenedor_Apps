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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        Eusuario usu = new Eusuario();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            usu.a = "Buscar";
            usu.Usuario = txtBuscar.Text;
            usu.nombre = txtBuscar.Text;
            if (Acceso_Usuarios.BuscarUsuario(usu))
            {
                gvDatos.DataSource = Acceso_Usuarios.datos;
            }
            else
            {
                MessageBox.Show("Usuario NO EXISTE");
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {

            usu.a = "Todos";
            usu.Usuario = "";
            usu.nombre = "";
            if (Acceso_Usuarios.BuscarUsuario(usu))
                gvDatos.DataSource = Acceso_Usuarios.datos;

            else
            {
                
                MessageBox.Show("NO EXISTEN NINGUN USUARIO");
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

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
