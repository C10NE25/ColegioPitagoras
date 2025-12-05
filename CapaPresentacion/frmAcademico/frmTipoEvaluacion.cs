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

namespace CapaPresentacion.frmAcademico
{
    public partial class frmTipoEvaluacion : Form
    {
        public frmTipoEvaluacion()
        {
            InitializeComponent();
            gbTipoEvaluacion.Enabled = false;
            listarTipoEvaluacion();
        }
        private void limpiarVariables()
        {
            txtIdTipoEvaluacion.Clear();
            txtNomTipoNota.Clear();
        }
        private void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
        }
        private void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }
        private void listarTipoEvaluacion()
        {
            dgvTipoEvaluacion.DataSource = logTipoEvaluacion.Instancia.ListarTipoEvaluacion();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoEvaluacion.Enabled = true;
            gbTipoEvaluacion.Enabled = true;
            btnAgregar.Visible = true;
            cbxEstado.Checked = true;
            btnModificar.Visible = false;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbTipoEvaluacion.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbTipoEvaluacion.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEvaluacion tipoEvaluacion = new entTipoEvaluacion();
                tipoEvaluacion.IdTipoEvaluacion = Convert.ToInt32(txtIdTipoEvaluacion.Text.Trim());
                tipoEvaluacion.NomTipoNota = txtNomTipoNota.Text.Trim();
                tipoEvaluacion.EstadoTipoEvaluacion = cbxEstado.Checked;
                logTipoEvaluacion.Instancia.EditarTipoEvaluacion(tipoEvaluacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar tipo evaluacion: " + ex.Message);
            }
            limpiarVariables();
            gbTipoEvaluacion.Enabled = false;
            listarTipoEvaluacion();
            habilitarBotonesPrincipales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEvaluacion tipoEvaluacion = new entTipoEvaluacion();
                tipoEvaluacion.NomTipoNota = txtNomTipoNota.Text.Trim();
                tipoEvaluacion.EstadoTipoEvaluacion = cbxEstado.Checked;
                logTipoEvaluacion.Instancia.InsertarTipoEvaluacion(tipoEvaluacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tipo evaluacion: " + ex.Message);
            }
            limpiarVariables();
            gbTipoEvaluacion.Enabled = false;
            listarTipoEvaluacion();
            habilitarBotonesPrincipales();
        }

        private void dgvTipoEvaluacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTipoEvaluacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTipoEvaluacion.Rows[e.RowIndex];
            txtIdTipoEvaluacion.Text = fila.Cells[0].Value.ToString();
            txtNomTipoNota.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
