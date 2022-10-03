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

        private void aBMClubesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmClubes ventana = new frmClubes();
            ventana.Show();
            this.Hide();
        }

        private void consultasToolStripMenuItem8_Click(object sender, EventArgs e)
        {

            frmBarrios ventana = new frmBarrios();
            ventana.Show();
            this.Hide();
        }
    }
}
