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
using TrabajoIntegradorG8.Reportes;
using TrabajoIntegradorG8.Estadisticas;

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
            ventana.ShowDialog();
        }
        
        private void aBMClubesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmClubes ventana = new frmClubes();
            ventana.ShowDialog();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJugadores ventana = new frmJugadores();
            ventana.ShowDialog();
        }
        private void consultasToolStripMenuItem8_Click(object sender, EventArgs e)
        {

            frmBarrios ventana = new frmBarrios();
            ventana.ShowDialog();
        }
        private void consultasToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ABMLocalidades ventana = new ABMLocalidades();
            ventana.ShowDialog();
        }

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMComisiones ventana = new ABMComisiones();
            ventana.ShowDialog();
        }

        private void consultasToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ABMarbitros ventana = new ABMarbitros();
            ventana.ShowDialog();
           
        }

        private void aBMCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMcanchas ventana = new ABMcanchas();
            ventana.ShowDialog();
        }

        private void consultasToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Form2 nuevaCategoria = new Form2();
            nuevaCategoria.ShowDialog();
        }

        private void consultasToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form3 nuevoCargo = new Form3();
            nuevoCargo.ShowDialog();

        }        

        private void consultasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PuestosABM ventana = new PuestosABM();
            ventana.ShowDialog();
        }

        private void consultasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ABMTipoObservaciones ventana = new ABMTipoObservaciones();
            ventana.ShowDialog();
        }

        private void consultasToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmPartido ventana = new frmPartido();
            ventana.ShowDialog();
        }

        private void listadoDePartidostoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteListadoPartidos ventana = new ReporteListadoPartidos();
            ventana.ShowDialog();
        }

        private void listadoDeCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoCanchas ventana = new ReporteListadoCanchas();
            ventana.ShowDialog();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaComisiones ventana = new ReporteEstadisticaComisiones();
            ventana.ShowDialog();
        }

        private void estadísticaDeGolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaGolesClub ventana = new ReporteEstadisticaGolesClub();
            ventana.ShowDialog();
        }

        private void estadísticaDeExpulsionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaExpCate ventana = new ReporteEstadisticaExpCate();
            ventana.ShowDialog();
        }

        private void estadísticaDeTopGoleadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaTopGoleadores ventana = new ReporteEstadisticaTopGoleadores();
        }
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteSocio ventana = new ReporteSocio();
            ventana.ShowDialog();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaSocio ventana = new EstadisticaSocio();
            ventana.ShowDialog();        
        }

        private void estadisticaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstadisticaPartidocs ventana = new EstadisticaPartidocs();
            ventana.ShowDialog();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteComisiones ventana = new ReporteComisiones();
            ventana.ShowDialog();
        }
    }

       
}
