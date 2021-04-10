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
    public partial class NOTAS : Form
    {
        public NOTAS()
        {
            InitializeComponent();
        }

        private void NOTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_escolarDataSet2.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter1.Fill(this.sistema_escolarDataSet2.materias);
            // TODO: esta línea de código carga datos en la tabla 'sistema_escolarDataSet3.materias' Puede moverla o quitarla según sea necesario.
            txtMat.TabIndex = 1;
            

        }
        Eestudiantes estudiante = new Eestudiantes();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void txtAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == (char)13)
{                e.Handled = true;
                estudiante.a = "Buscar2";
                estudiante.nombre = txtAlum.Text;
                estudiante.apellidos = "";
                estudiante.curso = "";
                estudiante.rne = txtAlum.Text;
                if (Acceso_Estudiantes.BuscarEstudiantes(estudiante))
                {
                    dvAlumn.DataSource = Acceso_Estudiantes.datos;
                    txtcurso.Text = dvAlumn.CurrentRow.Cells["curso"].Value.ToString();
                    txtNota1.Enabled = true;
                }

                else
                {
                    MessageBox.Show("NO EXISTE ESTE ESTUDIANTE", "PULSA PARA CONTINUAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAlum.Clear();
                    groupBox1.Enabled = true;
                    txtAlum.Focus();
                }
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! (txtNota1.Text == ""))
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
                if (e.KeyChar == (char)13)
                {
                    e.Handled = true;
                    txtNota2.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
            }





        }

        private void txtNota4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nota1 = int.Parse(txtNota1.Text);
                int nota2 = int.Parse(txtNota2.Text);
                int nota3 = int.Parse(txtNota3.Text);
                int nota4 = int.Parse(txtNota4.Text);
                int promedio = 0;
                promedio = (nota1 + nota2 + nota3 + nota4)/4;
                txtProm.Text = promedio.ToString();
            }
            catch { }
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nota = int.Parse(txtNota1.Text);
                if (nota > 100)
                    txtNota1.Text = "100";
                else if (nota < 0)
                    txtNota1.Text = "0";
            }
            catch { }
            



        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(txtNota2.Text == ""))
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
                if (e.KeyChar == (char)13)
                {
                    e.Handled = true;
                    txtNota3.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(txtNota3.Text == ""))
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
                if (e.KeyChar == (char)13)
                {
                    e.Handled = true;
                    txtNota4.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }
    }
}
