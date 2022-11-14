using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8
{
    public partial class frmJugadores : Form
    {

        private int idJugador;
        public frmJugadores()
        {
            InitializeComponent();
        }

        private void frmJugadores_Load(object sender, EventArgs e)
        {

            limpiarCampos();

            try
            {
                cargarCombClubes();
                cargarCombSocios();
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el acceso a Base de Datos - " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            cmbSocio.SelectedIndex= -1;
            cmbClub.SelectedIndex= -1;

            cmbSocio.Focus();
            this.idJugador = 0;

            btnBorrarJugador.Enabled = false;
            btnActualizarJugador.Enabled = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargarCombClubes()
        {
            try
            {

                cmbClub.DataSource = AD_Clubes.obtenerClubes();
                cmbClub.DisplayMember = "NOMBRE";
                cmbClub.ValueMember = "ID_CLUB";
                cmbClub.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void cargarCombSocios()
        {
            try
            {

                cmbSocio.DataSource = AD_Socios.obtenerSocios();
                cmbSocio.DisplayMember = "NOMBRE";
                cmbSocio.ValueMember = "ID_SOCIO";
                cmbSocio.SelectedIndex = -1;

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
                grdJugadores.DataSource = AD_Jugadores.obtenerJgadoresxSocioxClub();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private Jugador obtenerDatosJugador()
        {
            Jugador jugador = new Jugador();
            if (cmbSocio.SelectedIndex == -1 || cmbClub.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                try
                {
                    jugador.IdSocio = int.Parse(cmbSocio.SelectedValue.ToString());
                    jugador.IdClub = int.Parse(cmbClub.SelectedValue.ToString());
                    return jugador;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {

            try
            {
                Jugador jugador = obtenerDatosJugador();

                if (jugador == null)
                {
                    MessageBox.Show("Error, completar todos los datos");
                }
                else
                {
                    try
                    {
                         if (AD_Jugadores.agregarJugadorBD(jugador))
                            {
                                MessageBox.Show("Jugador cargado con exito!!");
                                limpiarCampos();
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
                MessageBox.Show("Error en la carga del dato - " + ex.Message);
            }
        }
        
        private void cargarCampos(Jugador jugador)
        {
            cmbSocio.SelectedValue= jugador.IdSocio;
            cmbClub.SelectedValue = jugador.IdClub;

            this.idJugador = jugador.IdJugador;
        }

        private void grdJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = grdJugadores.Rows[indice];
            int idJugador = int.Parse(filaSeleccionada.Cells["id"].Value.ToString());

            try
            {
                limpiarCampos();
                btnActualizarJugador.Enabled = true;
                btnBorrarJugador.Enabled = true;
                cargarCampos(AD_Jugadores.obtenerJugador(idJugador));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el jugador - " + ex.Message);
            }
        }

       

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {

            try
            {
                Jugador jugador = obtenerDatosJugador();

                try
                {
                    if (AD_Jugadores.actualizarJugador(jugador, this.idJugador))
                    {
                        MessageBox.Show("Jugador actualizado con exito!!");
                        limpiarCampos();
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el jugador - " + ex.Message);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del dato -" + ex.Message);
            }
            
        }

        private void btnBorrarJugador_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este jugador?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (AD_Jugadores.borrarJugador(this.idJugador))
                    {
                        MessageBox.Show("Jugador borrado con exito!!");
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
                MessageBox.Show("No se eliminara el jugador");
            }



        }

        private void txtIdClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdClub_Click(object sender, EventArgs e)
        {

        }

        private void lblIdSocio_Click(object sender, EventArgs e)
        {

        }

        private void cmbClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    

}
   

