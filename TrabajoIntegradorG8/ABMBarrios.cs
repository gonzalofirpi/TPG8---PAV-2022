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
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class frmBarrios : Form
    {

        private int codBarrio;
        public frmBarrios()
        {
            InitializeComponent();
        }

        private void frmBarrios_Load(object sender, EventArgs e)
        {

            limpiarCampos();

            try
            {
                cargarComboLocalidades();
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos - " + ex.Message);
            }
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            cmbLocalidades.SelectedIndex = -1;
            txtCodPostal.Text = "";

            txtNombre.Focus();
            this.codBarrio = 0;

            btnBorrarBarrio.Enabled = false;
            btnActualizarBarrio.Enabled = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        public void cargarComboLocalidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT L.*" +
                    "              FROM LOCALIDAD L";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbLocalidades.DataSource = tabla;
                cmbLocalidades.DisplayMember = "NOMBRE";
                cmbLocalidades.ValueMember = "COD_LOCALIDAD";
                cmbLocalidades.SelectedIndex = -1;

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

        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT B.COD_BARRIO, B.NOMBRE, L.NOMBRE AS LOCALIDAD, B.COD_POSTAL" +
                    "              FROM BARRIO B INNER JOIN LOCALIDAD L ON (B.COD_LOCALIDAD = L.COD_LOCALIDAD)";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdBarrios.DataSource = tabla;

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

        private bool existeCodigoPostal(int codPostal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CP.COD_POSTAL" +
                    "              FROM CODIGO_POSTAL CP" +
                    "              WHERE CP.COD_POSTAL = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codPostal);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return true;
                }
                else
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

        }

        private Barrio obtenerDatosBarrio()
        {
            Barrio barrio = new Barrio();

            if (txtNombre.Text.Equals("") || (int)cmbLocalidades.SelectedValue == -1 || txtCodPostal.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Barrio barrio1 = new Barrio();

                barrio.Nombre = txtNombre.Text;
                barrio.Localidad = (int)cmbLocalidades.SelectedValue;
                barrio.CodPostal = int.Parse(txtCodPostal.Text);

                return barrio;
            }


        }

        private void btnGuardarBarrio_Click(object sender, EventArgs e)
        {

            Barrio barrio = obtenerDatosBarrio();

            if (barrio == null)
            {
                MessageBox.Show("Error, completar todos los datos");
            }
            else
            {
                try
                {
                    if (existeCodigoPostal(barrio.CodPostal))
                    {

                        if (agregarBarrioBD(barrio))
                        {
                            MessageBox.Show("Barrio cargado con exito!!");
                            limpiarCampos();
                            cargarComboLocalidades();
                            cargarGrilla();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error, codigo postal no valido");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en acceso a Base de Datos - " + ex.Message);
                    return;
                }

            }

        }

        private bool agregarBarrioBD(Barrio barrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO BARRIO(NOMBRE, COD_LOCALIDAD, COD_POSTAL)" +
                    "              VALUES(@nombre, @codLocalidad, @codPostal)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", barrio.Nombre);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.Localidad);
                cmd.Parameters.AddWithValue("@codPostal", barrio.CodPostal);

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

        private Barrio obtenerBarrio(int codBarrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio barrio = new Barrio();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT B.*" +
                    "              FROM BARRIO B" +
                    "              WHERE B.COD_BARRIO = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codBarrio);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    barrio.Codigo = int.Parse(dr["COD_BARRIO"].ToString());
                    barrio.Nombre = dr["NOMBRE"].ToString();
                    barrio.Localidad = int.Parse(dr["COD_LOCALIDAD"].ToString());
                    barrio.CodPostal = int.Parse(dr["COD_POSTAL"].ToString());
                }

                return barrio;
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
        
        private void cargarCampos(Barrio barrio)
        {
            txtNombre.Text = barrio.Nombre;
            cmbLocalidades.SelectedValue = barrio.Localidad;
            txtCodPostal.Text = barrio.CodPostal.ToString();

            this.codBarrio = barrio.Codigo;
        }

        private void grdBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdBarrios.Rows[indice];
            int codBarrio = int.Parse(filaSeleccionada.Cells["codigo"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarBarrio.Enabled = true;
                btnBorrarBarrio.Enabled = true;
                cargarCampos(obtenerBarrio(codBarrio));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el barrio - " + ex.Message);
            }
        }

        private bool actualizarBarrio(Barrio barrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE BARRIO" +
                    "              SET NOMBRE = @nombre, COD_LOCALIDAD = @codLocalidad, COD_POSTAL = @codPostal" +
                    "              WHERE COD_BARRIO = @codBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", this.codBarrio);
                cmd.Parameters.AddWithValue("@nombre", barrio.Nombre);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.Localidad);
                cmd.Parameters.AddWithValue("@codPostal", barrio.CodPostal);

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

        private void btnActualizarBarrio_Click(object sender, EventArgs e)
        {
            Barrio barrio = obtenerDatosBarrio();

            try
            {
                if (actualizarBarrio(barrio))
                {
                    MessageBox.Show("Barrio actualizado con exito!!");
                    limpiarCampos();
                    cargarComboLocalidades();
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el barrio - " + ex.Message);
            }
        }

        private bool borrarBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM BARRIO" +
                    "              WHERE COD_BARRIO = @codBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", this.codBarrio);

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

        private void btnBorrarBarrio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este barrio?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarBarrio())
                    {
                        MessageBox.Show("Barrio borrado con exito!!");
                        limpiarCampos();
                        cargarGrilla();
                        cargarComboLocalidades();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado dentro de la Base de Datos - " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se eliminara el barrio");
            }



        }
    }
    

}
   


