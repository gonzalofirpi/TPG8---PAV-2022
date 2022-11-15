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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaPartidosConMenosGoles : Form

    {
        DataTable Tabla = new DataTable();

        public ReporteEstadisticaPartidosConMenosGoles()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaPartidosConMenosGoles_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)

   
        {
            Tabla = AD_Partidos.obtenerEstadisticaPartidosConMenosGoles();
            ReportDataSource Datos = new ReportDataSource("DataSet5PartidosConMenosGoles", Tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();
        }
    }
}
