using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.Puestos;

namespace TrabajoIntegradorG8
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        

        private void consultasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PuestosABM ventana = new PuestosABM();
            ventana.Show();
            this.Hide();
        }
    }
}
