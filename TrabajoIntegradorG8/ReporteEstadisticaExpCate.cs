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
    public partial class ReporteEstadisticaExpCate : Form
    {
        public ReporteEstadisticaExpCate()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaExpCate_Load(object sender, EventArgs e)
        {

            this.reportViewerExp.RefreshReport();
        }

        private void reportViewerExp_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_TipoObservaciones.ObtenerEstadisticasExpulsiones();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosExpCat", tabla);
            reportViewerExp.LocalReport.DataSources.Clear();
            reportViewerExp.LocalReport.DataSources.Add(ds);
            reportViewerExp.LocalReport.Refresh();

        }
    }
}
