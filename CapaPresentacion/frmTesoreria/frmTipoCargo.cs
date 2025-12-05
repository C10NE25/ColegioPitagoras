using CapaEntidad;
using CapaLogica;
using CapaPresentacion.frmTesoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.frmAcademico
{
    public partial class frmTipoCargo : Form
    {
        public frmTipoCargo()
        {
            InitializeComponent();
            gbxTipoCargo.Enabled = false;

            txtIdTipoCargo.Enabled = false;
            ListarTipoCargo();
            CargarTarifa();
        }

        public void CargarTarifa()
        {
            List<entTarifa> lista = logTarifa.Instancia.ListarTarifa();
            cbTarifa.DataSource = lista;
            cbTarifa.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbTarifa.ValueMember = "IdTarifa";
        }
        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeshabilitar.Enabled = false;
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
            txtIdTipoCargo.Text = "";
            txtNombreTipoCargo.Text = "";
            cbxEstado.Checked = false;
        }
        private void ListarTipoCargo()
        {
            dgvTipoCargo.DataSource = logTipoCargo.Instancia.ListarTipoCargo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxTipoCargo.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxTipoCargo.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxTipoCargo.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            gbxTipoCargo.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCargo tc= new entTipoCargo();
                tc.NombreTipoCargo = txtNombreTipoCargo.Text;
                tc.IdTarifa = Convert.ToInt32(cbTarifa.SelectedValue);
                tc.EstadoTipoCargo = cbxEstado.Checked;
                logTipoCargo.Instancia.InsertarTipoCargo(tc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxTipoCargo.Enabled = false;
            ListarTipoCargo();
            habilitarBotonesPrincipales();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCargo tc = new entTipoCargo();
                tc.IdTipoCargo = Convert.ToInt32(txtIdTipoCargo.Text);
                cbxEstado.Enabled = false;
                tc.EstadoTipoCargo = cbxEstado.Checked;
                logTipoCargo.Instancia.DeshabilitarTipoCargo(tc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar el tipo de cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxTipoCargo.Enabled = false;
            ListarTipoCargo();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCargo tc = new entTipoCargo();
                tc.IdTipoCargo = Convert.ToInt32(txtIdTipoCargo.Text);
                tc.NombreTipoCargo = txtNombreTipoCargo.Text;
                tc.IdTarifa = Convert.ToInt32(cbTarifa.SelectedValue);
                tc.EstadoTipoCargo = cbxEstado.Checked;
                logTipoCargo.Instancia.EditarTipoCargo(tc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el tipo de cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxTipoCargo.Enabled = false;
            ListarTipoCargo();
            habilitarBotonesPrincipales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmTarifa())
            {
                frm.ShowDialog();
            }
            CargarTarifa();
            this.Show();
        }

        private void dgvTipoCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTipoCargo.Rows[e.RowIndex];
            txtIdTipoCargo.Text = fila.Cells[0].Value.ToString();
            txtNombreTipoCargo.Text = fila.Cells[1].Value.ToString();
            cbTarifa.SelectedValue = fila.Cells[2].Value;
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[3].Value);
        }
    }
}
