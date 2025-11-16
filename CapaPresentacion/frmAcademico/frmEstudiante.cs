using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmEstudiante : Form
    {
        private int idApoderado;
        public frmEstudiante()
        {
            InitializeComponent();
            gbxEstudiante.Enabled = false;
            gbDatosApoderado.Enabled = false;
            txtIDEstudiante.Enabled = false;
            listarEstudiante();
            listarApoderado();
        }

        private void listarEstudiante()
        {
            dgvEstudiante.DataSource = logEstudiante.Instancia.ListarEstudiantes();
        }

        private void listarApoderado()
        {
            dtgApoderado.DataSource = logApoderado.Instancia.ListarApoderados();
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = true;
            gbDatosApoderado.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void limpiarVariables()
        {
            txtIDEstudiante.Clear();
            txtNombreEstudiante.Clear();
            txtApellidoPEstudiante.Clear();
            txtApellidoMEstudiante.Clear();
            txtBDniEstudiante.Clear();
            dtpFechaNacEstudiante.Value = DateTime.Now;
            txtDireccionEstudiante.Clear();
            cbxEstado.Checked = false;
            txtBDniApoderado.Clear();
            txtBNameApoderado.Clear();
            txtBApellidoPApoderado.Clear();
            txtBApellidoMApoderado.Clear();
            txtBSearchApoderado.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudiante estudiante= new entEstudiante();
                estudiante.DniEst = txtBDniEstudiante.Text.Trim();
                estudiante.NombreEst = txtNombreEstudiante.Text.Trim();
                estudiante.ApellidosPatEst = txtApellidoPEstudiante.Text.Trim();
                estudiante.ApellidosMatEst = txtApellidoMEstudiante.Text.Trim();
                estudiante.FechaNacEst = dtpFechaNacEstudiante.Value;
                estudiante.DireccionEst = txtDireccionEstudiante.Text.Trim();
                estudiante.IdApoderado = idApoderado;
                estudiante.EstadoEst = cbxEstado.Checked;
                logEstudiante.Instancia.InsertarEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar estudiante: "+ex);
            }
            limpiarVariables();
            gbxEstudiante.Enabled = false;
            listarEstudiante();
            habilitarBotonesPrincipales();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = true;
            gbDatosApoderado.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudiante estudiante = new entEstudiante();
                estudiante.IdEstudiante = Convert.ToInt32(txtIDEstudiante.Text.Trim());
                estudiante.DniEst = txtBDniEstudiante.Text.Trim();
                estudiante.NombreEst = txtNombreEstudiante.Text.Trim();
                estudiante.ApellidosPatEst = txtApellidoPEstudiante.Text.Trim();
                estudiante.ApellidosMatEst = txtApellidoMEstudiante.Text.Trim();
                estudiante.FechaNacEst = dtpFechaNacEstudiante.Value;
                estudiante.DireccionEst = txtDireccionEstudiante.Text.Trim();
                estudiante.IdApoderado = idApoderado;
                estudiante.EstadoEst = cbxEstado.Checked;
                logEstudiante.Instancia.EditarEstudiante(estudiante);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar estudiante: " + ex+MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxEstudiante.Enabled = false;
            listarEstudiante();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = false;
            gbDatosApoderado.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudiante estudiante = new entEstudiante();
                estudiante.IdEstudiante = Convert.ToInt32(txtIDEstudiante.Text.Trim());
                cbxEstado.Checked = false;
                estudiante.EstadoEst = cbxEstado.Checked;
                logEstudiante.Instancia.DeshabilitarEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar estudiante: " + ex + MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxEstudiante.Enabled = false;
            listarEstudiante();
        }
        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEstudiante.Rows[e.RowIndex];
            txtIDEstudiante.Text = fila.Cells[0].Value.ToString();
            txtBDniEstudiante.Text = fila.Cells[1].Value.ToString();
            txtNombreEstudiante.Text = fila.Cells[2].Value.ToString();
            txtApellidoPEstudiante.Text = fila.Cells[3].Value.ToString();
            txtApellidoMEstudiante.Text = fila.Cells[4].Value.ToString();
            dtpFechaNacEstudiante.Value = Convert.ToDateTime(fila.Cells[5].Value);
            txtDireccionEstudiante.Text = fila.Cells[6].Value.ToString();
            idApoderado = Convert.ToInt32(fila.Cells[7].Value);
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[8].Value);
        }

        private void dgvEstudiante_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEstudiante.ClearSelection();
        }

        private void btnSearchApoderado_Click(object sender, EventArgs e)
        {
            var apo = logApoderado.Instancia.BuscarApoderadoPorDni(txtBSearchApoderado.Text.Trim());
            if (apo != null){
                txtBNameApoderado.Text = apo.NombreApo;
                txtBApellidoPApoderado.Text = apo.ApellidosPatApo;
                txtBApellidoMApoderado.Text = apo.ApellidosMatApo;
                txtBDniApoderado.Text = apo.DniApo;
                idApoderado = apo.IdApoderado;
            }
            else 
            {
                MessageBox.Show("No se encontro el Apoderado");
            }
        }

        private void btnAddApoderado_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmApoderado())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void dtgApoderado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtgApoderado.Rows[e.RowIndex];
            idApoderado = Convert.ToInt32(fila.Cells[0].Value);
            txtBNameApoderado.Text = fila.Cells[2].Value.ToString();
            txtBApellidoPApoderado.Text = fila.Cells[3].Value.ToString();
            txtBApellidoMApoderado.Text = fila.Cells[4].Value.ToString();
            txtBDniApoderado.Text = fila.Cells[1].Value.ToString();
            txtBSearchApoderado.Text = fila.Cells[1].Value.ToString();
        }
    }
}
