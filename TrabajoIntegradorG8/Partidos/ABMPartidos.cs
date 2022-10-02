using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorG8.Partidos
{
    public partial class ABMPartidos : Form
    {
        public ABMPartidos()
        {
            InitializeComponent();
        }

        private void ABMPartidos_Load(object sender, EventArgs e)
        {

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();            
        }

        private void LimpiarDatos()
        {
            txtcancha.Text = " ";
            txtclub.Text = " ";
            txtcod.Text = " ";
            txtfecha.Text = " ";
            txtlocal.Text = " ";
            txtvisitante.Text = " ";
        }
    }
}
