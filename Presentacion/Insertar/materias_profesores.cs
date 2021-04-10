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
    public partial class materias_profesores : Form
    {
        public materias_profesores()
        {
            InitializeComponent();
        }

        Eprofesores profesor;
        Ematerias materia;
        int id_profesor;
        int id_materia;
        private void btnProfesor_Click(object sender, EventArgs e)
        {
            if (profesor == null) profesor = new Eprofesores();

            profesor.a = "Buscar";
            profesor.cedula = txtProfesor.Text;


            if (Accceso_Profesores.BuscarProfesores(profesor))
            {

                gvDatosProfesor.DataSource = Accceso_Profesores.datos;

                id_profesor = int.Parse(gvDatosProfesor.CurrentRow.Cells["id_profesor"].Value.ToString());
                txtNombre.Text = gvDatosProfesor.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = gvDatosProfesor.CurrentRow.Cells["apellido"].Value.ToString();
                txtCedula.Text = gvDatosProfesor.CurrentRow.Cells["cedula"].Value.ToString();
                txtTel.Text = gvDatosProfesor.CurrentRow.Cells["telefono"].Value.ToString();
                txtDire.Text = gvDatosProfesor.CurrentRow.Cells["direccion"].Value.ToString();
            }
            else
                MessageBox.Show("ESTE PROFESOR NO EXISTE", "PARA CONTINUAR:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            if (materia == null) materia = new Ematerias();

            materia.a = "Buscar";
            materia.cod_materia = txtMateria.Text;
            materia.nombre = txtMateria.Text;
            
            if (Acceso_Materias.BuscarMaterias(materia))
            {

                gvDatosMateria.DataSource = Acceso_Materias.datos;

                id_materia = int.Parse(gvDatosMateria.CurrentRow.Cells["id_materia"].Value.ToString());
                txtCod.Text = gvDatosMateria.CurrentRow.Cells["cod_materia"].Value.ToString();
                txtNom.Text = gvDatosMateria.CurrentRow.Cells["nombre"].Value.ToString();
                txtDescri.Text = gvDatosMateria.CurrentRow.Cells["descripcion"].Value.ToString();
                
            }
            else
                MessageBox.Show("ESTA MATERIA NO EXISTE", "PARA CONTINUAR:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnProfesor_MouseHover(object sender, EventArgs e)
        {
            btnProfesor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnProfesor_MouseLeave(object sender, EventArgs e)
        {
            btnProfesor.BorderStyle = BorderStyle.FixedSingle;

        }

        private void btnMateria_MouseHover(object sender, EventArgs e)
        {
            btnMateria.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnMateria_MouseLeave(object sender, EventArgs e)
        {
            btnMateria.BorderStyle = BorderStyle.FixedSingle;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
    }

