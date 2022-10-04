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
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class ABMcanchas : Form
    {
        public ABMcanchas()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {


            txtNroCancha.Text = "";
            cmbClub.SelectedIndex = -1;
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtCodBarrio.Text = "";
            cmbCodPiso.SelectedIndex = -1;
            cmbTestado.SelectedIndex = -1;
            txtFechaUltMant.Text = "";

            txtNroCancha.Focus();
            btnActualizarCancha.Enabled = false;
            btnBorrarCancha.Enabled = false;
        }
        private bool existeCancha(int idClub ,int numCan)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_CLUB,NRO_CANCHA" +
                    "              FROM CANCHAS" +
                    "              WHERE ID_CLUB = @id AND NRO_CANCHA = @num";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",idClub);
                cmd.Parameters.AddWithValue("@num", numCan);

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
        public void cargarComboEstado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM TIPO_ESTADOCANCHA";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbTestado.DataSource = tabla;
                cmbTestado.DisplayMember = "NOMBRE";
                cmbTestado.ValueMember = "COD_ESTADO";
                cmbTestado.SelectedIndex = -1;

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
        public void cargarComboClub()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM CLUBES";

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
        public void cargarComboTipoPiso()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM TIPO_PISO";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCodPiso.DataSource = tabla;
                cmbCodPiso.DisplayMember = "NOMBRE";
                cmbCodPiso.ValueMember = "COD_PISO";
                cmbCodPiso.SelectedIndex = -1;

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
                string consulta = "SELECT NRO_CANCHA,ID_CLUB,FECHA_ULT_MANTENIMIENTO FROM CANCHAS";
                  

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaCanchas.DataSource = tabla;

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

        private void ABMcanchas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            try
            {
                cargarComboTipoPiso();
                cargarComboEstado();
                cargarComboClub();
                cargarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el acceso a base de datos -" + ex);
            }
           
            
            
           
        }
        private Canchas ObtenerDatosCanchas()
        {
            Canchas cancha = new Canchas();

            if (txtNroCancha.Text.Equals("") || (int)cmbClub.SelectedValue == -1 || txtCalle.Text.Equals("") || txtNroCalle.Text.Equals("") || txtCodBarrio.Text.Equals("")
                || (int)cmbCodPiso.SelectedValue == -1 || (int)cmbTestado.SelectedValue == -1 || txtFechaUltMant.Text.Equals(""))
            {
                return null;
            }
            else
            {
                cancha.NroCancha = int.Parse(txtNroCancha.Text);
                cancha.Idclub = (int)cmbClub.SelectedValue;
                cancha.Calle = txtCalle.Text;
                cancha.NroCalle = int.Parse(txtNroCalle.Text);
                cancha.CodBarrio = int.Parse(txtCodBarrio.Text);
                cancha.CodPiso = (int)cmbCodPiso.SelectedValue;
                cancha.CodEstado = (int)cmbTestado.SelectedValue;
                cancha.FechaUltMant = DateTime.Parse(txtFechaUltMant.Text);

                return cancha;
            }
        }


        private void btnGuardarCancha_Click(object sender, EventArgs e)
        {
           

            Canchas cancha = ObtenerDatosCanchas();
            if (cancha == null)
            {
                MessageBox.Show("Error, completar todos los datos");
            }
            else
            {
                try
                {
                    if (existeCancha(cancha.Idclub, cancha.NroCancha))
                    {
                        MessageBox.Show("Error ya existe esta cancha");
                        return;
                    }
                    else
                    {
                        if (agregarCanchaBD(cancha))
                        {
                            MessageBox.Show("Cancha agregada con exito");
                            LimpiarCampos();
                            cargarComboClub();
                            cargarComboEstado();
                            cargarComboTipoPiso();
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
        private bool agregarCanchaBD(Canchas cancha)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CANCHAS(NRO_CANCHA, ID_CLUB, CALLE, NRO_CALLE, COD_BARRIO, COD_PISO, COD_ESTADO, FECHA_ULT_MANTENIMIENTO)" +
                     "VALUES(@nCancha,@id,@calle,@nroCalle,@barrio,@piso,@estado,@fecha)";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nCancha", cancha.NroCancha);
                cmd.Parameters.AddWithValue("@id", cancha.Idclub);
                cmd.Parameters.AddWithValue("@calle", cancha.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", cancha.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", cancha.CodBarrio);
                cmd.Parameters.AddWithValue("@piso", cancha.CodPiso);
                cmd.Parameters.AddWithValue("@estado", cancha.CodEstado);
                cmd.Parameters.AddWithValue("@fecha", cancha.FechaUltMant);

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

        private void grillaCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            

            DataGridViewRow filaSeleccionada = grillaCanchas.Rows[indice];
            int numero = int.Parse(filaSeleccionada.Cells["NroCancha"].Value.ToString());
            int id = int.Parse(filaSeleccionada.Cells["Club"].Value.ToString());

            try
            {
                LimpiarCampos();
                btnActualizarCancha.Enabled = true;
                btnBorrarCancha.Enabled = true;
                CargarCampos(ObtenerCancha(numero,id));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener la cancha - " + ex.Message);
            }
        }
        private Canchas ObtenerCancha(int nroCancha,int idClub)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Canchas canc = new Canchas();


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CANCHAS WHERE NRO_CANCHA = @num AND ID_CLUB = @idClub";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@num", nroCancha);
                cmd.Parameters.AddWithValue("@idClub", idClub);



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                    
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr != null && dr.Read())
                {
                    canc.NroCancha = int.Parse(dr["NRO_CANCHA"].ToString());
                    canc.Idclub = int.Parse(dr["ID_CLUB"].ToString());
                    canc.Calle = dr["CALLE"].ToString();
                    canc.NroCalle = int.Parse(dr["NRO_CALLE"].ToString());
                    canc.CodBarrio = int.Parse(dr["COD_BARRIO"].ToString());
                    canc.CodPiso = int.Parse(dr["COD_PISO"].ToString());
                    canc.CodEstado = int.Parse(dr["COD_ESTADO"].ToString());
                    canc.FechaUltMant = DateTime.Parse(dr["FECHA_ULT_MANTENIMIENTO"].ToString());
                }
                return canc;
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
        private void CargarCampos(Canchas can)
        {
            txtNroCancha.Text = can.NroCancha.ToString();
            cmbClub.SelectedValue = can.Idclub;
            txtCalle.Text = can.Calle;   
            txtNroCalle.Text = can.NroCalle.ToString(); 
            txtCodBarrio.Text = can.CodBarrio.ToString();
            cmbTestado.SelectedValue = can.CodEstado;
            cmbCodPiso.SelectedValue = can.CodPiso;
            
            DateTime fecha = can.FechaUltMant;
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

            txtFechaUltMant.Text = dia + mes + año;

        }

        private void btnActualizarCancha_Click(object sender, EventArgs e)
        {
            Canchas can = ObtenerDatosCanchas();

            try
            {
                if (ActualizarCancha(can))
                {
                    MessageBox.Show("Cancha actualizada con exito!!");
                    LimpiarCampos();
                    
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cancha - " + ex.Message);
            }
        }
        private bool ActualizarCancha(Canchas cancha)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CANCHAS"+
                    " SET NRO_CANCHA = @nCancha,ID_CLUB = @id,CALLE = @calle,NRO_CALLE = @nroCalle,COD_BARRIO = @barrio,COD_PISO = @piso,COD_ESTADO = @estado,FECHA_ULT_MANTENIMIENTO = @fecha"+
                    " WHERE ID_CLUB = @id AND NRO_CANCHA = @nCancha";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nCancha", cancha.NroCancha);
                cmd.Parameters.AddWithValue("@id", cancha.Idclub);
                cmd.Parameters.AddWithValue("@calle", cancha.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", cancha.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", cancha.CodBarrio);
                cmd.Parameters.AddWithValue("@piso", cancha.CodPiso);
                cmd.Parameters.AddWithValue("@estado", cancha.CodEstado);
                cmd.Parameters.AddWithValue("@fecha", cancha.FechaUltMant);

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
        private bool borrarCancha(int idClub, int ncan)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM CANCHAS" +
                    "              WHERE NRO_CANCHA = @nroCan AND ID_CLUB = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCan",ncan);
                cmd.Parameters.AddWithValue("@id", idClub);


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

        private void btnBorrarCancha_Click(object sender, EventArgs e)
        {
            Canchas can = ObtenerDatosCanchas();
            if (MessageBox.Show("¿Seguro que desea eliminar esta cancha?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarCancha(can.Idclub,can.NroCancha))
                    {
                        MessageBox.Show("Cancha borrada con exito!!");
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
                MessageBox.Show("No se eliminara la cancha");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
