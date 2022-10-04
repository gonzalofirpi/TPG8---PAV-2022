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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                if (validarUsuario(txtUsuario.Text, txtPassword.Text))
                {

                    frmPrincipal ventana = new frmPrincipal();
                    ventana.Show();
                    this.Hide();

                } else
                {
                    MessageBox.Show("Error, datos incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el acceso a Base de Datos - Contacte al administrador nsurghy@gmail.com" + ex.Message);
            }
            
        }

        private bool validarUsuario(string nombreUsuario, string password)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT U.*" +
                    "              FROM USUARIOS U" +
                    "              WHERE U.nombreUsuario LIKE @nombreUsu AND U.password LIKE @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreUsuario);
                cmd.Parameters.AddWithValue("@pass", password);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    return true;

                } else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
            
            return false;
        }
    }
}
