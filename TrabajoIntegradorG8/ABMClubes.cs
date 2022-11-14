using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;
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
                try
                {
                    club.Nombre = txtNombre.Text;
                    club.NroCuit = long.Parse(txtNroCuit.Text);
                    club.Calle = txtCalle.Text;
                    club.NroCalle = int.Parse(txtNroCalle.Text);
                    club.Barrio = (int)cmbBarrios.SelectedValue;
                    club.FechaFundacion = DateTime.Parse(txtFechaFundacion.Text);

                    return club;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        private void btnGuardarClub_Click(object sender, EventArgs e)
        {
            try
            {
                Club club = obtenerDatosClub();


                if (club == null)
                {
                    MessageBox.Show("Error, completar todos los datos");
                }
                else
                {
                    try
                    {
                        if (AD_Clubes.agregarClubBD(club))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos - " + ex.Message);
            }
          

        }
        private void cargarComboBarrios()
        {
            try
            {

                cmbBarrios.DataSource = AD_Clubes.obtenerBarrios();
                cmbBarrios.DisplayMember = "NOMBRE";
                cmbBarrios.ValueMember = "COD_BARRIO";
                cmbBarrios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void cargarGrilla()
        {
            try
            {
                grdClubes.DataSource = AD_Clubes.obtenerListadoClubes();
            }
            catch (Exception ex)
            {
                throw;
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
                cargarCampos(AD_Clubes.obtenerClub(cuit));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el club - " + ex.Message);
            }
        }

        

        private void btnActualizarClub_Click(object sender, EventArgs e)
        {
            try
            {
                Club club = obtenerDatosClub();

                try
                {
                    if (AD_Clubes.actualizarClub(club, this.idClub))
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
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato - " + ex.Message);
            }

        }

        private void btnBorrarClub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este club?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AD_Clubes.borrarClub(this.idClub))
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

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
