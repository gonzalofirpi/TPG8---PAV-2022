using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8
{
    public partial class EstadisticaSociosDecada : Form
    {
        public EstadisticaSociosDecada()
        {
            InitializeComponent();
        }

        private void EstadisticaSociosDecada_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Socios.SociosDeLaUltimaDecada();
            ReportDataSource ds = new ReportDataSource("SociosDecada", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
