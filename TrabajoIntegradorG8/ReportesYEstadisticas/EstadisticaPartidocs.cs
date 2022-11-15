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
    public partial class EstadisticaPartidocs : Form
    {
        public EstadisticaPartidocs()
        {
            InitializeComponent();
        }

        private void EstadisticaPartidocs_Load(object sender, EventArgs e)
        {

            this.rv4.RefreshReport();
            this.rv4.RefreshReport();
            txtYear.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("Ingrese una fecha ", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtYear.Focus();
                
            }
            else
            {
                AD_Partidos p = new AD_Partidos();
                DataTable tabla = p.EstadisticaPartido(txtYear.Text);
                //tabla = socios.BuscarSocioxFecha(txtYear1.Text, txtYear2.Text);
                ReportDataSource datos = new ReportDataSource("DataSet4", tabla);
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RP05", "Cantidad de partidos por club en el año: " + txtYear.Text);
                rv4.LocalReport.SetParameters(parametro);
                rv4.LocalReport.DataSources.Clear();
                rv4.LocalReport.DataSources.Add(datos);
                rv4.RefreshReport();
                txtYear.Text = " ";
                txtYear.Focus();
            }
        }

    }
}
