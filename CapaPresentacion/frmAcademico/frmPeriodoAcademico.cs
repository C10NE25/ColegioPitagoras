using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.frmAcademico
{
    public partial class frmPeriodoAcademico : Form
    {
        public frmPeriodoAcademico()
        {
            InitializeComponent();
            gbxPeriodoAcademico.Enabled = false;
            txtIdPeriodoAcademico.Enabled = false;
            ListarPeriodoAcademico();
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
            txtIdPeriodoAcademico.Text = "";
            txtPeriodoAnioAcademico.Text = "";
            txtNombrePeriodoAcademico.Text = "";
            cbxEstado.Checked = false;
        }
        private void ListarPeriodoAcademico()
        {
            dgvPeriodoAcademico.DataSource = logPeriodoAcademico.Instancia.ListarPeriodoAcademico();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxPeriodoAcademico.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxPeriodoAcademico.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxPeriodoAcademico.Enabled = false;
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
                entPeriodoAcademico pa = new entPeriodoAcademico();
                pa.anioPeriodoAcademico = int.Parse(txtPeriodoAnioAcademico.Text.Trim());
                pa.NombrePeriodoAcademico = txtNombrePeriodoAcademico.Text.Trim();
                pa.EstadoPeriodoAcademico = cbxEstado.Checked;
                logPeriodoAcademico.Instancia.insertarPeriodoAcademico(pa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Periodo Academico: " + ex.Message);
            }
            limpiarVariables();
            gbxPeriodoAcademico.Enabled = false;
            ListarPeriodoAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPeriodoAcademico pa = new entPeriodoAcademico();
                pa.IdPeriodoAcademico = int.Parse(txtIdPeriodoAcademico.Text.Trim());
                pa.anioPeriodoAcademico = int.Parse(txtPeriodoAnioAcademico.Text.Trim());
                pa.NombrePeriodoAcademico = txtNombrePeriodoAcademico.Text.Trim();
                pa.EstadoPeriodoAcademico = cbxEstado.Checked;
                logPeriodoAcademico.Instancia.editarPeriodoAcademico(pa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Periodo Academico: " + ex.Message);
            }
            limpiarVariables();
            gbxPeriodoAcademico.Enabled = false;
            ListarPeriodoAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPeriodoAcademico pa = new entPeriodoAcademico();
                pa.IdPeriodoAcademico = Convert.ToInt32(txtIdPeriodoAcademico.Text.Trim());
                cbxEstado.Enabled = false;
                pa.EstadoPeriodoAcademico = cbxEstado.Checked;
                logPeriodoAcademico.Instancia.DeshabilitarPeriodoAcademico(pa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Nivel Academico: " + ex.Message);

            }
            limpiarVariables();
            gbxPeriodoAcademico.Enabled = false;
            ListarPeriodoAcademico();
        }

        private void dgvPeriodoAcademico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPeriodoAcademico.Rows[e.RowIndex];
            txtIdPeriodoAcademico.Text = fila.Cells[0].Value.ToString();
            txtPeriodoAnioAcademico.Text = fila.Cells[1].Value.ToString();
            txtNombrePeriodoAcademico.Text = fila.Cells[2].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[3].Value);
        }
    }
}
