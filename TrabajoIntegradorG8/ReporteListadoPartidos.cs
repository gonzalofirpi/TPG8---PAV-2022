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

            this.reportViewerPartidos1.RefreshReport();
        }

        private void reportViewerPartidos1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Partidos.obtenerListadoDePartidos();

            ReportDataSource ds = new ReportDataSource("DatosPartidos", tabla);

            reportViewerPartidos1.LocalReport.DataSources.Clear();
            reportViewerPartidos1.LocalReport.DataSources.Add(ds);
            reportViewerPartidos1.LocalReport.Refresh();

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
                cmbCancha.ValueMember = "COD_PISO";
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
                alcance = "Todos los partidos del año: " + lblAño.Text.ToString() ;
                Tabla = Rpt_partidos01(lblAño.Text);
            }

            if (radioButton2RestrCan.Checked == true)
            {
                alcance = "Todos los partidos con tipo de cancha: " + cmbCancha.Text;
                Tabla = Rpt_partidos01(datos[0].ToString(), datos[1].ToString());
            }
            if (radioButton3RestrFecha.Checked == true)
            {
                alcance = "Rango de fecha, desde: " + maskedTextBoxDesde.Text +" hasta: " + maskedTextBoxHasta.Text;
                Tabla = Rpt_partidos01(txt_restriccion._Text);
            }
        }

        public DataTable Rpt_partidos01(int year)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM PARTIDOS P WHERE getYear(P.FECHA) = @year";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@year", year);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
        public DataTable Rpt_partidos01(string letra)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = @"SELECT id_usuario, n_usuario, apellido, nombres 
                         FROM usuarios WHERE apellido like '" + letra.Trim() + "%'";
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
        public DataTable Rpt_partidos01(string inicio, string final)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = @"SELECT id_usuario, n_usuario, apellido, nombres 
                         FROM usuarios WHERE id_usuario between " + inicio + " AND " + final;
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

       
    }
}
