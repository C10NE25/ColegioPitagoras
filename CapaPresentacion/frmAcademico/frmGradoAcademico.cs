using CapaEntidad;
using CapaLogica;
using CapaPresentacion.frmAcademico;
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
    public partial class frmGradoAcademico : Form
    {
        public frmGradoAcademico()
        {
            InitializeComponent();
            listarGradoAcademico();
            cargarNivelAcademico();
            cargarSeccion();
            cbxEstado.Checked = true;
            gbxGradoAcademico.Enabled = false;
        }
        #region Funciones extras
        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtIDGradoAcademico.Clear();
            txtNombreGrado.Clear();
        }
        private void listarGradoAcademico()
        {
            dgvGradoAcademico.DataSource = logGradoAcademico.Instancia.ListarGradoAcademico();
        }

        private void cargarNivelAcademico()
        {
            cbNivelAcademico.DataSource = logNivelAcademico.Instancia.ListarNivelAcademico();
            cbNivelAcademico.ValueMember = "idNivelAcademico";
            cbNivelAcademico.DisplayMember = "nombreNivelAcademico"; // Propiedad personalizada
        }
        private void cargarSeccion()
        {
            cbSeccion.DataSource = logSeccion.Instancia.ListarSeccion();
            cbSeccion.ValueMember = "idSeccion";
            cbSeccion.DisplayMember = "nombreSeccion";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxGradoAcademico.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxGradoAcademico.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }
        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entGradoAcademico ga = new entGradoAcademico();

                ga.NombreGradoAcademico = txtNombreGrado.Text.Trim();
                ga.IdNivelAcademico = Convert.ToInt32(cbNivelAcademico.SelectedValue);
                ga.IdSeccion = Convert.ToInt32(cbSeccion.SelectedValue);
                ga.EstadoGradoAcademico = cbxEstado.Checked;
                logGradoAcademico.Instancia.InsertarGradoAcademico(ga);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar grado academico: " + ex.Message);
            }
            limpiarVariables();
            gbxGradoAcademico.Enabled = false;
            listarGradoAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entGradoAcademico ga = new entGradoAcademico();
                ga.IdGradoAcademico = Convert.ToInt32(txtIDGradoAcademico.Text.Trim());
                ga.NombreGradoAcademico = txtNombreGrado.Text.Trim();
                ga.IdNivelAcademico = Convert.ToInt32(cbNivelAcademico.SelectedValue);
                ga.IdSeccion = Convert.ToInt32(cbSeccion.SelectedValue);
                ga.EstadoGradoAcademico = cbxEstado.Checked;
                logGradoAcademico.Instancia.EditarGradoAcademico(ga);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar grado academico: " + ex.Message);
            }
            limpiarVariables();
            gbxGradoAcademico.Enabled = false;
            listarGradoAcademico();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxGradoAcademico.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnAddNivelAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmNivelAcademico())
            {
                frm.ShowDialog();
            }
            cargarNivelAcademico();
            this.Show();
        }

        private void btnAddSeccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmSeccion())
            {
                frm.ShowDialog();
            }
            cargarSeccion();
            this.Show();
        }
    }
}
