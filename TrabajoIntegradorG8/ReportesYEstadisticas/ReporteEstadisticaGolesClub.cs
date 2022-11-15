using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;
using TrabajoIntegradorG8.AccesoDatos;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaGolesClub : Form
    {
        public ReporteEstadisticaGolesClub()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaGolesClub_Load(object sender, EventArgs e)
        {

            this.reportViewerGoles.RefreshReport();
        }

        private void reportViewerGoles_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_TipoObservaciones.ObtenerEstadisticasGoles();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosGolesClub", tabla);
            reportViewerGoles.LocalReport.DataSources.Clear();
            reportViewerGoles.LocalReport.DataSources.Add(ds);
            reportViewerGoles.LocalReport.Refresh();
        }
    }
}
