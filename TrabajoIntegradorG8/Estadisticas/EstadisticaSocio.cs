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

namespace TrabajoIntegradorG8.Estadisticas
{
    public partial class EstadisticaSocio : Form
    {
        public EstadisticaSocio()
        {
            InitializeComponent();
        }

        private void EstadisticaSocio_Load(object sender, EventArgs e)
        {

            this.rv3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            AD_Socios socios = new AD_Socios();
            DataTable tabla = socios.EstadisticaSocio();
            //tabla = socios.BuscarSocioxFecha(txtYear1.Text, txtYear2.Text);
            ReportDataSource datos = new ReportDataSource("DataSet3", tabla);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RP3", "Grafico de socios dados de alta por año: ");
            rv3.LocalReport.SetParameters(parametro);
            rv3.LocalReport.DataSources.Clear();
            rv3.LocalReport.DataSources.Add(datos);
            rv3.RefreshReport();
        }
    }
}
