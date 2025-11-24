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
using CapaPresentacion.frmAcademico;

namespace CapaPresentacion
{
    public partial class frmApoderado : Form
    {
        public frmApoderado()
        {
            InitializeComponent();
            gbxTutor.Enabled = false;
            txtIDTutor.Enabled = false;
            cbxEstado.Checked = true;
            listarTutor();
            CargarParentesco();
        }

        private void listarTutor()
        {
            dgvTipoParentesco.DataSource = logApoderado.Instancia.ListarApoderados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            deshabilitarBotonesPrincipales();
            gbxTutor.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
        }

        private void limpiarVariables()
        {
            txtIDTutor.Text = "";
            txtDniTutor.Text = "";
            txtNombreTutor.Text = "";
            txtApellidoPTutor.Text = "";
            txtNroCelularTutor.Text = "";
            txtDireccionTutor.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Insertar Tutor
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.DniApo = txtDniTutor.Text.Trim();
                tutor.NombreApo = txtNombreTutor.Text.Trim();
                tutor.ApellidosPatApo = txtApellidoPTutor.Text.Trim();
                tutor.ApellidosMatApo = txtApellidoMTutor.Text.Trim();
                tutor.NumCelularApo = txtNroCelularTutor.Text.Trim();
                tutor.DireccionApo = txtDireccionTutor.Text.Trim();
                tutor.parentesco.IdParentesco = Convert.ToInt32(cbParentesco.SelectedValue);
                tutor.EstadoApo = cbxEstado.Checked;
                logApoderado.Instancia.InsertarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
            habilitarBotonesPrincipales();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            deshabilitarBotonesPrincipales();
            gbxTutor.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
                tutor.DniApo = txtDniTutor.Text.Trim();
                tutor.NombreApo = txtNombreTutor.Text.Trim();
                tutor.ApellidosPatApo = txtApellidoPTutor.Text.Trim();
                tutor.ApellidosMatApo = txtApellidoMTutor.Text.Trim();
                tutor.NumCelularApo = txtNroCelularTutor.Text.Trim();
                tutor.DireccionApo = txtDireccionTutor.Text.Trim();
                tutor.parentesco.IdParentesco = Convert.ToInt32(cbParentesco.SelectedValue);
                tutor.EstadoApo = cbxEstado.Checked;
                logApoderado.Instancia.EditarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
            habilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxTutor.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
                cbxEstado.Checked = false;
                tutor.EstadoApo = cbxEstado.Checked;
                logApoderado.Instancia.DeshabilitarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
        }

        private void dgvTutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTipoParentesco.Rows[e.RowIndex];
            txtIDTutor.Text = fila.Cells[0].Value.ToString();
            txtDniTutor.Text = fila.Cells[1].Value.ToString();
            txtNombreTutor.Text = fila.Cells[2].Value.ToString();
            txtApellidoPTutor.Text = fila.Cells[3].Value.ToString();
            txtApellidoMTutor.Text = fila.Cells[4].Value.ToString();
            txtNroCelularTutor.Text = fila.Cells[5].Value.ToString();
            txtDireccionTutor.Text = fila.Cells[6].Value.ToString();
            cbParentesco.SelectedValue = fila.Cells[7].Value;
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[8].Value);
        }

        private void dgvTutor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTipoParentesco.ClearSelection();
        }

        private void CargarParentesco()
        {
            List<entParentesco> lista = logParentesco.Instancia.ListarParentesco();
            cbParentesco.DataSource = lista;
            cbParentesco.ValueMember = "idParentesco";
            cbParentesco.DisplayMember = "tipoParentesco"; // Propiedad personalizada
        }

        private void btnAddTipoParentesco_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmTipoParentesco())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
