using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoIntegradorG8.AccesoADatos;

namespace TrabajoIntegradorG8.Reportes
{
    public partial class ReporteSocio : Form
    {
        //private object reportViewer1;
        
        public ReporteSocio()
        {
            InitializeComponent();
            
        }

        private void ReporteSocio_Load(object sender, EventArgs e)
        {


            this.rv1.RefreshReport();

            this.rv2.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtYear1.Text.Length == 0 || txtYear2.Text.Length == 0)
            {

                MessageBox.Show("Ingrese dos fechas para comparar", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                String x = txtYear1.Text;
                String a = txtYear2.Text;
                int b = Int32.Parse(x);
                int c = Int32.Parse(a);
                if (b > c)
                {
                    MessageBox.Show("El Año Hasta desde ser mayor que el Año Desde....ingrese de nuevo las fechas", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    txtYear1.Focus();
                }
                else
                {


                    AD_Socios socios = new AD_Socios();
                    DataTable tabla = socios.BuscarSocioxFecha(txtYear1.Text, txtYear2.Text);
                    //tabla = socios.BuscarSocioxFecha(txtYear1.Text, txtYear2.Text);
                    ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
                    rv1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.Reportes.ReportSocios.rdlc";
                    ReportParameter[] parametro = new ReportParameter[1];
                    parametro[0] = new ReportParameter("RP01", "Los socios con fecha de alta entre el año " + txtYear1.Text + " y " + txtYear2.Text+ " son: ");
                    rv1.LocalReport.SetParameters(parametro);
                    rv1.LocalReport.DataSources.Clear();
                    rv1.LocalReport.DataSources.Add(datos);
                    rv1.RefreshReport();
                    Limpiar();
                    txtYear1.Focus();
                }
            }
            
            

        }

        private void Limpiar()
        {
            txtYear1.Text = " ";
            txtYear2.Text = " ";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        


                    AD_Socios socios = new AD_Socios();
                    DataTable tabla = socios.BuscarSocioXapellido();
                    //tabla = socios.BuscarSocioxFecha(txtYear1.Text, txtYear2.Text);
                    ReportDataSource datos = new ReportDataSource("DataSet2", tabla);
                    rv2.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.Reportes.ReportSocioApellido.rdlc";
                    ReportParameter[] parametro = new ReportParameter[1];
                    parametro[0] = new ReportParameter("RP02", "Listado de socios ordenados alfabeticamente: ");
                    rv2.LocalReport.SetParameters(parametro);
                    rv2.LocalReport.DataSources.Clear();
                    rv2.LocalReport.DataSources.Add(datos);
                    rv2.RefreshReport();
                    
                
            

            

        }
        
    }
}
