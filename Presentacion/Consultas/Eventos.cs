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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }
      
        Eeventos evento= new Eeventos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            evento.a = "Buscar";
            evento.descripcion = txtDescR.Text;
            evento.referencia = txtDescR.Text;
           
            if (Acceso_Eventos.BuscarEventos(evento))
            {
               
                gvDatos.DataSource = Acceso_Eventos.datos;
            }
            else
                MessageBox.Show("NO SE ENCUENTRA ESTE EVENTO");


        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            evento.a = "Todos";
            evento.referencia = "";
            evento.descripcion = "";
            if (Acceso_Eventos.BuscarEventos(evento))           

                gvDatos.DataSource = Acceso_Eventos.datos;

            else {
                MessageBox.Show("NO SE ENCUENTRA ESTE EVENTO");
                txtDescR.Clear();
                txtDescR.Focus();
            }
                
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
