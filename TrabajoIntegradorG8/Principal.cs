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

        private void consultasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 nuevaCategoria = new Form2();
            nuevaCategoria.Show();
            this.Hide();
        }

        private void consultasToolStripMenuItem10_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nuevoCargo = new Form3();
            nuevoCargo.Show();
            this.Hide();
        }
    }
}
