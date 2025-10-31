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
        public frmEstudiante()
        {
            InitializeComponent();
            gbxEstudiante.Enabled = false;
            txtIDEstudiante.Enabled = false;
            listarEstudiante();
        }

        private void listarEstudiante()
        {
            dgvEstudiante.DataSource = logEstudiante.Instancia.ListarEstudiantes();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
        }

        private void limpiarVariables()
        {
            txtIDEstudiante.Text = "";
            txtNombreEstudiante.Text = "";
            txtApellidoEstudiante.Text = "";
            txtDniEstudiante.Text = "";
            dtpFechaNacEstudiante.Value = DateTime.Now;
            txtDireccionEstudiante.Text = "";
            txtIDTutor.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudiante estudiante= new entEstudiante();
                estudiante.DniEst = txtDniEstudiante.Text.Trim();
                estudiante.NombreEst = txtNombreEstudiante.Text.Trim();
                estudiante.ApellidosEst = txtApellidoEstudiante.Text.Trim();
                estudiante.FechaNacEst = dtpFechaNacEstudiante.Value;
                estudiante.DireccionEst = txtDireccionEstudiante.Text.Trim();
                estudiante.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
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
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEstudiante estudiante = new entEstudiante();
                estudiante.IdEstudiante = Convert.ToInt32(txtIDEstudiante.Text.Trim());
                estudiante.DniEst = txtDniEstudiante.Text.Trim();
                estudiante.NombreEst = txtNombreEstudiante.Text.Trim();
                estudiante.ApellidosEst = txtApellidoEstudiante.Text.Trim();
                estudiante.FechaNacEst = dtpFechaNacEstudiante.Value;
                estudiante.DireccionEst = txtDireccionEstudiante.Text.Trim();
                estudiante.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxEstudiante.Enabled = false;
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEstudiante.Rows[e.RowIndex];
            txtIDEstudiante.Text = fila.Cells[0].Value.ToString();
            txtNombreEstudiante.Text = fila.Cells[1].Value.ToString();
            txtApellidoEstudiante.Text = fila.Cells[2].Value.ToString();
            txtDniEstudiante.Text = fila.Cells[3].Value.ToString();
            dtpFechaNacEstudiante.Value = Convert.ToDateTime(fila.Cells[4].Value);
            txtDireccionEstudiante.Text = fila.Cells[5].Value.ToString();
            txtIDTutor.Text = fila.Cells[6].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[7].Value);
        }
    }
}
