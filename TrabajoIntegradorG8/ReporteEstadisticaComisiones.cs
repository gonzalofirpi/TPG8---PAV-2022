using Microsoft.Reporting.WinForms;
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
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaComisiones : Form
    {
        public ReporteEstadisticaComisiones()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaComisiones_Load(object sender, EventArgs e)
        {

            this.reportViewerEstCom.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Comisiones.ObtenerEstadisticasComisiones();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticasComisiones", tabla);
            reportViewerEstCom.LocalReport.DataSources.Clear();
            reportViewerEstCom.LocalReport.DataSources.Add(ds);
            reportViewerEstCom.LocalReport.Refresh();

        }

        

    }
}
