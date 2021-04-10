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

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string[] usuario = new string[2];
        private void Login_Load(object sender, EventArgs e)
        {
            txtTipo.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?","Esta aplicacion esta a punto de cerrarse", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Application.Exit();
            }
        }
        int a = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            
            if (Acceso_Usuarios.login(txtUsuario.Text, txtPass.Text,txtTipo.Text)==true) {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                this.Hide();
                Menu menu = new Menu();
                menu_almacen menu_Alma = new menu_almacen();
                menu_Estudiante menu_estu = new menu_Estudiante();
                Menu_Maestro menu_ma = new Menu_Maestro();

                if (txtTipo.Text == "ADM")
                    menu.Show();
                else if (txtTipo.Text == "ALMACEN")
                    menu_Alma.Show();
                else if (txtTipo.Text == "ESTUDIANTE")
                    menu_estu.Show();
                else if (txtTipo.Text == "MAESTRO")
                    menu_ma.Show();  
                usuario[0] = txtUsuario.Text;
                usuario[1] = txtTipo.Text;
                menu.label3.Text = usuario[0].ToString();
                menu.lbladm.Text = usuario[1].ToString();
                
            }
            else
            {
               
                a++;

                MessageBox.Show("INTRODUZCA TODOS LOS CAMPOS CORRECTAMENTE " + a + " INTENTOS" , "DATOS INTRODUCIDOS INCORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtUsuario.Clear();
                txtPass.Clear();
                if (a == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAceptar_Click(null, null);
            }
        }

        private void txtTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAceptar_Click(null, null);
            }
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BorderStyle = BorderStyle.None;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
           btnCancelar.BorderStyle = BorderStyle.None;
        }

        private void linkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void linkLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
                e.Handled = true;

            else e.Handled = false;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
                e.Handled = true;

            else e.Handled = false;
        }
    }
}
