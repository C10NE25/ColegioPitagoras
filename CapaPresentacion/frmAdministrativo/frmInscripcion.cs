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
            listarInscripciones();
        }

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

        void listarInscripciones()
        {
            dgvInscripcion.DataSource = logInscripcion.Instancia.ListarInscripcion();
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
    }
}
