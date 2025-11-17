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
    public partial class frmDetallePago : Form
    {
        public frmDetallePago()
        {
            InitializeComponent();
            ListarDetallePago();
            CargarPago();
            CargarTipoCargo();
            gbxDatos.Enabled = false;
            txtIdDetallePago.Enabled = false;
            cbxEstado.Checked = true;
        }
        public void CargarPago()
        {
            List<entPago> lista = logPago.Instancia.ListarPago();
            cbPago.DataSource = lista;
            cbPago.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbPago.ValueMember = "IdPago";
        }

        public void CargarTipoCargo()
        {
            List<entTipoCargo> lista = logTipoCargo.Instancia.ListarTipoCargo();
            cbPago.DataSource = lista;
            cbPago.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbPago.ValueMember = "IdTipoCargo";
        }

        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIdDetallePago.Text = "";
            txtMonto.Text = "";
        }


        public void ListarDetallePago()
        {
            dgvDetPago.DataSource = logDetallePago.Instancia.ListarDetallePago();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxDatos.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Insertar Tutor
            try
            {
                entDetallePago dtp = new entDetallePago();
                dtp.IdPago = Convert.ToInt32(cbTipoCargo.SelectedValue);
                dtp.IdTipoCargo = Convert.ToInt32(cbTipoCargo.SelectedValue);
                dtp.EstadoDetallePago = cbxEstado.Checked;
                dtp.MontoPagado = Convert.ToDecimal(txtMonto.Text.Trim());
                dtp.EstadoDetallePago= cbxEstado.Checked;
                logDetallePago.Instancia.InsertarDetallePago(dtp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxDatos.Enabled = false;
            ListarDetallePago();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxDatos.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetallePago dtp = new entDetallePago();
                dtp.IdDetallePago = Convert.ToInt32(txtIdDetallePago.Text.Trim());
                cbxEstado.Checked = false;
                dtp.EstadoDetallePago = cbxEstado.Checked;
                logDetallePago.Instancia.DeshabilitarDetallePago(dtp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxDatos.Enabled = false;
            ListarDetallePago();
        }

        private void dgvDetPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDetPago.Rows[e.RowIndex];
            txtIdDetallePago.Text = fila.Cells[0].Value.ToString();
            cbPago.SelectedValue = fila.Cells[1].Value.ToString();
            cbTipoCargo.SelectedValue = fila.Cells[2].Value.ToString();
            txtMonto.Text = fila.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[4].Value);
        }
    }
}
