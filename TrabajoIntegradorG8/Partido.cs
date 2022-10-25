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

            cargarComboClubLocal();
            cargarComboCategorias();
            cargarComboCancha();
            cargarComboPuestos();
            cargarComboTitular();
        }

        public void cargarComboClubLocal() 
        {
            DataTable table = AD_Partidos.cargarComboClub();
            cmbClubLocal.DataSource = table;

            cmbClubLocal.DisplayMember = "NOMBRE";
            cmbClubLocal.ValueMember = "ID_CLUB";
            cmbClubLocal.SelectedIndex = -1;

        }

        public void cargarComboClubVisitante()
        {
            DataTable table = AD_Partidos.cargarComboClub2(int.Parse(cmbClubLocal.SelectedValue.ToString()));

            cmbClubVisitante.DataSource = table;

            cmbClubVisitante.DisplayMember = "NOMBRE";
            cmbClubVisitante.ValueMember = "ID_CLUB";
            cmbClubVisitante.SelectedIndex = -1;
        }
        public void cargarComboCategorias()
        {
            DataTable table = AD_Partidos.cargarComboCategoria();

            cmbCategorias.DataSource = table;
            cmbCategorias.DisplayMember = "NOMBRE";
            cmbCategorias.ValueMember = "COD_CATEGORIA";
            cmbCategorias.SelectedIndex = -1;
        }
        public void cargarComboCancha()
        {
            DataTable table = AD_Partidos.cargarComboCancha();

            cmbNroCancha.DataSource = table;
            cmbNroCancha.DisplayMember = "NRO_CANCHA";
            cmbNroCancha.ValueMember = "NRO_CANCHA";
            cmbNroCancha.SelectedIndex = -1;
        }
        public void cargarComboPuestos()
        {
            DataTable table = AD_Partidos.cargarComboPuesto();

            cmbPuestos.DataSource = table;
            cmbPuestos.DisplayMember = "NOMBRE";
            cmbPuestos.ValueMember = "COD_PUESTO";
            cmbPuestos.SelectedIndex = -1;
        }

        public void cargarComboTitular()
        {
            cmbTitular.Items.Add("Titular");
            cmbTitular.Items.Add("Suplente");
        }

        private void cmbClubLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmbClubLocal.SelectedIndex != -1 )
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

        private void btnBuscarArbitro_Click(object sender, EventArgs e)
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

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            bool resultado = true;

            for (int i = 0; i < grdArbitros.Rows.Count; i++)
            {
                if (grdJugadores.Rows[i].Cells[1].Value.ToString() == txtIdJugador.Text)
                {
                    resultado = false;
                }
            }

            if (resultado)
            {
                if (txtIdJugador.Text != "" && txtNroCamiseta.Text != "" && (int)cmbPuestos.SelectedValue != -1)
                {
                    grdJugadores.Rows.Add(txtIdJugador.Text, txtNombreJugador.Text, txtApellidoJugador.Text, txtClub.Text, txtNroCamiseta.Text, cmbPuestos.Text);
                }
                else
                {
                    MessageBox.Show("Error, completar todos los campos");
                }
            }
            else
            {
                MessageBox.Show("Error, ID repetido");
            }

        }

        private void btnAgregarArbitro_Click(object sender, EventArgs e)
        {

            bool resultado = true;

            for (int i = 0; i < grdArbitros.Rows.Count; i++)
            {
                if (grdArbitros.Rows[i].Cells[1].Value.ToString() == txtIdArbitro.Text)
                {
                    resultado = false;
                }
            }

            if (resultado)
            {
                if (txtIdArbitro.Text != "" && (int)cmbCargos.SelectedValue != -1)
                {
                    grdArbitros.Rows.Add(txtIdArbitro.Text, txtNombreArbitro.Text, txtApellidoArbitro.Text, cmbCargos.Text);
                }
                else
                {
                    MessageBox.Show("Error, completar todos los campos");
                }
            }
            else
            {
                MessageBox.Show("Error, ID repetido");
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
                listaArbitros.Add(int.Parse(grdJugadores.Rows[i].Cells[0].Value.ToString()));
            }


            if (AD_Partidos.altaNuevoPartido(DateTime.Parse(txtFecha.Text), (int) cmbCategorias.SelectedValue, (int) cmbNroCancha.SelectedValue, (int)cmbClubLocal.SelectedValue, (int)cmbClubVisitante.SelectedValue, int.Parse(txtNroCamiseta.Text), (int) cmbPuestos.SelectedValue, cmbTitular.Text, (int) cmbCargos.SelectedValue, listaJugadores, listaArbitros))
            {
                MessageBox.Show("Curso dado de alta con exito!!");

            }
            else
            {
                MessageBox.Show("Error en el alta del curso");
            }
        }
    }
}
