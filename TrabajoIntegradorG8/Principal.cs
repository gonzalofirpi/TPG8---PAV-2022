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
using TrabajoIntegradorG8.EstadoCancha;

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

        

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTipoObservaciones ventana = new ABMTipoObservaciones();
            ventana.Show();
            this.Hide();
        }
    }
}
