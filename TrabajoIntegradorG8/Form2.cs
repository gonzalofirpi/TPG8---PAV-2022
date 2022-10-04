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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cargarGrilla();
        }
        private void limpiarCampos()
        {
            txtCodigoCategoria.Text = "";
            txtAgregarCtegoria.Text = "";
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (txtAgregarCtegoria.Text == "" || txtCodigoCategoria.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
            }
            else
            {
                string nombreCategoria = txtAgregarCtegoria.Text;
                int codigoCategoria = int.Parse(txtCodigoCategoria.Text.ToString());

                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string comando = "INSERT INTO CATEGORIAS " +
                        "VALUES (@codigo, @nombre);";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", nombreCategoria);
                    cmd.Parameters.AddWithValue("@codigo", codigoCategoria);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comando;

                    cn.Open();
                    cmd.Connection = cn;

                    int resultado = cmd.EndExecuteNonQuery(cmd.BeginExecuteNonQuery());
                    if (resultado == 0)
                    {
                        MessageBox.Show("Hubo un error.");
                    }
                    else
                    {
                        MessageBox.Show("Categoria creada correctamente.");
                        cargarGrilla();
                    }
                }


                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargarGrilla()
        {
            DataTable tablaCategorias = new DataTable();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string comando = "SELECT COD_CATEGORIA AS 'Codigo Categoria', NOMBRE AS 'Nombre Categoria'" +
                    "FROM CATEGORIAS;";

                cmd.Parameters.Clear();

                cn.Open();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = comando;
                SqlDataReader reader = cmd.ExecuteReader();

                tablaCategorias.Load(reader);

                dgrCategorias.DataSource = tablaCategorias;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
                return;
            }
            DataGridViewRow filaSeleccionada = dgrCategorias.Rows[indice];
            int codCategoria = int.Parse(filaSeleccionada.Cells["Codigo Categoria"].Value.ToString());
            if (MessageBox.Show("¿Desea eliminar esta categoria?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string comando = "DELETE FROM CATEGORIAS WHERE COD_CATEGORIA = @codCategoria";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codCategoria", codCategoria);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = comando;

                    cn.Open();
                    cmd.Connection = cn;

                    int resultado = cmd.EndExecuteNonQuery(cmd.BeginExecuteNonQuery());
                    if (resultado == 0)
                    {
                        MessageBox.Show("Hubo un error.");
                    }
                    else
                    {
                        MessageBox.Show("Categoria eliminada correctamente.");
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                return;
            }
        }
    }
}
