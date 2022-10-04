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
            btnBorrarCategoria.Enabled = false;
            btnModificarCategoria.Enabled = false;
        }
        public void cargarGrilla()
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COD_CATEGORIA AS 'Codigo Categoria', NOMBRE AS 'Nombre' FROM CATEGORIAS";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    dgvCategorias.DataSource = resultado;
                    btnBorrarCategoria.Enabled = false;
                    btnModificarCategoria.Enabled = false;
                }
            }
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G08_2022;Persist Security Info=True;User ID=BD3K3G08_2022;Password=CLV08_28041");
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCategoria.Text;

                limpiarCampos();
                try
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "INSERT INTO CATEGORIAS VALUES (@nombre)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nombre", nombre);


                            command.CommandType = CommandType.Text;
                            var categoriaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (categoriaCreada == 1)
                            {
                                MessageBox.Show("Categoria creada correctamente");
                                cargarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, la categoria no pudo ser creada");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                //limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCategoria.Text;
                int codigo = int.Parse(txtCodCategoria.Text);

                try
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "UPDATE CATEGORIAS SET NOMBRE = @nombre WHERE COD_CATEGORIA = @cod_categoria";
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@cod_categoria", codigo);

                            command.CommandType = CommandType.Text;
                            var resultado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (resultado == 1)
                            {
                                MessageBox.Show("Categoria actualizada");
                                cargarGrilla();
                                limpiarCampos();

                            }
                            else
                            {
                                MessageBox.Show("Error, no se pudo actualizar la categoria");
                                limpiarCampos();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void limpiarCampos()
        {
            txtNombreCategoria.Text = "";
            txtCodCategoria.Text = "";
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = dgvCategorias.Rows[indice];;
            txtNombreCategoria.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtCodCategoria.Text = filaSeleccionada.Cells["Codigo Categoria"].Value.ToString();
            int codigoCargo = int.Parse(filaSeleccionada.Cells["Codigo Categoria"].Value.ToString());

            btnBorrarCategoria.Enabled = true;
            btnModificarCategoria.Enabled = true;
        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCategoria.Text;
                limpiarCampos();

                try
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "DELETE FROM CATEGORIAS WHERE NOMBRE LIKE @codCategoria";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@codCategoria", nombre);


                            command.CommandType = CommandType.Text;
                            var categoriaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (categoriaCreada == 1)
                            {
                                MessageBox.Show("Categoria borrada correctamente");
                                cargarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, la categoria no pudo ser borrada");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnBorrarCategoria .Enabled = false;
            btnModificarCategoria.Enabled = false;
        }

    }
}
