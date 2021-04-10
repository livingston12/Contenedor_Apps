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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private Eestudiantes estudiante;
        private static Acceso_Estudiantes acceso_estudiantes= new Acceso_Estudiantes();
        private void Guardar()
        {
            try
            {
                string sexo="";
                if (estudiante == null) estudiante = new Eestudiantes();

                estudiante.a = "Insertar";
                estudiante.nombre = txtNombre.Text;
                estudiante.apellidos = txtApelli1.Text +" "+ txtApelli2.Text;
                estudiante.rne = txtRNE.Text;
                estudiante.fecha = txtFecha.Text;
                if (rbMascu.Checked == true)
                    sexo = "MASCULINO";
                else if (rbFeme.Checked == true)
                    sexo = "FEMENINO";
                estudiante.sexo = sexo;
                estudiante.direccion = txtDire.Text;
                estudiante.telefono = txtTel.Text;
                estudiante.enfermedades = txtComentario.Text;
                estudiante.tipo_sangre = cbSangre.Text;
                estudiante.tanda = cbTanda.Text;
                estudiante.curso = cbCurso.Text;
                estudiante.instituto = txtInstituto.Text;

                acceso_estudiantes.InsertarEstudiantes(estudiante);

                if (acceso_estudiantes.stringBuilder.Length != 0)
                {
                    MessageBox.Show(acceso_estudiantes.stringBuilder.ToString(), "Para continuar:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("ESTUDIANTE REGISTRADO CORRECTAMENTE", "ESTUDIANTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_escolarDataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.sistema_escolarDataSet.cursos);
            for (int a = 2016; a <= 2050; a++)
               {
                cbAno.Items.Add(a);
               }
            cbAno.SelectedIndex = 0;
            cbCurso.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            cbTanda.SelectedIndex = 0;

          

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSi.Checked == true)
                txtComentario.Enabled = true;
            else txtComentario.Enabled = false;
        }

        private void rbInstitutoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstitutoSi.Checked == true)
                txtInstituto.Enabled = true;
            else txtInstituto.Enabled = false;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
