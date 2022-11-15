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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaPromedioEdadCategoriaUltimosCincoAnios : Form
    {
        DataTable Tabla = new DataTable();
        public ReporteEstadisticaPromedioEdadCategoriaUltimosCincoAnios()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaPromedioEdadCategoriaUltimosCincoAnios_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Tabla = AD_Jugadores.obtenerEstadisticaPromedioDeEdad();
            ReportDataSource Datos = new ReportDataSource("DataSetPromedioEdadPorCategoriaUltimosCincoAnios", Tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();
        }
    }
}
