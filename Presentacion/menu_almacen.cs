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
    public partial class menu_almacen : Form
    {
        public menu_almacen()
        {
            InitializeComponent();
        }

        private void aGREGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aGREGARMATERIAAPROFESORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOMPRAPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.productos_suplidores ps = new Insertar.productos_suplidores();
            ps.ShowDialog();
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Productos prod = new Insertar.Productos();
            prod.ShowDialog();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Poductos prod = new Consultas.Poductos();
            prod.ShowDialog();
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cXCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
