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
    public partial class ABMComisiones : Form
    {
        public ABMComisiones()
        {
            InitializeComponent();
        }

        // LIMPIAR CAMPOS

        private void btnLimpiarCamposCom_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            cmbClub.SelectedIndex = -1;
            txtFechaInicioCom.Text = "";
            txtFechaFinCom.Text = "";
            txtVocal1.Text = "";
            txtVocal2.Text = "";
            txtVocal3.Text = "";
            txtPresi.Text = "";
            txtSecre.Text = "";
            txtTesorero.Text = "";

            cmbClub.Focus();

            btnBorrarCom.Enabled = false;
            btnActualizarCom.Enabled = false;
        }

        // CARGAR COMBOS

        public void cargarComboClub()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT C.*" +
                    "              FROM CLUBES C";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbClub.DataSource = tabla;
                cmbClub.DisplayMember = "NOMBRE";
                cmbClub.ValueMember = "ID_CLUB";
                cmbClub.SelectedIndex = -1;

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

        // CARGA DE VENTANA

        private void ABMComisiones_Load(object sender, EventArgs e)
        {
            limpiarCampos();

            try
            {
                cargarComboClub();
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos - " + ex.Message);
            }
        }

        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CO.FECHA_DESDE, CO.FECHA_HASTA, C.NOMBRE AS CLUB, C.ID_CLUB AS IDCLUB" +
                    "              FROM COMISIONES CO INNER JOIN CLUBES C ON (CO.ID_CLUB = C.ID_CLUB)";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdCom.DataSource = tabla;

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

        // ALTA

        private Comision obtenerDatosComision()
        {
            Comision comision = new Comision();


            if (txtFechaInicioCom.Text.Equals("") || txtVocal1.Text.Equals("") || txtVocal2.Text.Equals("") || txtVocal3.Text.Equals("") || (int)cmbClub.SelectedValue == -1 || txtPresi.Text.Equals("") || txtSecre.Text.Equals("") || txtTesorero.Text.Equals(""))
            {
                return null;
            }
            else
            {
                comision.FechaDesde = DateTime.Parse(txtFechaInicioCom.Text);
                comision.FechaHasta = DateTime.Parse(txtFechaFinCom.Text);
                comision.IdVocal1 = int.Parse(txtVocal1.Text);
                comision.IdVocal2 = int.Parse(txtVocal2.Text);
                comision.IdVocal3 = int.Parse(txtVocal3.Text);
                comision.IdPresidente = int.Parse(txtPresi.Text);
                comision.IdSecretario = int.Parse(txtSecre.Text);
                comision.IdTesorero = int.Parse(txtTesorero.Text);
                comision.IdClub = (int)cmbClub.SelectedValue;

                return comision;

            }

        }

        private void btnGuardarCom_Click(object sender, EventArgs e)
        {
            Comision comision = obtenerDatosComision();


            if (comision == null)
            {
                MessageBox.Show("Error, completar todos los datos");
            }
            else 
            {
                try
                {
                    if (existeComision(comision.IdClub, comision.FechaDesde))
                    {
                        MessageBox.Show("Error, ya existe una comision con los datos ingresados");
                        return;
                    }
                    else
                    {
                        if (agregarComisionBD(comision))
                        {
                            MessageBox.Show("Comision cargada con exito!!");
                            limpiarCampos();
                            cargarComboClub();
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
        private bool existeComision(int idClub, DateTime fechaInicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CO.FECHA_DESDE, CO.ID_CLUB" +
                    "              FROM COMISIONES CO" +
                    "              WHERE CO.ID_CLUB = @idClub AND CO.FECHA_DESDE = @fechaDesde";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idClub", idClub);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaInicio);

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

        private bool agregarComisionBD(Comision comision)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO COMISIONES(ID_CLUB, FECHA_DESDE, FECHA_HASTA, ID_VOCAL1, ID_VOCAL2, ID_VOCAL3, ID_PRESIDENTE, ID_TESORERO, ID_SECRETARIO)" +
                    "              VALUES(@idclub, @fechaDesde, @fechaHasta, @idVocal1, @idVocal2, @idVocal3, @idPresidente, @idSecretario, @idTesorero)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idclub", comision.IdClub);
                cmd.Parameters.AddWithValue("@fechaDesde", comision.FechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", comision.FechaHasta);
                cmd.Parameters.AddWithValue("@idVocal1", comision.IdVocal1);
                cmd.Parameters.AddWithValue("@idVocal2", comision.IdVocal2);
                cmd.Parameters.AddWithValue("@idVocal3", comision.IdVocal3);
                cmd.Parameters.AddWithValue("@idPresidente", comision.IdPresidente);
                cmd.Parameters.AddWithValue("@idSecretario", comision.IdSecretario);
                cmd.Parameters.AddWithValue("@idTesorero", comision.IdTesorero);


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

        // ACTUALIZACION

        private Comision obtenerComision(int idclub, DateTime fechaDesde)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Comision comision = new Comision();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT CO.*" +
                    "              FROM COMISIONES CO" +
                    "              WHERE CO.ID_CLUB = @idclub AND CO.FECHA_DESDE = @fechaDesde";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idclub", idclub);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    comision.IdClub = int.Parse(dr["ID_CLUB"].ToString());
                    comision.FechaDesde = DateTime.Parse(dr["FECHA_DESDE"].ToString());
                    comision.FechaHasta = DateTime.Parse(dr["FECHA_HASTA"].ToString());
                    comision.IdVocal1 = int.Parse(dr["ID_VOCAL1"].ToString());
                    comision.IdVocal2 = int.Parse(dr["ID_VOCAL2"].ToString());
                    comision.IdVocal3 = int.Parse(dr["ID_VOCAL3"].ToString());
                    comision.IdPresidente = int.Parse(dr["ID_PRESIDENTE"].ToString());
                    comision.IdSecretario = int.Parse(dr["ID_SECRETARIO"].ToString());
                    comision.IdTesorero = int.Parse(dr["ID_TESORERO"].ToString());

                }

                return comision;
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

        private void cargarCampos(Comision comision)
        {
   
            txtVocal1.Text = comision.IdVocal1.ToString();
            txtVocal2.Text = comision.IdVocal2.ToString();
            txtVocal3.Text = comision.IdVocal3.ToString();
            txtPresi.Text = comision.IdPresidente.ToString();
            txtSecre.Text = comision.IdSecretario.ToString();
            txtTesorero.Text = comision.IdTesorero.ToString();
            cmbClub.SelectedValue = comision.IdClub;
        

            DateTime fecha1 = comision.FechaDesde;
            string dia = fecha1.Date.Day.ToString();
            string mes = fecha1.Date.Month.ToString();
            string año = fecha1.Date.Year.ToString();

            if (dia.Length == 1)
            {
                dia = 0 + dia;
            }
            if (mes.Length == 1)
            {
                mes = 0 + mes;
            }

            txtFechaInicioCom.Text = dia + mes + año;

            DateTime fecha2 = comision.FechaHasta;
            string dia2 = fecha2.Date.Day.ToString();
            string mes2 = fecha2.Date.Month.ToString();
            string año2 = fecha2.Date.Year.ToString();

            if (dia2.Length == 1)
            {
                dia2 = 0 + dia2;
            }
            if (mes2.Length == 1)
            {
                mes2 = 0 + mes2;
            }

            txtFechaFinCom.Text = dia2 + mes2 + año2;

            
        }

        private void grdCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdCom.Rows[indice];
            int club = int.Parse(filaSeleccionada.Cells["IdClub"].Value.ToString());
            DateTime fecha = DateTime.Parse(filaSeleccionada.Cells["fechaDesde"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarCom.Enabled = true;
                btnBorrarCom.Enabled = true;
                cargarCampos(obtenerComision(club,fecha));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener la comision - " + ex.Message);
            }
        }

        private bool actualizarComision(Comision comision)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE COMISIONES" +
                    "              SET FECHA_DESDE = @fechaDesde, FECHA_HASTA = @fechaHasta, ID_VOCAL1 = @idVocal1, ID_VOCAL2 = @idVocal2, ID_VOCAL3 = @idVocal3, ID_PRESIDENTE = @idPresidente, ID_SECRETARIO = @idSecretario, ID_TESORERO = @idTesorero" +
                    "              WHERE ID_CLUB = @id AND FECHA_DESDE = @fechaDesde";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", comision.IdClub);
                cmd.Parameters.AddWithValue("@fechaDesde", comision.FechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", comision.FechaHasta);
                cmd.Parameters.AddWithValue("@idVocal1", comision.IdVocal1);
                cmd.Parameters.AddWithValue("@idVocal2", comision.IdVocal2);
                cmd.Parameters.AddWithValue("@idVocal3", comision.IdVocal3);
                cmd.Parameters.AddWithValue("@idPresidente", comision.IdPresidente);
                cmd.Parameters.AddWithValue("@idSecretario", comision.IdSecretario);
                cmd.Parameters.AddWithValue("@idTesorero", comision.IdTesorero);

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

        private void btnActualizarCom_Click(object sender, EventArgs e)
        {
            Comision comision = obtenerDatosComision();

            try
            {
                if (actualizarComision(comision))
                {
                    MessageBox.Show("Comisión actualizada con exito!!");
                    limpiarCampos();
                    cargarComboClub();
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la comisión - " + ex.Message);
            }
        }

        private bool borrarComision(int idClub, DateTime fechaDesde)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM COMISIONES" +
                    "              WHERE ID_CLUB = @id AND FECHA_DESDE = @fecha";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idClub);
                cmd.Parameters.AddWithValue("@fecha", fechaDesde);

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

        private void btnBorrarCom_Click(object sender, EventArgs e)
        {
            Comision comision = obtenerDatosComision();

            if (MessageBox.Show("¿Seguro que desea eliminar esta comisión?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarComision(comision.IdClub, comision.FechaDesde))
                    {
                        MessageBox.Show("Comisión borrada con exito!!");
                        limpiarCampos();
                        cargarGrilla();
                        cargarComboClub();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado dentro de la Base de Datos - " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se eliminará la comision");
            }
        }
    }
    }
