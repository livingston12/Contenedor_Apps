using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int N = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {


            N++;
            progressBar1.Value = N;
            label1.Text = N.ToString();

            if (N == 100) {
                timer1.Stop();
                this.Hide();
                Login lg = new Login();
                lg.ShowDialog();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
