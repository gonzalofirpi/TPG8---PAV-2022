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
using Microsoft.Reporting.WinForms;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadisticaFastGol : Form
    {
        public ReporteEstadisticaFastGol()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaFastGol_Load(object sender, EventArgs e)
        {

            
        }
        public DataTable ObtenerEstadisticaFastGoles()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT S.NOMBRE ,O.MINUTO FROM OBSERVACIONESXPARTIDO O JOIN SOCIOS S ON (O.ID_SOCIO = S.ID_SOCIO) GROUP BY S.NOMBRE , O.MINUTO ORDER BY O.MINUTO\r\n\r\n\r\n";


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource Datos = new ReportDataSource("EstadisticaFastGol", ObtenerEstadisticaFastGoles());
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaGol.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);

            reportViewer1.RefreshReport();
        }
    }
}
