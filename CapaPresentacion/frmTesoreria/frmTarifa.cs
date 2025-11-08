using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.frmTesoreria
{
    public partial class frmTarifa : Form
    {
        public frmTarifa()
        {
            InitializeComponent();
            gbxTarifa.Enabled = false;
            txtIdTarifa.Enabled = false;
            ListarTarifa();
            CargarPeriodosAcademicos();
        }
        private void CargarPeriodosAcademicos()
        {
            List<entPeriodoAcademico> lista = logPeriodoAcademico.Instancia.ListarPeriodoAcademico();
            cbAnioAcademico.DataSource = lista;
            cbAnioAcademico.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbAnioAcademico.ValueMember = "IdPeriodoAcademico";
        }



        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnCerrar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnCerrar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIdTarifa.Text = "";
            txtNombreTarifa.Text = "";
            txtIdTarifa.Text = "";
            cbxEstado.Checked = false;
        }
        private void ListarTarifa()
        {
            dgvTarifa.DataSource = logTarifa.Instancia.ListarTarifa();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxTarifa.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxTarifa.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxTarifa.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTarifa t = new entTarifa();
                t.NombreTarifa = txtNombreTarifa.Text.Trim();
                t.MontoTarifa = Convert.ToDecimal(txtMontoTarifa.Text.Trim());
                t.IdPeriodoAcademico = Convert.ToInt32(cbAnioAcademico.SelectedValue);
                t.EstadoTarifa = cbxEstado.Checked;
                logTarifa.Instancia.InsertarTarifa(t);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Periodo Academico: " + ex.Message);
            }
            limpiarVariables();
            gbxTarifa.Enabled = false;
            ListarTarifa();
            habilitarBotonesPrincipales();
        }
    }
}
