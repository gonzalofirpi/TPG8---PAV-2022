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
    public partial class ABMcanchas : Form
    {
        public ABMcanchas()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {


            txtNroCancha.Text = "";
            txtIdClub.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtCodBarrio.Text = "";
            txtCodPiso.Text = "";
            txtCodEstado.Text = "";
            txtFechaUltMant.Text = "";

            txtNroCancha.Focus();
            btnActualizarCancha.Enabled = false;
            btnBorrarCancha.Enabled = false;
        }

        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NRO_CANCHA,ID_CLUB,FECHA_ULT_MANTENIMIENTO FROM CANCHAS ";
                    //"INNER JOIN CLUBES C ON (CA.ID_CLUB = C.ID_CLUB )";

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
            
            cargarGrilla();
            
           
        }
        private Canchas ObtenerDatosCanchas()
        {
            Canchas cancha = new Canchas();

            if (txtNroCancha.Text.Equals("") || txtIdClub.Text.Equals("") || txtCalle.Text.Equals("") || txtNroCalle.Text.Equals("") || txtCodBarrio.Text.Equals("")
                || txtCodPiso.Text.Equals("") || txtCodEstado.Text.Equals("") || txtFechaUltMant.Text.Equals(""))
            {
                return null;
            }
            else
            {
                cancha.NroCancha = int.Parse(txtNroCancha.Text);
                cancha.Idclub = int.Parse(txtIdClub.Text);
                cancha.Calle = txtCalle.Text;
                cancha.NroCalle = int.Parse(txtNroCalle.Text);
                cancha.CodBarrio = int.Parse(txtCodBarrio.Text);
                cancha.CodPiso = int.Parse(txtCodPiso.Text);
                cancha.CodEstado = int.Parse(txtCodEstado.Text);
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
                    if (agregarCanchaBD(cancha))
                    {
                        MessageBox.Show("Cancha agregada con exito");
                        LimpiarCampos();
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
                string consulta = "INSERT INTO CANCHAS (NRO_CANCHA,ID_CLUB,CALLE,NRO_CALLE,COD_BARRIO,COD_PISO,COD_ESTADO,FECHA_ULT_MANTENIMIENTO)" +
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
            txtIdClub.Text = can.Idclub.ToString();
            txtCalle.Text = can.Calle;   
            txtNroCalle.Text = can.NroCalle.ToString(); 
            txtCodBarrio.Text = can.CodBarrio.ToString();
            txtCodPiso.Text = can.CodPiso.ToString();
            txtCodEstado.Text = can.CodEstado.ToString();
            txtFechaUltMant.Text = can.FechaUltMant.Date.ToShortDateString();

        }

        private void btnActualizarCancha_Click(object sender, EventArgs e)
        {
            Canchas can = ObtenerDatosCanchas();

            try
            {
                if (ActualizarCancha(can))
                {
                    MessageBox.Show("Club actualizado con exito!!");
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
                    "SET NRO_CANCHA = @ncancha,ID_CLUB = @id,CALLE = @calle,NRO_CALLE = @nroCalle,"+
                    "COD_BARRIO = @barrio,COD_PISO = @piso, COD_ESTADO = @estado,FECHA_ULT_MANTENIMIENTO = @fecha";

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
        private bool borrarCancha()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM CANCHAS" +
                    "              WHERE NRO_CANCHA = @nroCan";

                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@nroCan", this.id);

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
            if (MessageBox.Show("¿Seguro que desea eliminar esta cancha?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (borrarCancha())
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
    }
}
