using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoDatos;
using TrabajoIntegradorG8.Entidad;

namespace TrabajoIntegradorG8.Puestos
{
    public partial class PuestosABM : Form

    {
        private int codPuesto;
        public PuestosABM()
        {
            InitializeComponent();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            try
            {
                
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos - " + ex.Message);
            }

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
                gridPuesto.DataSource = AD_Puesto.ObtenerListadoPuestos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Puesto obtenerDatosPuesto()
        {
            Puesto puesto = new Puesto();
            if (txtNombre.Text.Equals(""))
            {
                return null;
            }
            else
            {
                try
                {
                    puesto.Nombre = txtNombre.Text;
                    return puesto;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnGuardarBarrio_Click(object sender, EventArgs e)
        {
            try
            {
                Puesto puesto = obtenerDatosPuesto();
                if (puesto == null)
                    MessageBox.Show("Error, completar el campo nombre");
                else
                {
                    try
                    {
                        if (AD_Puesto.agregarPuesto(puesto))

                        {
                            MessageBox.Show("Puesto agregado exitosamente");
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

        private void gridPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gridPuesto.Rows[indice];
            int codPuesto = int.Parse(filaSeleccionada.Cells["codigo"].Value.ToString());
            try
            {
                LimpiarDatos();
                btnActualizarBarrio.Enabled = true;
                btnBorrarPuesto.Enabled = true;
                cargarCampos(AD_Puesto.obtenerPuesto(codPuesto));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar obtener Puesto: " + ex.Message);
            }
        }

        private void cargarCampos(Puesto puesto)
        {
            txtNombre.Text = puesto.Nombre;
            this.codPuesto = puesto.Codigo;
            
        }

        private void btnActualizarBarrio_Click(object sender, EventArgs e)
        {
            try
            {
                Puesto puesto = obtenerDatosPuesto();
                try
                {
                    if (AD_Puesto.actualizarPuesto(puesto, this.codPuesto))
                    {
                        MessageBox.Show("Puesto actulizado con exito");
                        LimpiarDatos();
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al actualizar el puesto:  " + ex.Message);
                    return;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la carga del dato -" + ex.Message);

            }

        }

        private void btnBorrarPuesto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este PUESTO?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AD_Puesto.borrarPuesto(this.codPuesto))
                    {
                        MessageBox.Show("Puesto borrado con exito!!");
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
                MessageBox.Show("No se eliminara el PUESTO");
            }

        }
    }
}
