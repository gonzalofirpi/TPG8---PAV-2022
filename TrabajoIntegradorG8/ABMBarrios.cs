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
using TrabajoIntegradorG8.AccesoADatos;
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

        private void limpiarCampos()
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

        private void cargarComboLocalidades()
        {
            try
            {
                cmbLocalidades.DataSource = AD_Barrios.obtenerLocalidades();
                cmbLocalidades.DisplayMember = "NOMBRE";
                cmbLocalidades.ValueMember = "COD_LOCALIDAD";
                cmbLocalidades.SelectedIndex = -1;
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
                grdBarrios.DataSource = AD_Barrios.obtenerListadoBarrios();
            }
            catch (Exception ex)
            {
                throw;
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
                try
                {
                    barrio.Nombre = txtNombre.Text;
                    barrio.Localidad = (int)cmbLocalidades.SelectedValue;
                    barrio.CodPostal = int.Parse(txtCodPostal.Text);

                    return barrio;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void btnGuardarBarrio_Click(object sender, EventArgs e)
        {

            try
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
                        if (AD_Barrios.existeCodigoPostal(barrio.CodPostal))
                        {

                            if (AD_Barrios.agregarBarrioBD(barrio))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato - " + ex.Message);
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
                cargarCampos(AD_Barrios.obtenerBarrio(codBarrio));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el barrio - " + ex.Message);
            }
        }

       

        private void btnActualizarBarrio_Click(object sender, EventArgs e)
        {

            try
            {
                Barrio barrio = obtenerDatosBarrio();

                try
                {
                    if (AD_Barrios.actualizarBarrio(barrio, this.codBarrio))
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
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato -" + ex.Message);
            }
            
        }

        private void btnBorrarBarrio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este barrio?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AD_Barrios.borrarBarrio(this.codBarrio))
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
   


