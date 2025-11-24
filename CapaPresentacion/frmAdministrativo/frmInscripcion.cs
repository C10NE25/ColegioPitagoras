using CapaEntidad;
using CapaLogica;
using CapaPresentacion.VistasClases;
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
    public partial class frmInscripcion : Form
    {
        private int idEstudiante;
        public frmInscripcion()
        {
            InitializeComponent();
            gbxInscripcion.Enabled = false;
            gbSearchEstudiante.Enabled = false;
            cbxEstado.Checked = true;
            dtpFechaInscripcion.Value = DateTime.Now;
            ListarInscripciones();
            ListarEstudiante();
        }
        public void ListarInscripciones()
        {
            var listaOriginal = logInscripcion.Instancia.ListarInscripcion();
            var listaVista = listaOriginal.Select(x => new InscripcionView
            {
                IdInscripcion = x.IdInscripcion,
                IdEstudiante = x.estudiante.IdEstudiante,
                FechaInscripcion = x.FechaInscripcion,
                Estado = x.EstadoInscripcion
            }).ToList();
            dgvInscripcion.DataSource = listaVista;
        }
        public void ListarEstudiante() { 
            dgvEstudiante.DataSource = logEstudiante.Instancia.ListarEstudiantes();
        }
        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }
        private void limpiarVariables()
        {
            txtBApellidoMEstudiante.Clear();
            txtBApellidoPEstudiante.Clear();
            txtBDniEstudiante.Clear();
            txtBNameEstudiante.Clear();
            txtBSearchEstudiante.Clear();
            txtIdInscripcion.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxInscripcion.Enabled = true;
            gbSearchEstudiante.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
            deshabilitarBotonesPrincipales();
        }

        private void btnAddEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formEstudiante = new frmEstudiante())
            {
                formEstudiante.ShowDialog();
            }
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbSearchEstudiante.Enabled = false;
            gbxInscripcion.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            deshabilitarBotonesPrincipales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxInscripcion.Enabled = false;
            gbSearchEstudiante.Enabled = false;
            habilitarBotonesPrincipales();
        }

        private void btnSearchEstudiante_Click(object sender, EventArgs e)
        {
            var est = logEstudiante.Instancia.BuscarEstudiantePorDni(txtBSearchEstudiante.Text.Trim());
            if (est != null)
            {
                txtBNameEstudiante.Text = est.NombreEst;
                txtBApellidoPEstudiante.Text = est.ApellidosPatEst;
                txtBApellidoMEstudiante.Text = est.ApellidosMatEst;
                txtBDniEstudiante.Text = est.DniEst;
                idEstudiante = est.IdEstudiante;
            }
            else
            {
                MessageBox.Show("No se encontro el Estudiante");
            }
        }

        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvInscripcion.Rows[e.RowIndex];
            txtIdInscripcion.Text = fila.Cells[0].Value.ToString();
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEstudiante.Rows[e.RowIndex];
            idEstudiante = Convert.ToInt32(fila.Cells[0].Value);
            txtBNameEstudiante.Text = fila.Cells[2].Value.ToString();
            txtBApellidoPEstudiante.Text = fila.Cells[3].Value.ToString();
            txtBApellidoMEstudiante.Text = fila.Cells[4].Value.ToString();
            txtBDniEstudiante.Text = fila.Cells[1].Value.ToString();
            txtBSearchEstudiante.Text = fila.Cells[1].Value.ToString();
            btnSearchEstudiante.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entInscripcion insc = new entInscripcion();
                insc.estudiante = new entEstudiante();
                insc.estudiante.IdEstudiante = idEstudiante;
                insc.FechaInscripcion = dtpFechaInscripcion.Value;
                insc.EstadoInscripcion = cbxEstado.Checked;
                logInscripcion.Instancia.InsertarInscripcion(insc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar inscripcion: " + ex);
            }
            limpiarVariables();
            gbSearchEstudiante.Enabled = false;
            gbxInscripcion.Enabled = false;
            ListarEstudiante();
            ListarInscripciones();
            habilitarBotonesPrincipales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entInscripcion insc = new entInscripcion();
                insc.IdInscripcion = Convert.ToInt32(txtIdInscripcion.Text);
                logInscripcion.Instancia.DeshabilitarInscripcion(insc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar inscripcion: " + ex);
            }
            ListarInscripciones();
            ListarEstudiante();
            deshabilitarBotonesPrincipales();
            limpiarVariables();
        }
    }
}
