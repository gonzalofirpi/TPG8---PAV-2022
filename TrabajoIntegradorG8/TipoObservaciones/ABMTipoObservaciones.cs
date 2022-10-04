using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.Entidad;
using TrabajoIntegradorG8.AccesoDatos;

namespace TrabajoIntegradorG8.EstadoCancha
{
    public partial class ABMTipoObservaciones : Form
    {
        private int codObservacion;
        public ABMTipoObservaciones()
        {
            InitializeComponent();
        }


        private void LimpiarDatos()
        {
            txtNombre.Text = " ";
            txtNombre.Focus();

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void cargarGrilla()
        {
            try
            {
                grideEstado.DataSource = AD_TipoObservaciones.ObtenerListadoObservaciones();
            }
            catch (Exception)
            {

                throw;
            }


        }
        private TipoObservaciones obtenerDatosObservaciones()
        {
            TipoObservaciones observacion = new TipoObservaciones();
            if (txtNombre.Text.Equals(""))
            {
                return null;
            }
            else
            {
                try
                {
                    observacion.Nombre = txtNombre.Text;
                    return observacion;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        private void grideEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grideEstado.Rows[indice];
            int codObservacion = int.Parse(filaSeleccionada.Cells["codigo"].Value.ToString());
            try
            {
                LimpiarDatos();
                btnActualizarObservacion.Enabled = true;
                btnBorrarObservacion.Enabled = true;
                cargarCampos(AD_TipoObservaciones.obtenerObservacion(codObservacion));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar obtener Observacion: " + ex.Message);
            }
        }
        private void cargarCampos(TipoObservaciones observacion)
        {
            txtNombre.Text = observacion.Nombre;
            this.codObservacion = observacion.Codigo;

        }



        

        private void ABMTipoObservaciones_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            try
            {

                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos: " + ex.Message);
            }

        }

       
    

        private void btnActualizarObservacion_Click(object sender, EventArgs e)
        {
            try
            {
                TipoObservaciones observacion = obtenerDatosObservaciones();
                try
                {
                    if (AccesoDatos.AD_TipoObservaciones.actualizarObservacion(observacion, this.codObservacion))
                    {
                        MessageBox.Show("Observacion actulizado con exito");
                        LimpiarDatos();
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al actualizar la Observaicion:  " + ex.Message);
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la carga del dato: " + ex.Message);

            }
        }

        private void btnGuardarObservacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                TipoObservaciones observacion = obtenerDatosObservaciones();
                if (observacion == null)
                    MessageBox.Show("Error, completar el campo nombre");
                else
                {
                    try
                    {
                        if (AD_TipoObservaciones.agregarObservacion(observacion))

                        {
                            MessageBox.Show("Observacion agregado exitosamente");
                            LimpiarDatos();
                            cargarGrilla();
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error en la Base de datos: " + ex.Message);
                        return;
                    }
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error en la carga del dato: " + ex.Message);

            }
        }

        private void btnBorrarObservacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar esta OBSERVACION?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AccesoDatos.AD_TipoObservaciones.borrarObservacion(this.codObservacion))
                    {
                        MessageBox.Show("Observacion borrado con exito!!");
                        LimpiarDatos();
                        cargarGrilla();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado dentro de la Base de Datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se eliminara el Estado");
            }
        }
    }
}
