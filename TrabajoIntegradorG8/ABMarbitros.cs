using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class ABMarbitros : Form
    {
        private int codArbitro;
        public ABMarbitros()
        {
            InitializeComponent();
        }

        private void AltaArbitro_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ARBITROS";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaArbitros.DataSource = tabla;

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
        private bool agregarArbitroBD(Arbitro arbitro)
        {
           
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ARBITROS (NOMBRE,APELLIDO)" +
                                    "VALUES(@nombreArb,@apellido)";

                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@nombreArb", arbitro.Nombre);
                cmd.Parameters.AddWithValue("@apellido", arbitro.Apellido);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;

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



        private void btnGuardarArbitro_Click(object sender, EventArgs e)
        {
            Arbitro arbitro = obtenerDatosArbitros();

            if (arbitro == null)
            {
                MessageBox.Show("Error, completar todos los datos");
            }
            else
            {
                try
                {


                    if (agregarArbitroBD(arbitro))
                    {
                        MessageBox.Show("Arbitro cargado con exito!!");
                        LimpiarCampos();
                        cargarGrilla();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en acceso a Base de Datos - " + ex.Message);
                    return;
                }


            }
        }

        
        private Arbitro obtenerDatosArbitros()
        {
            Arbitro arbitro = new Arbitro();

            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Arbitro arbitro1 = new Arbitro();

                
                arbitro1.Nombre = txtNombre.Text;
                arbitro1.Apellido = txtApellido.Text;

                return arbitro1;
            }


        }
        private void cargarCampos(Arbitro arbitro)
        {
            txtNombre.Text = arbitro.Nombre;
            txtApellido.Text = arbitro.Apellido;
            

            this.codArbitro = arbitro.Codigo;
        }
        private Arbitro obtenerArbitro(int codArbitro)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Arbitro arbitro = new Arbitro();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * " +
                    "              FROM ARBITROS" +
                    "              WHERE ID_ARBITRO = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codArbitro);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    arbitro.Codigo = int.Parse(dr["ID_ARBITRO"].ToString());
                    arbitro.Nombre = dr["NOMBRE"].ToString();
                    arbitro.Apellido = dr["APELLIDO"].ToString();
                    
                }

                return arbitro;
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
       



        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void grillaArbitros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grillaArbitros.Rows[indice];
            int codArbitro = int.Parse(filaSeleccionada.Cells["idarbitro"].Value.ToString());

            try
            {
                LimpiarCampos();
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = true;
                cargarCampos(obtenerArbitro(codArbitro));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el arbitro - " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Arbitro arbitro = obtenerDatosArbitros();

            try
            {
                if (actualizarArbitro(arbitro))
                {
                    MessageBox.Show("Arbitro actualizado con exito!!");
                    LimpiarCampos();
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el arbitro - " + ex.Message);
            }
        }

        private bool actualizarArbitro(Arbitro arbitro)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ARBITROS" +
                    "              SET NOMBRE = @nombre, APELLIDO = @Apellido"+
                    "               WHERE ID_ARBITRO = @codArbitro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codArbitro", this.codArbitro);
                cmd.Parameters.AddWithValue("@nombre", arbitro.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", arbitro.Apellido);
               

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este arbitro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarArbitro())
                    {
                        MessageBox.Show("arbitro borrado con exito!!");
                        LimpiarCampos();
                        cargarGrilla();
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado dentro de la Base de Datos - " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se eliminara el arbitro");
            }
        }
        private bool borrarArbitro()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM ARBITROS" +
                    "              WHERE ID_ARBITRO = @codArbitro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codArbitro", this.codArbitro);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
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
    }
}
