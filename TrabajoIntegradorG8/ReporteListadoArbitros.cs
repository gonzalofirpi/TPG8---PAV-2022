using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteListadoArbitros()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;  
        }

        private void ReporteListadoArbitros_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Arbitros.obtenerListadoArbitrosOrdenado(); 

            ReportDataSource ds = new ReportDataSource("DatosArbitros", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbArbitrosAlfabeticamente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArbitrosAlfabeticamente.Checked)
            {
                btnBuscar.Enabled = true;
            }
        }
    }
}
