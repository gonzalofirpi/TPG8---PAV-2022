using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorG8
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocios ventana = new frmSocios();
            ventana.Show();
        }
        
        private void aBMClubesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmClubes ventana = new frmClubes();
            ventana.Show();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJugadores ventana = new frmJugadores();
            ventana.Show();
        }
        private void consultasToolStripMenuItem8_Click(object sender, EventArgs e)
        {

            frmBarrios ventana = new frmBarrios();
            ventana.Show();
        }
        private void consultasToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ABMLocalidades ventana = new ABMLocalidades();
            ventana.Show();
        }

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMComisiones ventana = new ABMComisiones();
            ventana.Show();
        }

        private void consultasToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ABMarbitros ventana = new ABMarbitros();
            ventana.Show();
           
        }

        private void aBMCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMcanchas ventana = new ABMcanchas();
            ventana.Show();
        }

        private void consultasToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Form2 nuevaCategoria = new Form2();
            nuevaCategoria.Show();
        }

        private void consultasToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form3 nuevoCargo = new Form3();
            nuevoCargo.Show();
        }
    }

       
}
