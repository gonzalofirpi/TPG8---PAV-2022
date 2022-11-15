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
using TrabajoIntegradorG8.AccesoDatos;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaTopGoleadores : Form
    {
        public ReporteEstadisticaTopGoleadores()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaTopGoleadores_Load(object sender, EventArgs e)
        {

            this.reportViewerTopGoleadores.RefreshReport();
        }

        private void reportViewerTopGoleadores_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_TipoObservaciones.ObtenerEstadisticasTopGoleadores();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosGoleadoresTop", tabla);
            reportViewerTopGoleadores.LocalReport.DataSources.Clear();
            reportViewerTopGoleadores.LocalReport.DataSources.Add(ds);
            reportViewerTopGoleadores.LocalReport.Refresh();
        }
    }
}
