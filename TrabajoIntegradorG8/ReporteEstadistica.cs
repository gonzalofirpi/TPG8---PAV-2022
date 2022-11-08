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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class ReporteEstadistica : Form
    {
        public ReporteEstadistica()
        {
            InitializeComponent();
        }

        private void ReporteEstadistica_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public DataTable ObtenerEstadisticaGoles()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT S.NOMBRE, count(T.COD_OBSERVACION) AS GOLES FROM SOCIOS S JOIN OBSERVACIONESXPARTIDO O ON (S.ID_SOCIO = O.ID_SOCIO )" 
                + "JOIN TIPO_OBSERVACIONES T ON (T.COD_OBSERVACION = O.COD_OBSERVACION)" 
                + "WHERE T.COD_OBSERVACION = 1 AND S.ID_SOCIO = O.ID_SOCIO AND (YEAR(GETDATE()) - YEAR(O.FECHA)) < 2"
                + "GROUP BY S.NOMBRE";


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
            ReportDataSource Datos = new ReportDataSource("DatosEstadisticaGolesdeClub", ObtenerEstadisticaGoles());
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaGolesClubJ.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);

            reportViewer1.RefreshReport();
        }
    }
}
