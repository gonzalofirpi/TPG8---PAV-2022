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
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8
{
    public partial class ReporteListadoPartidos : Form
    {
        DataTable Tabla = new DataTable();
        string alcance = "";

        public ReporteListadoPartidos()
        {
            InitializeComponent();
        }

        private void ReporteListadoPartidos_Load(object sender, EventArgs e)
        {

            
        }


        private void radioButton1PartAño_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1PartAño.Checked == true)
            {
                lblAño.Visible = true;
                maskedTextBoxAño.Visible = true;
            }
        }

        private void radioButton2RestrCan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2RestrCan.Checked == true)
            {
                cargarComboTipoPiso();
                lblTipoCancha.Visible = true;
                cmbCancha.Visible = true;
            }
        }

        private void radioButton3RestrFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3RestrFecha.Checked == true)
            {
                lblFechaDesde.Visible = true;
                lblFechaHasta.Visible = true;
                maskedTextBoxDesde.Visible = true;
                maskedTextBoxHasta.Visible = true;
            }
        }

        public void cargarComboTipoPiso()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM TIPO_PISO";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCancha.DataSource = tabla;
                cmbCancha.DisplayMember = "NOMBRE";
                cmbCancha.ValueMember = "NOMBRE";
                cmbCancha.SelectedIndex = -1;

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

        private void Restriccion()
        {
            if (radioButton1PartAño.Checked == true)
            {
                alcance = "Todos los partidos del año: " + maskedTextBoxAño.Text;
                Tabla = Rpt_partidos01A(maskedTextBoxAño.Text);
            }

            if (radioButton2RestrCan.Checked == true)
            {
                alcance = "Todos los partidos con tipo de cancha: " + cmbCancha.Text;
                Tabla = Rpt_partidos01(cmbCancha.Text);
            }
            if (radioButton3RestrFecha.Checked == true)
            {
                alcance = "Rango de fecha, desde: " + maskedTextBoxDesde.Text +" hasta: " + maskedTextBoxHasta.Text;
                Tabla = Rpt_partidos01(maskedTextBoxDesde.Text, maskedTextBoxHasta.Text);
            }
        }

        public DataTable Rpt_partidos01A(string year)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM PARTIDOS P WHERE convert(varchar(4), Year(P.FECHA)) like @year";

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
        public DataTable Rpt_partidos01(string tipo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM PARTIDOS P JOIN CANCHAS C ON (P.NRO_CANCHA = C.NRO_CANCHA) JOIN TIPO_PISO T ON (C.COD_PISO = T.COD_PISO) WHERE T.NOMBRE LIKE @tipo" ;
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }
        public DataTable Rpt_partidos01(string @inicio, string @final)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM PARTIDOS WHERE FECHA between @inicio AND @final";
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Restriccion();

            ReportDataSource Datos = new ReportDataSource("DatosPartidos", Tabla);
            reportViewerPartidos1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoDePartidos.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("ReportParameter1", alcance);
            reportViewerPartidos1.LocalReport.SetParameters(parametros);
            reportViewerPartidos1.LocalReport.DataSources.Clear();
            reportViewerPartidos1.LocalReport.DataSources.Add(Datos);
            reportViewerPartidos1.RefreshReport();
        }
    }
}
