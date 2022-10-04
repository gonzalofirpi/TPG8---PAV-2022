using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class frmSocios : Form
    {

        private int idSocio;

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
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
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrios.SelectedIndex = -1;
            txtFechaNacimiento.Text = "";

            txtNombre.Focus();
            this.idSocio = 0;

            btnBorrarSocio.Enabled = false;
            btnActualizarSocio.Enabled = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private Socio obtenerDatosSocio()
        {
            Socio socio = new Socio();


            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtCalle.Text.Equals("") || txtNroCalle.Text.Equals("") || (int)cmbBarrios.SelectedValue == -1 || txtFechaNacimiento.Text.Equals(""))
            {
                return null;
            }
            else
            {
                try
                {
                    socio.Nombre = txtNombre.Text;
                    socio.Apellido = txtApellido.Text;
                    socio.Calle = txtCalle.Text;
                    socio.NroCalle = int.Parse(txtNroCalle.Text);
                    socio.Barrio = (int)cmbBarrios.SelectedValue;
                    socio.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);

                    return socio;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = obtenerDatosSocio();


                if (socio == null)
                {
                    MessageBox.Show("Error, completar todos los datos");
                }
                else
                {
                    try
                    {
                        if (AD_Socios.agregarSocioBD(socio))
                        {
                            MessageBox.Show("Socio cargado con exito!!");
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

                cmbBarrios.DataSource = AD_Socios.obtenerBarrios();
                cmbBarrios.DisplayMember = "NOMBRE";
                cmbBarrios.ValueMember = "COD_BARRIO";
                cmbBarrios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

              private bool existeEnGrilla(long criterioBuscar)
        {

            for (int i = 0; i < grdSocios.Rows.Count; i++)
            {
                if (grdSocios.Rows[i].Cells["apellido"].Value.Equals(criterioBuscar))
                {
                    return true;
                }

            }

            return false;
        }

        private void cargarGrilla()
        {
            try
            {
                grdSocios.DataSource = AD_Socios.obtenerListadoSocios();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void cargarCampos(Socio socio)
        {
            txtNombre.Text = socio.Nombre;
            txtApellido.Text = socio.Apellido.ToString();
            txtCalle.Text = socio.Calle;
            txtNroCalle.Text = socio.NroCalle.ToString();
            cmbBarrios.SelectedValue = socio.Barrio;

            DateTime fecha = socio.FechaNacimiento;
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

            txtFechaNacimiento.Text = dia + mes + año;

            this.idSocio = socio.Id;
        }

        private void grdSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdSocios.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["id"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarSocio.Enabled = true;
                btnBorrarSocio.Enabled = true;
                cargarCampos(AD_Socios.obtenerSocio(id));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el socio - " + ex.Message);
            }
        }

        

        private void btnActualizarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = obtenerDatosSocio();

                try
                {
                    if (AD_Socios.actualizarSocio(socio, this.idSocio))
                    {
                        MessageBox.Show("Socio actualizado con exito!!");
                        limpiarCampos();
                        cargarComboBarrios();
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el socio - " + ex.Message);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato - " + ex.Message);
            }

        }

        private void btnBorrarSocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este socio?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AD_Socios.borrarSocio(this.idSocio))
                    {
                        MessageBox.Show("Socio borrado con exito!!");
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
                MessageBox.Show("No se eliminara el socio");
            }

        }
    }
    
}