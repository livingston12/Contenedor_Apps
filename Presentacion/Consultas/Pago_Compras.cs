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

namespace Presentacion.Consultas
{
    public partial class Pago_Compras : Form
    {
        
        public Pago_Compras()
        {
            
            InitializeComponent();
           
          
        }

        private void Pago_Compras_Load(object sender, EventArgs e)
        {
            label1.Text = "CANTIDAD A \n DEBER";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
           else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textBox1.Text);
            int pagar = int.Parse(textBox2.Text);
            int devuelta = pagar - total;

            if (total > pagar)
                MessageBox.Show("DEBE PAGAR UNA CANTIDAD ACORDE CON EL TOTAL", "INGRESE CORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                textBox3.Text = devuelta.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
