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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cargarGrilla();
            btnBorrarCargo.Enabled = false;
            btnModificarCargo.Enabled = false;
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
                    command.CommandText = "SELECT COD_CARGO AS 'Codigo Cargo', NOMBRE AS 'Nombre' FROM CARGO";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    dgvCargos.DataSource = resultado;
                    btnBorrarCargo.Enabled = false;
                    btnModificarCargo.Enabled = false;
                }
            }
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G08_2022;Persist Security Info=True;User ID=BD3K3G08_2022;Password=CLV08_28041");
        }

        
        
        private void limpiarCampos()
        {
            txtNombreCargo.Text = "";
            txtCodCargo.Text = "";
        }

        

   

      

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            if (txtNombreCargo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCargo.Text;
                limpiarCampos();
                try
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "INSERT INTO CARGO VALUES (@nombre)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nombre", nombre);


                            command.CommandType = CommandType.Text;
                            var categoriaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (categoriaCreada == 1)
                            {
                                MessageBox.Show("Cargo creado correctamente");
                                cargarGrilla();
                                
                            }
                            else
                            {
                                MessageBox.Show("Error, el cargo no pudo ser creado");
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
            btnBorrarCargo.Enabled = false;
            btnModificarCargo.Enabled = false;
        }

        private void btnBorrarCargo_Click(object sender, EventArgs e)
        {
            if (txtNombreCargo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCargo.Text;
                
                limpiarCampos();
                try
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "DELETE FROM CARGO WHERE NOMBRE LIKE @codCategoria";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@codCategoria", nombre);


                            command.CommandType = CommandType.Text;
                            var categoriaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (categoriaCreada == 1)
                            {
                                MessageBox.Show("Cargo borrado correctamente");
                                cargarGrilla();
                                
                            }
                            else
                            {
                                MessageBox.Show("Error, el cargo no pudo ser borrado");
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

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = dgvCargos.Rows[indice];

            txtNombreCargo.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtCodCargo.Text = filaSeleccionada.Cells["Codigo Cargo"].Value.ToString();
            int codigoCargo = int.Parse(filaSeleccionada.Cells["Codigo Cargo"].Value.ToString());

            btnBorrarCargo.Enabled = true;
            btnModificarCargo.Enabled = true;
        }

        private void btnModificarCargo_Click(object sender, EventArgs e)
        {
            
            if (txtNombreCargo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                //limpiarCampos();
            }
            else
            {
                string nombre = txtNombreCargo.Text;
                int codigo = int.Parse(txtCodCargo.Text);
                //limpiarCampos();

                try
                {
                    using (var connection = GetConnection())
                    {

                        connection.Open();
                        using (var command = new SqlCommand())
                        {

                            command.Connection = connection;
                            command.CommandText = "UPDATE CARGO SET NOMBRE = @nombre WHERE COD_CARGO = @cod_cargo";
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@cod_cargo", codigo);

                            command.CommandType = CommandType.Text;
                            var resultado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                            if (resultado == 1)
                            {
                                MessageBox.Show("Cargo actualizado");
                                cargarGrilla();
                                limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("Error, no se pudo actualizar el cargo");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
