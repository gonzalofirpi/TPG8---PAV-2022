using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoIntegradorG8.AccesoADatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class frmReporteListadoClubesOrdenados : Form
    {
        DataTable Tabla = new DataTable();
        public frmReporteListadoClubesOrdenados()
        {
            InitializeComponent();
        }

        private void frmReporteListadoClubesOrdenados_Load(object sender, EventArgs e)
        {

            
            
        }


        public void cargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM BARRIO";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrios.DataSource = tabla;
                cmbBarrios.DisplayMember = "NOMBRE";
                cmbBarrios.ValueMember = "COD_BARRIO";
                cmbBarrios.SelectedIndex = -1;

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

        private void rdbtnBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnBarrio.Checked == true)
            {
                lblBarrio.Enabled = true;
                cmbBarrios.Enabled = true;
                cargarComboBarrios();
            }
            
        }
        private void rdbtnAntiguedad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnAntiguedad.Checked == true)

            {
                lblBarrio.Enabled = false;
                cmbBarrios.Enabled = false;
            }
        }
        private void Restriccion()
        {
            if (rdbtnBarrio.Checked == true)
            {
                
                
                int barrio = Convert.ToInt32(cmbBarrios.SelectedValue.ToString());
                Tabla = Rpt_Clubes01(barrio);
            }
            if (rdbtnAntiguedad.Checked == true)
            {
                

                Tabla = Rpt_Clubes01FECHA();
            }

        }
        public DataTable Rpt_Clubes01(int barrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM CLUBES C JOIN BARRIO B ON (C.COD_BARRIO = B.COD_BARRIO) WHERE B.COD_BARRIO = @barrio";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@barrio", barrio);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }
        public DataTable Rpt_Clubes01FECHA()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM CLUBES ORDER BY FECHA_FUNDACION";

            
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


            ReportDataSource Datos = new ReportDataSource("DATOSCLUBES", Tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoDeClubes.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            
            reportViewer1.RefreshReport();


        }
    }
}
