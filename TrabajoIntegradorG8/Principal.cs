﻿using System;
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
    }

       private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSocios ventana = new frmSocios();
            ventana.Show();
            this.Hide();
        }

        private void consultasToolStripMenuItem9_Click(object sender, EventArgs e)
        {

            frmSocios ventana = new frmSocios();
            ventana.Show();
            this.Hide();
        }
}
