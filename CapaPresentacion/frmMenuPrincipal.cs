using CapaPresentacion.frmAcademico;
using CapaPresentacion.frmTesoreria;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmEstudiante())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmDocente())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenCurso_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmCurso())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenGAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmGradoAcademico())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenAsistencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmAsistencias())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmNotas())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnAbrirDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmDocente())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenAdministrativo_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmMenuAdministrativo())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenTesoreria_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmMenuTesoreria())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnAbrirConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmConsulta())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
