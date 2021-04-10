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
    public partial class Menu_Maestro : Form
    {
        public Menu_Maestro()
        {
            InitializeComponent();
        }

        private void pUBLICARNOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.NOTAS notas = new Insertar.NOTAS();
            notas.ShowDialog();
        }
    }
}
