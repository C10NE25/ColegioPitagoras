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
        }

        public void CargarGradoAcademico()
        {
            List<entGradoAcademico> lista = logGradoAcademico.Instancia.ListarGradoAcademico();
            cbGradoAcademico.DataSource = lista;
            cbGradoAcademico.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbGradoAcademico.ValueMember = "IdGradoAcademico";
        }

        public void CargarAsignatura()
        {
            List<entGradoAcademico> lista = logGradoAcademico.Instancia.ListarGradoAcademico();
            cbAsignatura.DataSource = lista;
            cbAsignatura.DisplayMember = "NombreCompleto"; // Propiedad personalizada
            cbAsignatura.ValueMember = "IdAsignatura";
        }

        void deshabilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = false;
        }
        void habilitarBotonesPrincipales()
        {
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void limpiarVariables()
        {
            txtNombreCurso.Text = "";
        }


        public void ListarDetallePago()
        {
            dgvCurso.DataSource = logDetallePago.Instancia.ListarDetallePago();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        }
    }
}
