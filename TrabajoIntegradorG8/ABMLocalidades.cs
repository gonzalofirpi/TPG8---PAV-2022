using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorG8
{
    public partial class ABMLocalidades : Form
    {
        private int codLocalidad;
        public ABMLocalidades()
        {
            InitializeComponent();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombreLocalidad.Text = "";
        }



        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT L.COD_LOCALIDAD, L.NOMBRE" +
                    "              FROM LOCALIDAD L";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdLocalidades.DataSource = tabla;

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

        private bool existeLocalidad(string localidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT L.NOMBRE" +
                    "              FROM LOCALIDAD L" +
                    "              WHERE UPPER(L.NOMBRE) LIKE UPPER(@localidad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@localidad", localidad);

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

        private Localidad obtenerDatosLocalidad()
        {
            Localidad localidad = new Localidad();

            if (txtNombreLocalidad.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Localidad localidad1 = new Localidad();

                localidad.Nombre = txtNombreLocalidad.Text;

                return localidad;
            }


        }


        private bool agregarLocalidadBD(Localidad localidad)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO LOCALIDAD(NOMBRE)" +
                    "              VALUES(@nombre)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", localidad.Nombre);


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

        private Localidad obtenerLocalidad(int codLocalidad)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Localidad localidad = new Localidad();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT L.*" +
                    "              FROM LOCALIDAD L" +
                    "              WHERE L.COD_LOCALIDAD = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codLocalidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    localidad.Codigo = int.Parse(dr["COD_LOCALIDAD"].ToString());
                    localidad.Nombre = dr["NOMBRE"].ToString();
                }

                return localidad;
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

        private void cargarCampos(Localidad localidad)
        {
            txtNombreLocalidad.Text = localidad.Nombre;

            this.codLocalidad = localidad.Codigo;
        }

        private bool actualizarLocalidad(Localidad localidad)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE LOCALIDAD" +
                    "              SET NOMBRE = @nombre" +
                    "              WHERE COD_LOCALIDAD = @codLocalidad";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", this.codLocalidad);
                cmd.Parameters.AddWithValue("@nombre", localidad.Nombre);

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


        private bool borrarLocalidad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM LOCALIDAD" +
                    "              WHERE COD_LOCALIDAD = @codLocalidad";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codLocalidad", this.codLocalidad);

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



        private void ABMLocalidades_Load_1(object sender, EventArgs e)
        {
            limpiarCampos();

            try
            {
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos - " + ex.Message);
            }
        }

        private void btnGuardarLoc_Click_1(object sender, EventArgs e)
        {
            try
            {
                Localidad localidad = obtenerDatosLocalidad();

                if (localidad == null)
                {
                    MessageBox.Show("Error, completar todos los datos");
                }
                else
                {
                    try
                    {
                        if (existeLocalidad(localidad.Nombre))
                        {
                            MessageBox.Show("Error, localidad no valida");
                            return;

                        }
                        else
                        {
                            if (agregarLocalidadBD(localidad))
                            {
                                MessageBox.Show("Localidad cargada con exito!!");
                                limpiarCampos();
                                cargarGrilla();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en acceso a Base de Datos - " + ex.Message);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato - " + ex.Message);
            }
        }

        private void btnActualizarLoc_Click_1(object sender, EventArgs e)
        {
            try
            {
                Localidad localidad = obtenerDatosLocalidad();

                try
                {
                    if (actualizarLocalidad(localidad))
                    {
                        MessageBox.Show("Localidad actualizada con exito!!");
                        limpiarCampos();
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la localidad - " + ex.Message);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato -" + ex.Message);
            }
        }

        private void btnBorrarLoc_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar esta localidad?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarLocalidad())
                    {
                        MessageBox.Show("Localidad borrada con exito!!");
                        limpiarCampos();
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
                MessageBox.Show("No se eliminara la localidad");
            }
        }

        private void grdLocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdLocalidades.Rows[indice];
            int codLocalidad = int.Parse(filaSeleccionada.Cells["codigoLoc"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarLoc.Enabled = true;
                btnBorrarLoc.Enabled = true;
                cargarCampos(obtenerLocalidad(codLocalidad));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el barrio - " + ex.Message);
            }
        }
    }
}
