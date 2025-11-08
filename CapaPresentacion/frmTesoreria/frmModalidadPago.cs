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
    public partial class frmModalidadPago : Form
    {
        public frmModalidadPago()
        {
            InitializeComponent();
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
            txtIdModalidadPago.Text = "";
            txtTipoModalidadPago.Text = "";
            cbxEstado.Checked = false;
        }
        private void ListarModalidadPago()
        {
            dgvModalidadPago.DataSource = logModalidadPago.Instancia.ListarModalidadPago();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxModalidadPago.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxModalidadPago.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entModalidadPago mp = new entModalidadPago();
                mp.idModalidadPago = Convert.ToInt32(txtTipoModalidadPago.Text.Trim());
                cbxEstado.Enabled = false;
                mp.EstadoModalidadPago = cbxEstado.Checked;
                logModalidadPago.Instancia.DeshabilitarModalidadPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Modalidad Pago: " + ex.Message);

            }
            limpiarVariables();
            gbxModalidadPago.Enabled = false;
            ListarModalidadPago();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entModalidadPago mp = new entModalidadPago();

                mp.TipoModalidadPago = txtTipoModalidadPago.Text.Trim();
                mp.EstadoModalidadPago = cbxEstado.Checked;
                logModalidadPago.Instancia.insertarModalidadPago(mp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Modalidad Pago: " + ex.Message);
            }
            limpiarVariables();
            gbxModalidadPago.Enabled = false;
            ListarModalidadPago();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entModalidadPago mp = new entModalidadPago();
                mp.idModalidadPago = Convert.ToInt32(txtIdModalidadPago.Text.Trim());
                mp.TipoModalidadPago = txtTipoModalidadPago.Text.Trim();
                mp.EstadoModalidadPago = cbxEstado.Checked;
                logModalidadPago.Instancia.editarModalidadPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Modalidad Pago: " + ex.Message);
            }
            limpiarVariables();
            gbxModalidadPago.Enabled = false;
            ListarModalidadPago();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxModalidadPago.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void dgvModalidadPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvModalidadPago.Rows[e.RowIndex];
            txtTipoModalidadPago.Text = fila.Cells[0].Value.ToString();
            txtTipoModalidadPago.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
