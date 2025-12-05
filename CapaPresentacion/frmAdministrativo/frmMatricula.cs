using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
            ListarInscripcion();
            ListarMatricula();
            CargarGradoAcademico();
            deshabilitarGroupBoxs();
        }
        #region Metodos de Carga
        private void ListarMatricula()
        {
            dgvMatricula.DataSource = logMatricula.Instancia.ListarMatricula();
        }

        private void ListarInscripcion()
        {
            dgvInscripcion.DataSource = logInscripcion.Instancia.ListarInscripcion();
        }

        private void CargarGradoAcademico()
        {
            List<entGradoAcademico> lista = logGradoAcademico.Instancia.ListarGradoAcademico();
            cbGradoAcademico.DataSource = lista;
            cbGradoAcademico.ValueMember = "idGradoAcademico";
            cbGradoAcademico.DisplayMember = "nombreGradoAcademico"; // Propiedad personalizada
        }
        #endregion
        #region Metodos para Controles
        private void deshabilitarGroupBoxs()
        {
            gpDatosInscripcion.Enabled = false;
            gbxMatricula.Enabled = false;
        }
        private void habilitarGroupBoxs()
        {
            gpDatosInscripcion.Enabled = true;
            gbxMatricula.Enabled = true;
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
        void limpiarVariables()
        {
            txtIdMatricula.Clear();
            dtpFechaMatricula.Value = DateTime.Now;
            cbGradoAcademico.SelectedIndex = -1;
            dtpFechaMatricula.Value = DateTime.Now;
        }
        #endregion
        private void btnAddGradoAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmGradoAcademico())
            {
                frm.ShowDialog();
            }
            this.Show();
            CargarGradoAcademico();
        }

        private void dgvMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvMatricula.Rows[e.RowIndex];
            txtIdMatricula.Text = fila.Cells[0].Value.ToString();
            cbGradoAcademico.SelectedValue = fila.Cells[2].Value;
            dtpFechaMatricula.Value = Convert.ToDateTime(fila.Cells[3].Value);
            ckbEstado.Checked = Convert.ToBoolean(fila.Cells[4].Value);
        }
        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarGroupBoxs();
            deshabilitarBotonesPrincipales();
            btnModificar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificar.Visible = true;
            btnAgregar.Visible = true;
            cbGradoAcademico.Enabled = true;
            btnAddGradoAcademico.Enabled = true;
            habilitarBotonesPrincipales();
            deshabilitarGroupBoxs();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            deshabilitarBotonesPrincipales();
            gbxMatricula.Enabled = true;
            cbGradoAcademico.Enabled = false;
            btnAddGradoAcademico.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMatricula ga = new entMatricula();

                ga.IdInscripcion = Convert.ToInt32(txtBidInscripcion.Text);
                ga.IdGradoAcademico = Convert.ToInt32(cbGradoAcademico.SelectedValue);
                ga.FechaMatricula = dtpFechaMatricula.Value;
                ga.EstadoMatricula = ckbEstado.Checked;
                logMatricula.Instancia.InsertarMatricula(ga);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar matricula: " + ex.Message);
            }
            gbxMatricula.Enabled = false;
            ListarMatricula();
            ListarInscripcion();
            habilitarBotonesPrincipales();
            deshabilitarGroupBoxs();
            limpiarVariables();
        }

        private void btnAddInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmInscripcion())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMatricula ga = new entMatricula();
                ga.IdMatricula = int.Parse(txtIdMatricula.Text);
                logMatricula.Instancia.deshabilitarMatricula(ga);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar matricula: " + ex + MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxMatricula.Enabled = false;
            ListarMatricula();
            ListarInscripcion();
            habilitarBotonesPrincipales();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
