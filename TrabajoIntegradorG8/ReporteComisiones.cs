using Microsoft.Reporting.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class ReporteComisiones : Form
    {
        DataTable Tabla = new DataTable();
        string alcance = "";
        public ReporteComisiones()
        {
            InitializeComponent();
        }


        private void Restriccion()
        {
            if (radioButtonRestringidoPorFecha.Checked == true)
            {
                alcance = "Todas las comisiones del " + txtFecha.Text;
                Tabla = Rpt_comisionesAño(txtFecha.Text);
            }

            if (radioButtonRestringidoEntreFechas.Checked == true)
            {
                alcance = "Todas las comisiones desde " + txtFechaDesde.Text + " hasta " + txtFechaHasta.Text;
                Tabla = Rpt_comisionesEntreAños(txtFechaDesde.Text, txtFechaHasta.Text);
            }
        }


        public DataTable Rpt_comisionesAño(string year)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM COMISIONES P WHERE convert(varchar(4), Year(P.FECHA_DESDE)) like @year";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@year", year);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;
 
            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }

        public DataTable Rpt_comisionesEntreAños(string year1, string year2)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM COMISIONES P WHERE FECHA_DESDE between @year1 AND @year2";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@year1", year1);
            cmd.Parameters.AddWithValue("@year2", year2);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }

        private void ReporteComisiones_Load(object sender, EventArgs e)
        {

        }

        private void lblRepCanchas_Click(object sender, EventArgs e)
        {

        }

        private void reportViewerCanchas_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRestringidoPorFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Restriccion();

            ReportDataSource Datos = new ReportDataSource("DatosComisiones", Tabla);
            reportViewerComisiones.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoDeComisiones.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("ReportParameter1", alcance);
            reportViewerComisiones.LocalReport.DataSources.Clear();
            reportViewerComisiones.LocalReport.DataSources.Add(Datos);
            reportViewerComisiones.RefreshReport();
        }
    }
}
