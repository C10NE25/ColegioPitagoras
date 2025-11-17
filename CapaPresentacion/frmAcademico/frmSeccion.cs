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
    public partial class frmSeccion : Form
    {
        public frmSeccion()
        {
            InitializeComponent();
            gbxSeccion.Enabled = false;
            txtIdSeccion.Enabled = false;
            cbxEstado.Checked = true;
            listarNivelSeccion();
        }

        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;

        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIdSeccion.Clear();
            txtNombreSeccion.Clear();
        }
        private void listarNivelSeccion()
        {
            dgvSeccion.DataSource = logSeccion.Instancia.ListarSeccion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxSeccion.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxSeccion.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entSeccion seccion = new entSeccion();
                seccion.IdSeccion = Convert.ToInt32(txtIdSeccion.Text.Trim());
                cbxEstado.Enabled = false;
                seccion.EstadoSeccion = cbxEstado.Checked;
                logSeccion.Instancia.DeshabilitarSeccion(seccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Seccion: " + ex.Message);

            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            listarNivelSeccion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entSeccion seccion = new entSeccion();
                seccion.NombreSeccion = txtNombreSeccion.Text.Trim();
                seccion.EstadoSeccion = cbxEstado.Checked;
                logSeccion.Instancia.InsertarSeccion(seccion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Seccion: " + ex.Message);
            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            listarNivelSeccion();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entSeccion seccion = new entSeccion();
                seccion.IdSeccion = Convert.ToInt32(txtIdSeccion.Text.Trim());
                seccion.NombreSeccion = txtNombreSeccion.Text.Trim();
                seccion.EstadoSeccion = cbxEstado.Checked;
                logSeccion.Instancia.editarSeccion(seccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Seccion: " + ex.Message);
            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            listarNivelSeccion();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxSeccion.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void dgvSeccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvSeccion.Rows[e.RowIndex];
            txtIdSeccion.Text = fila.Cells[0].Value.ToString();
            txtNombreSeccion.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
