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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
            //listarInscripciones();
            ListarInscripcion();
            ListarEstudiante();
            CargarEstudiante();
            deshabilitarGroupBoxs();
        }

        #region Metodos de Carga
        private void ListarInscripcion()
        {
            dgvInscripcion.DataSource = logInscripcion.Instancia.ListarInscripcion();
        }

        private void ListarEstudiante()
        {
            dgvEstudiante.DataSource = logEstudiante.Instancia.ListarEstudiantes();
        }

        private void CargarEstudiante()
        {
            List<entEstudiante> lista = logEstudiante.Instancia.ListarEstudiantes();
            cbEstudiante.DataSource = lista;
            cbEstudiante.ValueMember = "idEstudiante";
            cbEstudiante.DisplayMember = "NombreCompleto"; // Propiedad personalizada
        }
        #endregion
        #region Metodos para Controles
        private void deshabilitarGroupBoxs()
        {
            gbxInscripcion.Enabled = false;
            
        }
        private void habilitarGroupBoxs()
        {
            gbxInscripcion.Enabled = true;
            
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
            txtIdInscripcion.Clear();
            dtpFechaInscripcion.Value = DateTime.Now;
            cbEstudiante.SelectedIndex = -1;
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void cargarEstudiante()
        {
            List<entEstudiante> lista = logEstudiante.Instancia.ListarEstudiantes();
            cbEstudiante.DataSource = lista;
            cbEstudiante.ValueMember = "idEstudiante";
            cbEstudiante.DisplayMember = "nombreEst"; // Propiedad personalizada
        }


        private void btnAddEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmEstudiante())
            {
                frm.ShowDialog();
            }
            cargarEstudiante();
            this.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarGroupBoxs();
            deshabilitarBotonesPrincipales();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            deshabilitarBotonesPrincipales();
            gbxInscripcion.Enabled = true;
            cbEstudiante.Enabled = false;
            btnAddEstudiante.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entInscripcion ga = new entInscripcion();

                ga.IdEstudiante = Convert.ToInt32(cbEstudiante.SelectedValue);
                ga.FechaInscripcion = dtpFechaInscripcion.Value;
                ga.EstadoInscripcion = ckbEstado.Checked;
                logInscripcion.Instancia.InsertarInscripcion(ga);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar matricula: " + ex.Message);
            }
            gbxInscripcion.Enabled = false;
            ListarInscripcion();
            ListarInscripcion();
            habilitarBotonesPrincipales();
            deshabilitarGroupBoxs();
            limpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entInscripcion ga = new entInscripcion();
                ga.IdInscripcion = int.Parse(txtIdInscripcion.Text);
                logInscripcion.Instancia.DeshabilitarInscripcion(ga);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar matricula: " + ex + MessageBoxIcon.Error);
            }
            limpiarVariables();
            gbxInscripcion.Enabled = false;
            ListarInscripcion();
            ListarInscripcion();
            habilitarBotonesPrincipales();
        }
    }
}
