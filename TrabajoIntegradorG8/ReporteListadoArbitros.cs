using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoIntegradorG8.AccesoADatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class ReporteListadoArbitros : Form
    {

        public ReporteListadoArbitros()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;  
            txtApellidoArbitro.Enabled = false;
        }

        private void ReporteListadoArbitros_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbArbitrosAlfabeticamente.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Arbitros.obtenerListadoArbitrosOrdenado();

                ReportDataSource ds = new ReportDataSource("DatosArbitros", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                //reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            if (rbArbitrosLetra.Checked && txtApellidoArbitro.Text != "")
            {
                string letra = txtApellidoArbitro.Text;
                DataTable tabla = new DataTable();
                tabla = AD_Arbitros.obtenerListadoArbitrosLetra(letra);

                ReportDataSource ds = new ReportDataSource("DatosArbitros", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                //reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                txtApellidoArbitro.Text = "";
            }
        }

        private void rbArbitrosAlfabeticamente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArbitrosAlfabeticamente.Checked)
            {
                btnBuscar.Enabled = true;
                txtApellidoArbitro.Enabled = false;
                txtApellidoArbitro.Text = "";
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void rbArbitrosLetra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArbitrosLetra.Checked)
            {
                btnBuscar.Enabled = true;
                txtApellidoArbitro.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
                txtApellidoArbitro.Enabled = false;
            }
        }
    }
}
