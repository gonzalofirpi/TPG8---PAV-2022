using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.Partidos;

namespace TrabajoIntegradorG8
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void consultasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ABMPartidos ventana = new ABMPartidos();
            ventana.Show();
        }
    }
}
