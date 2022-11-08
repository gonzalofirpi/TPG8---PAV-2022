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
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8
{
    public partial class EstadisticaTipoCancha : Form
    {
        public EstadisticaTipoCancha()
        {
            InitializeComponent();
        }

        private void EstadisticaTipoCancha_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public static DataTable obtenerEstadisticaCanchasTipo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT T.NOMBRE, COUNT(C.COD_PISO) AS cantidad FROM CANCHAS C JOIN TIPO_PISO T ON (C.COD_PISO = T.COD_PISO) GROUP BY T.NOMBRE";
   
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = obtenerEstadisticaCanchasTipo();

            ReportDataSource ds = new ReportDataSource("TiposCancha", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            //reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
