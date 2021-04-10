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

namespace Presentacion.Insertar
{
    public partial class Iusuario : Form
    {
        public Iusuario()
        {
            InitializeComponent();
        }

       private Eusuario usuario;
        private static Acceso_Usuarios acceso_usuario = new Acceso_Usuarios();
        private void Guardar()
        {
            try
            {
                if (usuario == null) usuario = new Eusuario();

                usuario.a = "Insertar";
                usuario.Usuario = txtNombre.Text;
                usuario.pass = txtPass.Text;
                usuario.tipo = txtTipo.Text;
                usuario.nombre = txtNom.Text;
                usuario.apellido = txtApe.Text;
                if (txtCurso.Enabled == true)
                    usuario.curso = txtCurso.Text;
                else
                    usuario.curso = "";
                acceso_usuario.InsertarUsuario(usuario);

                if (acceso_usuario.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_usuario.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE", "CLIENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Iusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_escolarDataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.sistema_escolarDataSet.cursos);
            txtTipo.SelectedIndex = 0;
            txtCurso.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             private void linkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void linkLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            
            else e.Handled = false;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
            btnSalir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTipo.Text == "ESTUDIANTE" || txtTipo.Text == "MAESTRO")
                txtCurso.Enabled = true;
            else
                txtCurso.Enabled = false;
        }
    }
    }

