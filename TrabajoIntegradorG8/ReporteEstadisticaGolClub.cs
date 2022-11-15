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
    public partial class ReporteEstadisticaGolClub : Form
    {
        public ReporteEstadisticaGolClub()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaGolClub_Load(object sender, EventArgs e)
        {

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

      

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            ReportDataSource Datos = new ReportDataSource("DatosClubGol", ObtenerEstadisticaGoles());
            

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);

            reportViewer1.RefreshReport();
        }
    }
}
