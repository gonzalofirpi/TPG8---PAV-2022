﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class frmClubes : Form
    {

        private int idClub;

        public frmClubes()
        {
            InitializeComponent();
        }

        private void frmClubes_Load(object sender, EventArgs e)
        {
            limpiarCampos();

            try
            {
                cargarComboBarrios();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en acceso a Base de Datos - " + ex.Message);
            }
        }

        private void limpiarCampos()
        {


            txtNombre.Text = "";
            txtNroCuit.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrios.SelectedIndex = -1;
            txtFechaFundacion.Text = "";

            txtNombre.Focus();
            this.idClub = 0;

            btnBorrarClub.Enabled = false;
            btnActualizarClub.Enabled = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private Club obtenerDatosClub()
        {
            Club club = new Club();


            if (txtNombre.Text.Equals("") || txtNroCuit.Text.Equals("") || txtCalle.Text.Equals("") || txtNroCalle.Text.Equals("") || (int)cmbBarrios.SelectedValue == -1 || txtFechaFundacion.Text.Equals(""))
            {
                return null;
            }
            else
            {
                club.Nombre = txtNombre.Text;
                club.NroCuit = long.Parse(txtNroCuit.Text);
                club.Calle = txtCalle.Text;
                club.NroCalle = int.Parse(txtNroCalle.Text);
                club.Barrio = (int)cmbBarrios.SelectedValue;
                club.FechaFundacion = DateTime.Parse(txtFechaFundacion.Text);

                return club;

            }
            
        }

        private void btnGuardarClub_Click(object sender, EventArgs e)
        {

            Club club = obtenerDatosClub();


            if (club == null)
            {
                MessageBox.Show("Error, completar todos los datos");
            }
            else if (existeEnGrilla(club.NroCuit))
            {
                MessageBox.Show("Error, ya existe un club con el número de CUIT: " + club.NroCuit);
            }
            else
            {
                try
                {
                    if (agregarClubBD(club))
                    {
                        MessageBox.Show("Club cargado con exito!!");
                        limpiarCampos();
                        cargarComboBarrios();
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

        private bool agregarClubBD(Club club)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CLUBES(NOMBRE, NROCUIT, CALLE, NRO_CALLE, COD_BARRIO, FECHA_FUNDACION)" +
                    "              VALUES(@nombre, @nroCuit, @calle, @nroCalle, @barrio, @fechaFundacion)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", club.Nombre);
                cmd.Parameters.AddWithValue("@nroCuit", club.NroCuit);
                cmd.Parameters.AddWithValue("@calle", club.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", club.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", club.Barrio);
                cmd.Parameters.AddWithValue("@fechaFundacion", club.FechaFundacion);

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

        public void cargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT B.*" +
                    "              FROM BARRIO B";

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

       /* private bool existeCuit(long nroCuit)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT C.NROCUIT" +
                    "              FROM CLUBES C" +
                    "              WHERE C.NROCUIT = @cuit";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", nroCuit);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
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
        }*/
        private bool existeEnGrilla(long criterioBuscar)
        {

            for (int i = 0; i < grdClubes.Rows.Count; i++)
            {
                if (grdClubes.Rows[i].Cells["nroCuit"].Value.Equals(criterioBuscar))
                {
                    return true;
                }

            }

            return false;
        }

        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT C.NOMBRE, C.NROCUIT, C.CALLE, C.NRO_CALLE, B.NOMBRE AS BARRIO, C.FECHA_FUNDACION" +
                    "              FROM CLUBES C INNER JOIN BARRIO B ON (C.COD_BARRIO = B.COD_BARRIO)";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdClubes.DataSource = tabla;

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

        private Club obtenerClub(long nroCuit)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Club club = new Club();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT C.*" +
                    "              FROM CLUBES C" +
                    "              WHERE C.NROCUIT = @cuit";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", nroCuit);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    club.Id = int.Parse(dr["ID_CLUB"].ToString());
                    club.Nombre = dr["NOMBRE"].ToString();
                    club.NroCuit = long.Parse(dr["NROCUIT"].ToString());
                    club.Calle = dr["CALLE"].ToString();
                    club.NroCalle = int.Parse(dr["NRO_CALLE"].ToString());
                    club.Barrio = int.Parse(dr["COD_BARRIO"].ToString());
                    club.FechaFundacion = DateTime.Parse(dr["FECHA_FUNDACION"].ToString());
                }

                return club;
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

        private void cargarCampos(Club club)
        {
            txtNombre.Text = club.Nombre;
            txtNroCuit.Text = club.NroCuit.ToString();
            txtCalle.Text = club.Calle;
            txtNroCalle.Text = club.NroCalle.ToString();
            cmbBarrios.SelectedValue = club.Barrio;

            DateTime fecha = club.FechaFundacion;
            string dia = fecha.Date.Day.ToString();
            string mes = fecha.Date.Month.ToString();
            string año = fecha.Date.Year.ToString();

            if (dia.Length == 1)
            {
                dia = 0 + dia;
            }
            if (mes.Length == 1)
            {
                mes = 0 + mes;
            }

            txtFechaFundacion.Text = dia + mes + año;

            this.idClub = club.Id;
        }

        private void grdClubes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdClubes.Rows[indice];
            long cuit = long.Parse(filaSeleccionada.Cells["nroCuit"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarClub.Enabled = true;
                btnBorrarClub.Enabled = true;
                cargarCampos(obtenerClub(cuit));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el club - " + ex.Message);
            }
        }

        private bool actualizarClub(Club club)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CLUBES" +
                    "              SET NOMBRE = @nombre, NROCUIT = @nroCuit, CALLE = @calle, NRO_CALLE = @nroCalle," +
                    "                  COD_BARRIO = @codBarrio, FECHA_FUNDACION = @fechaFundacion " +
                    "              WHERE ID_CLUB = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", this.idClub);
                cmd.Parameters.AddWithValue("@nombre", club.Nombre);
                cmd.Parameters.AddWithValue("@nroCuit", club.NroCuit);
                cmd.Parameters.AddWithValue("@calle", club.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", club.NroCalle);
                cmd.Parameters.AddWithValue("@codBarrio", club.Barrio);
                cmd.Parameters.AddWithValue("@fechaFundacion", club.FechaFundacion);

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

        private void btnActualizarClub_Click(object sender, EventArgs e)
        {

            Club club = obtenerDatosClub();

            try
            {
                if (actualizarClub(club))
                {
                    MessageBox.Show("Club actualizado con exito!!");
                    limpiarCampos();
                    cargarComboBarrios();
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el club - " + ex.Message);
            }
        }

        private bool borrarClub()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM CLUBES" +
                    "              WHERE ID_CLUB = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", this.idClub);

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

        private void btnBorrarClub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este club?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarClub())
                    {
                        MessageBox.Show("Club borrado con exito!!");
                        limpiarCampos();
                        cargarGrilla();
                        cargarComboBarrios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado dentro de la Base de Datos - " + ex.Message);
                }
            } else
            {
                MessageBox.Show("No se eliminara el club");
            }

        }
    }
    
}
