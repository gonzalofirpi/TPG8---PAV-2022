using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoIntegradorG8.AccesoADatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabajoIntegradorG8
{
    public partial class frmPartido : Form
    {
        public frmPartido()
        {
            InitializeComponent();

            limpiarCampos();

            try
            {
                cargarComboClubLocal();
                cargarComboCategorias();
                cargarComboCancha();
                cargarComboPuestos();
                cargarComboTitular();
                cargarComboCargo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de datos");
            }
           
        }

        public void cargarComboClubLocal() 
        {
            try
            {
                DataTable table = AD_Partidos.cargarComboClub();
                cmbClubLocal.DataSource = table;

                cmbClubLocal.DisplayMember = "NOMBRE";
                cmbClubLocal.ValueMember = "ID_CLUB";
                cmbClubLocal.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cargarComboClubVisitante()
        {
            try
            {
                DataTable table = AD_Partidos.cargarComboClub2(int.Parse(cmbClubLocal.SelectedValue.ToString()));

                cmbClubVisitante.DataSource = table;

                cmbClubVisitante.DisplayMember = "NOMBRE";
                cmbClubVisitante.ValueMember = "ID_CLUB";
                cmbClubVisitante.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public void cargarComboCategorias()
        {
            try
            {
                DataTable table = AD_Partidos.cargarComboCategoria();

                cmbCategorias.DataSource = table;
                cmbCategorias.DisplayMember = "NOMBRE";
                cmbCategorias.ValueMember = "COD_CATEGORIA";
                cmbCategorias.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void cargarComboCancha()
        {
            try
            {
                DataTable table = AD_Partidos.cargarComboCancha();

                cmbNroCancha.DataSource = table;
                cmbNroCancha.DisplayMember = "NRO_CANCHA";
                cmbNroCancha.ValueMember = "NRO_CANCHA";
                cmbNroCancha.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void cargarComboPuestos()
        {
            try
            {
                DataTable table = AD_Partidos.cargarComboPuesto();

                cmbPuestos.DataSource = table;
                cmbPuestos.DisplayMember = "NOMBRE";
                cmbPuestos.ValueMember = "COD_PUESTO";
                cmbPuestos.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void cargarComboTitular()
        {
            cmbTitular.Items.Add("Titular");
            cmbTitular.Items.Add("Suplente");
        }

        public void cargarComboCargo()
        {
            try
            {
                DataTable table = AD_Partidos.cargarCargo();
                cmbCargos.DataSource = table;

                cmbCargos.DisplayMember = "NOMBRE";
                cmbCargos.ValueMember = "COD_CARGO";
                cmbCargos.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void cmbClubLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmbClubLocal.Text != "" )
            {
                cargarComboClubVisitante();
                cmbClubVisitante.Enabled = true;
            } else
            {
                cmbClubVisitante.SelectedIndex = -1;
            }
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable table = AD_Partidos.ObtenerJugadorXId(int.Parse(txtIdJugador.Text));

                if (table.Rows.Count > 0)
                {
                    txtNombreJugador.Text = table.Rows[0][0].ToString();
                    txtApellidoJugador.Text = table.Rows[0][1].ToString();
                    txtClub.Text = table.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el jugador");
                    txtIdJugador.Focus();
                    txtNombreJugador.Text = "";
                    txtApellidoJugador.Text = "";
                    txtClub.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en el acceso a BD");
            }
            
        }

        private void btnBuscarArbitro_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable table = AD_Partidos.ObtenerArbitroXId(int.Parse(txtIdArbitro.Text));

                if (table.Rows.Count > 0)
                {
                    txtNombreArbitro.Text = table.Rows[0][0].ToString();
                    txtApellidoArbitro.Text = table.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el arbitro");
                    txtIdArbitro.Focus();
                    txtNombreArbitro.Text = "";
                    txtApellidoArbitro.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en acceso a BD");
            }
           
        }

        public bool validarEquipos()
        {
            if (txtClub.Text == cmbClubLocal.Text || txtClub.Text == cmbClubVisitante.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void limpiarCampos()
        {
            txtFecha.Text = "";
            cmbCategorias.SelectedIndex = -1;
            cmbClubLocal.SelectedIndex = -1;
            cmbClubVisitante.SelectedIndex = -1;
            cmbNroCancha.SelectedIndex = -1;

            txtIdJugador.Text = "";
            txtNombreJugador.Text = "";
            txtApellidoJugador.Text = "";
            txtClub.Text = "";
            txtNroCamiseta.Text = "";
            cmbPuestos.SelectedIndex = -1;
            cmbTitular.SelectedIndex = -1;
            grdJugadores.Rows.Clear();

            txtIdArbitro.Text = "";
            txtNombreArbitro.Text = "";
            txtApellidoArbitro.Text = "";
            cmbCargos.SelectedIndex = -1;
            grdArbitros.Rows.Clear();
        }


        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            if (txtIdJugador.Text != "" && txtNroCamiseta.Text != "" && cmbPuestos.Text != "")
            {
                
                for (int i = 0; i < grdJugadores.Rows.Count; i++)
                {
                    if (grdJugadores.Rows[i].Cells[0].Value.ToString() == txtIdJugador.Text)
                    {
                        MessageBox.Show("Error jugador repetido");
                        return;
                    }

                    if (txtNroCamiseta.Text != "" && grdJugadores.Rows[i].Cells[5].Value.ToString() == txtNroCamiseta.Text && txtClub.Text == grdJugadores.Rows[i].Cells[4].Value.ToString())
                    {
                        MessageBox.Show("Error camiseta repetida");
                        return;
                    }
                }

                if (validarEquipos())
                {
                    grdJugadores.Rows.Add(txtIdJugador.Text, txtNombreJugador.Text, txtApellidoJugador.Text, txtClub.Text, txtNroCamiseta.Text, cmbPuestos.Text);
                }
                else
                {
                    MessageBox.Show("Error, el jugador debe pertenecer a alguno de los dos equipos del partido");
                    return;
                }

            }

            else
            {
                MessageBox.Show("Error, completar todos los campos");
            }

        }

        private void btnAgregarArbitro_Click(object sender, EventArgs e)
        {


            if ( grdArbitros.Rows.Count == 4 )
            {
                MessageBox.Show("Error, ya estan cargados los 4 arbitros");
                return;
            }

            if (txtIdArbitro.Text == "" && cmbCargos.Text == "") 
            {
                MessageBox.Show("Error, completar todos los campos");
                return;
            }
            else
            {
                for (int i = 0; i < grdArbitros.Rows.Count; i++)
                {
                    if (grdArbitros.Rows[i].Cells[0].Value.ToString() == txtIdArbitro.Text)
                    {
                        MessageBox.Show("Error, ID repetido");
                        return;
                    }

                    if (grdArbitros.Rows[i].Cells[3].Value.ToString() == cmbCargos.Text)
                    {
                        MessageBox.Show("Error, cargo repetido");
                        return;
                    }

                }

                grdArbitros.Rows.Add(txtIdArbitro.Text, txtNombreArbitro.Text, txtApellidoArbitro.Text, cmbCargos.Text);

            }
            
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            List<int> listaJugadores = new List<int>();

            for (int i = 0; i < grdJugadores.Rows.Count; i++)
            {
                listaJugadores.Add(int.Parse(grdJugadores.Rows[i].Cells[0].Value.ToString()));
            }

            List<int> listaArbitros = new List<int>();

            for (int i = 0; i < grdArbitros.Rows.Count; i++)
            {
                listaArbitros.Add(int.Parse(grdArbitros.Rows[i].Cells[0].Value.ToString()));
            }

            try
            {
                if (AD_Partidos.altaNuevoPartido(DateTime.Parse(txtFecha.Text), (int)cmbCategorias.SelectedValue, (int)cmbNroCancha.SelectedValue, (int)cmbClubLocal.SelectedValue, (int)cmbClubVisitante.SelectedValue, int.Parse(txtNroCamiseta.Text), (int)cmbPuestos.SelectedValue, cmbTitular.Text, (int)cmbCargos.SelectedValue, listaJugadores, listaArbitros))
                {
                    MessageBox.Show("Partido dado de alta con exito!!");
                }

                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el alta del partido - " + ex.Message);
            }
            
            
            
        }
    }
}
