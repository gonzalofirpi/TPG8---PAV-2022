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
    }
}
