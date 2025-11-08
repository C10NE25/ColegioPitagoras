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
    public partial class frmParentesco : Form
    {
        public frmParentesco()
        {
            InitializeComponent();
            gbxParentesco.Enabled = false;
            txtBIdParentesco.Enabled = false;
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
        private void listarParentesco()
        {
            dgvParenteco.DataSource = logParentesco.Instancia.ListarParentesco();
        }
        private void limpiarVariables()
        {
            txtBIdParentesco.Text = "";
            txtBtipoParentesco.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxParentesco.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entParentesco parentesco = new entParentesco();
                parentesco.TipoParentesco = txtBtipoParentesco.Text.Trim();
                parentesco.EstadoParentesco = cbxEstado.Checked;
                logParentesco.Instancia.InsertarParentesco(parentesco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar parentesco: " + ex.Message);
            }
            limpiarVariables();
            gbxParentesco.Enabled = false;
            listarParentesco();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entParentesco parentesco = new entParentesco();
                parentesco.IdParentesco = Convert.ToInt32(txtBIdParentesco.Text.Trim());
                parentesco.TipoParentesco = txtBtipoParentesco.Text.Trim();
                parentesco.EstadoParentesco = cbxEstado.Checked;
                logParentesco.Instancia.EditarParentesco(parentesco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar parentesco: " + ex.Message);
            }
            limpiarVariables();
            gbxParentesco.Enabled = false;
            listarParentesco();
            habilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxParentesco.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entParentesco parentesco = new entParentesco();
                parentesco.IdParentesco = Convert.ToInt32(txtBIdParentesco.Text.Trim());
                cbxEstado.Checked = false;
                parentesco.EstadoParentesco = cbxEstado.Checked;
                logParentesco.Instancia.DeshabilitarParentesco(parentesco);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar parentesco: " + ex.Message);
            }
            limpiarVariables();
            gbxParentesco.Enabled = false;
            listarParentesco();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxParentesco.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void dgvParenteco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvParenteco.Rows[e.RowIndex];
            txtBIdParentesco.Text = fila.Cells[0].Value.ToString();
            txtBtipoParentesco.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
