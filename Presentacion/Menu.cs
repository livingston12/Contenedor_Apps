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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void uSUARIOSToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Consultas.Usuarios usuario = new Consultas.Usuarios();
            usuario.ShowDialog();
        }

        private void sUPLIDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Suplidores suplidor = new Consultas.Suplidores();
            suplidor.ShowDialog();
        }


        private void eSTUDIANTESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Insertar.Estudiantes estu = new Insertar.Estudiantes();
            estu.ShowDialog();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Iusuario usu = new Insertar.Iusuario();
            usu.ShowDialog();
        }

        private void sUPLIDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Suplidores supli = new Insertar.Suplidores();
            supli.ShowDialog();
        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Materia mate = new Insertar.Materia();
            mate.ShowDialog();
        }

        private void mATERIASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Materias mate = new Consultas.Materias();
            mate.ShowDialog();
        }

        private void eVENTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Eventos even = new Consultas.Eventos();
            even.ShowDialog();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Eventos even = new Insertar.Eventos();
            even.ShowDialog();
        }

        private void eXCURSIONESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Excursiones excur = new Consultas.Excursiones();
            excur.ShowDialog();
        }

        private void eXCURSIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Excursiones excur = new Insertar.Excursiones();
            excur.ShowDialog();
        }

        private void eSTUDIANTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Estudiantes estu = new Consultas.Estudiantes();
            estu.ShowDialog();
        }

        private void cURSOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.Cursos curso = new Insertar.Cursos();
            curso.ShowDialog();
        }

        private void cURSOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Cursos curso = new Consultas.Cursos();
            curso.ShowDialog();
        }

       
        private void aGREGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Insertar.Productos prod = new Insertar.Productos();
            prod.ShowDialog();
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Poductos prod = new Consultas.Poductos();
            prod.ShowDialog();
        }

        private void aGREGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void aGREGARMATERIAAPROFESORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar.materias_profesores mt = new Insertar.materias_profesores();
            mt.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insertar.productos_suplidores ps = new Insertar.productos_suplidores();
            ps.ShowDialog();
        }

        private void cXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.CXP cxp = new Consultas.CXP();
            cxp.ShowDialog(); 
        }
    }
}
