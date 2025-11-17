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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
            CargarAsignatura();
            CargarGradoAcademico();
            ListarCurso();
            ListarDocente();
            gbxCurso.Enabled = false;
            cbxEstado.Checked = true;
        }
        private int idDocente;
        public void ListarCurso()
        {
            dgvCurso.DataSource = logCurso.Instancia.ListarCurso();
        }
        public void ListarDocente()
        {
            dgvDocente.DataSource = logDocente.Instancia.listarDocentes();
        }
        public void CargarGradoAcademico()
        {
            List<entGradoAcademico> lista = logGradoAcademico.Instancia.ListarGradoAcademico();
            cbGradoAcademico.DataSource = lista;
            cbGradoAcademico.DisplayMember = "nombreGradoAcademico";
            cbGradoAcademico.ValueMember = "idGradoAcademico";
        }

        public void CargarAsignatura()
        {
            List<entAsignatura> lista = logAsignatura.Instancia.ListarAsignatura();
            cbAsignatura.DataSource = lista;
            cbAsignatura.DisplayMember = "nombreAsignatura";
            cbAsignatura.ValueMember = "idAsignatura";
        }

        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtNombreCurso.Clear();
            txtBNameDocente.Clear();
            txtBApellidoPDocente.Clear();
            txtBApellidoMDocente.Clear();
            txtBDniDocente.Clear();
            txtBSearchDocente.Clear();
            txtIDCurso.Clear();
            txtNombreCurso.Clear();
        }
        private void btnAddGradoAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmGradoAcademico())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
        private void btnAddAsignatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmAsignatura())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosDocente.Enabled = true;
            gbxCurso.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCurso curso = new entCurso();
                curso.NombreCurso = txtNombreCurso.Text.Trim();
                curso.IdDocente = idDocente;
                curso.IdGradoAcademico = Convert.ToInt32(cbGradoAcademico.SelectedValue);
                curso.IdAsignatura = Convert.ToInt32(cbAsignatura.SelectedValue);
                curso.EstadoCurso = cbxEstado.Checked;
                logCurso.Instancia.InsertarCurso(curso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar curso: " + ex);
            }
            limpiarVariables();
            gbDatosDocente.Enabled = false;
            ListarCurso();
            habilitarBotonesPrincipales();
        }

        private void dgvDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDocente.Rows[e.RowIndex];
            idDocente = Convert.ToInt32(fila.Cells[0].Value);
            txtBNameDocente.Text = fila.Cells[2].Value.ToString();
            txtBApellidoPDocente.Text = fila.Cells[3].Value.ToString();
            txtBApellidoMDocente.Text = fila.Cells[4].Value.ToString();
            txtBDniDocente.Text = fila.Cells[1].Value.ToString();
            txtBSearchDocente.Text = fila.Cells[1].Value.ToString();
        }

        private void btnSearchDocente_Click(object sender, EventArgs e)
        {
            var doc = logDocente.Instancia.searchDocente(txtBSearchDocente.Text.Trim());
            if (doc != null)
            {
                txtBNameDocente.Text = doc.NombreDoc;
                txtBApellidoPDocente.Text = doc.ApellidosPatDoc;
                txtBApellidoMDocente.Text = doc.ApellidosMatDoc;
                txtBDniDocente.Text = doc.DniDoc;
                idDocente = doc.IdDocente;
            }
            else
            {
                MessageBox.Show("No se encontro el Docente");
            }
        }

        private void btnAddDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmDocente())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxCurso.Enabled = false;
            gbDatosDocente.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxCurso.Enabled = true;
            gbDatosDocente.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
