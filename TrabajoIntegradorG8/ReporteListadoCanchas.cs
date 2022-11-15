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

namespace TrabajoIntegradorG8
{
    public partial class ReporteListadoCanchas : Form
    {
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteListadoCanchas()
        {
            InitializeComponent();
        }

        private void ReporteListadoCanchas_Load(object sender, EventArgs e)
        {


            this.reportViewerComisiones.RefreshReport();
        }


        private void checkBoxCanchaFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCanchaFecha.Checked == true)
            {
                lblFecha.Visible = true;
                maskedTextBoxFecha.Visible = true;
                btnBuscarCancha.Enabled = true;
            }
        }

        private void Restriccion()
        {
            if (checkBoxCanchaFecha.Checked == true)
            {
                alcance = "Todas las canchas cuyo último mantenimiento fue en la fecha: " + maskedTextBoxFecha.Text;
                Tabla = Rpt_Canchas01(maskedTextBoxFecha.Text);
            }
        }

        public DataTable Rpt_Canchas01(string @inicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM [BD3K3G08_2022].[dbo].[CANCHAS] WHERE FECHA_ULT_MANTENIMIENTO = @inicio";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }

        private void btnBuscarCancha_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maskedTextBoxFecha.Text))
            {
                MessageBox.Show("Ingrese una fecha!");
            }
            else
            {

                Restriccion();

                //ReportDataSource Datos = new ReportDataSource("DatosCanchas", Tabla);
                //reportViewerCanchas.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoDeCanchas.rdlc";
                //ReportParameter[] parametros = new ReportParameter[1];
                //parametros[0] = new ReportParameter("Alcance", alcance);
                //reportViewerCanchas.LocalReport.SetParameters(parametros);
                //reportViewerCanchas.LocalReport.DataSources.Clear();
                //reportViewerCanchas.LocalReport.DataSources.Add(Datos);
                //reportViewerCanchas.RefreshReport();
            }
        }

        private void reportViewerComisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
