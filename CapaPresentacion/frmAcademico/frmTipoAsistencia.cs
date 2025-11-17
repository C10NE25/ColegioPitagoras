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
    public partial class frmTipoAsistencia : Form
    {
        public frmTipoAsistencia()
        {
            InitializeComponent();
            listarTipoEvaluacion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoAsistencia.Enabled = true;
            gbxTipoAsistencia.Enabled = true;
            btnAgregar.Visible = true;
            cbxEstado.Checked = true;
            btnModificar.Visible = false;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxTipoAsistencia.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoAsistencia tipoAsistencia = new entTipoAsistencia();
                tipoAsistencia.TipoAsistencia = txtBidTipoAsistencia.Text.Trim();
                tipoAsistencia.estado = cbxEstado.Checked;
                logTipoAsistencia.Instancia.InsertarTipoAsistencia(tipoAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tipo asistencia: " + ex.Message);
            }
            limpiarVariables();
            gbxTipoAsistencia.Enabled = false;
            listarTipoEvaluacion();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoAsistencia tipoAsistencia = new entTipoAsistencia();
                tipoAsistencia.IdTipoAsistencia = Convert.ToInt32(txtBidTipoAsistencia.Text.Trim());
                tipoAsistencia.TipoAsistencia = txtBidTipoAsistencia.Text.Trim();
                tipoAsistencia.estado = cbxEstado.Checked;
                logTipoAsistencia.Instancia.EditarTipoAsistencia(tipoAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar tipo asistencia: " + ex.Message);
            }
            limpiarVariables();
            gbxTipoAsistencia.Enabled = false;
            listarTipoEvaluacion();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxTipoAsistencia.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void limpiarVariables()
        {
            txtBidTipoAsistencia.Clear();
            txtBTipoAsistencia.Clear();
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
            dgvTipoAsistencia.DataSource = logTipoAsistencia.Instancia.ListarTipoAsistencia();
        }

        private void dgvTipoAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTipoAsistencia.Rows[e.RowIndex];
            txtBidTipoAsistencia.Text = fila.Cells[0].Value.ToString();
            txtBTipoAsistencia.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
