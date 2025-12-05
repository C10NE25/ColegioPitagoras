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
            //btnModificar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIdTarifa.Text = "";
            txtNombreTarifa.Text = "";
            txtMontoTarifa.Text = "";
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
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxTarifa.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
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


        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entTarifa t = new entTarifa();
                t.IdTarifa = Convert.ToInt32(txtIdTarifa.Text.Trim());
                cbxEstado.Enabled = false;
                t.EstadoTarifa = cbxEstado.Checked;
                logTarifa.Instancia.DeshabilitarTarifa(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Tarifa: " + ex.Message);
            }
            limpiarVariables();
            gbxTarifa.Enabled = false;
            ListarTarifa();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTarifa t = new entTarifa();
                t.IdTarifa = Convert.ToInt32(txtIdTarifa.Text.Trim());
                t.NombreTarifa = txtNombreTarifa.Text.Trim();
                t.MontoTarifa = Convert.ToDecimal(txtMontoTarifa.Text.Trim());
                t.IdPeriodoAcademico = Convert.ToInt32(cbAnioAcademico.SelectedValue);
                t.EstadoTarifa = cbxEstado.Checked;
                logTarifa.Instancia.editarTarifa(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Tarifa: " + ex.Message);
            }
            limpiarVariables();
            gbxTarifa.Enabled = false;
            ListarTarifa();
            habilitarBotonesPrincipales();
        }

        private void dgvTarifa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTarifa.Rows[e.RowIndex];
            txtIdTarifa.Text = fila.Cells[0].Value.ToString();
            txtNombreTarifa.Text = fila.Cells[1].Value.ToString();
            txtMontoTarifa.Text = fila.Cells[2].Value.ToString();
            cbAnioAcademico.SelectedValue = Convert.ToInt32(fila.Cells[3].Value);
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[4].Value);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            gbxTarifa.Enabled = false;
            habilitarBotonesPrincipales();
        }
    }
}
