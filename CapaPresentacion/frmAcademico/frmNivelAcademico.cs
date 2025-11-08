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

namespace CapaPresentacion
{
    public partial class frmNivelAcademico : Form
    {
        public frmNivelAcademico()
        {
            InitializeComponent();
            gbxNivelAcademico.Enabled = false;
            txtIDNivelAcademico.Enabled = false;
            listarNivelAcademico();
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
            txtIDNivelAcademico.Text = "";
            txtNombreNivel.Text = "";
            cbxEstado.Checked = false;
        }
        private void listarNivelAcademico()
        {
            dgvNivelAcademico.DataSource = logNivelAcademico.Instancia.ListarNivelAcademico();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxNivelAcademico.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxNivelAcademico.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entNivelAcademico nivel = new entNivelAcademico();
                nivel.IdNivelAcademico=Convert.ToInt32(txtIDNivelAcademico.Text.Trim());
                cbxEstado.Enabled = false;
                nivel.EstadoNivelAcademico=cbxEstado.Checked;
                logNivelAcademico.Instancia.DeshabilitarNivelAcademico(nivel);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Nivel Academico: " + ex.Message);

            }
            limpiarVariables();
            gbxNivelAcademico.Enabled = false;
            listarNivelAcademico();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entNivelAcademico nivel = new entNivelAcademico();
                nivel.NombreNivelAcademico=txtNombreNivel.Text.Trim();
                nivel.EstadoNivelAcademico = cbxEstado.Checked;
                logNivelAcademico.Instancia.InsertarNivelAcademico(nivel);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar Nivel Academico: " + ex.Message);
            }
            limpiarVariables();
            gbxNivelAcademico.Enabled = false;
            listarNivelAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
                entNivelAcademico nivel = new entNivelAcademico();
                nivel.IdNivelAcademico=Convert.ToInt32(txtIDNivelAcademico.Text.Trim());
                nivel.NombreNivelAcademico=txtNombreNivel.Text.Trim();
                nivel.EstadoNivelAcademico=cbxEstado.Checked;
                logNivelAcademico.Instancia.EditarNivelAcademico(nivel);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar Nivel Academico: " + ex.Message);
            }
            limpiarVariables();
            gbxNivelAcademico.Enabled = false;
            listarNivelAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxNivelAcademico.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void dgvNivelAcademico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvNivelAcademico.Rows[e.RowIndex];
            txtIDNivelAcademico.Text = fila.Cells[0].Value.ToString();
            txtNombreNivel.Text = fila.Cells[1].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }
    }
}
