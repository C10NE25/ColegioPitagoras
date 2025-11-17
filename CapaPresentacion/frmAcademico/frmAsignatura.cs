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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
            gbxSeccion.Enabled = false;
            cbxEstado.Checked = true;
            ListarAsignatura();
        }

        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCerrar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCerrar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIdAsignatura.Text = "";
            txtNombreAsignatura.Text = "";
        }
        private void ListarAsignatura()
        {
            dgvAsignatura.DataSource = logAsignatura.Instancia.ListarAsignatura();
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
                entAsignatura asig = new entAsignatura();
                asig.IdAsignatura = Convert.ToInt32(txtIdAsignatura.Text.Trim());
                cbxEstado.Enabled = false;
                asig.EstadoAsignatura = cbxEstado.Checked;
                logAsignatura.Instancia.DeshabilitarAsignatura(asig);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Asignatura: " + ex.Message);
            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            ListarAsignatura();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entAsignatura asig = new entAsignatura();
                asig.NombreAsignatura = txtNombreAsignatura.Text.Trim();
                asig.EstadoAsignatura = cbxEstado.Checked;
                logAsignatura.Instancia.insertarAsignatura(asig);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Asignatura: " + ex.Message);
            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            ListarAsignatura();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAsignatura asig = new entAsignatura();
                asig.IdAsignatura = Convert.ToInt32(txtIdAsignatura.Text.Trim());
                asig.NombreAsignatura = txtNombreAsignatura.Text.Trim();
                asig.EstadoAsignatura = cbxEstado.Checked;
                logAsignatura.Instancia.editarAsignatura(asig);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Asignatura: " + ex.Message);
            }
            limpiarVariables();
            gbxSeccion.Enabled = false;
            ListarAsignatura();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxSeccion.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void dgvAsignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvAsignatura.Rows[e.RowIndex];
            txtIdAsignatura.Text = fila.Cells[0].Value.ToString();
            txtNombreAsignatura.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
