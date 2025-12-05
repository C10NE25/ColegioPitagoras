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
    public partial class frmMenuAdministrativo : Form
    {
        //Manejo de formularios
        public frmMenuAdministrativo()
        {
            InitializeComponent();
        }

        private void btnOpenAsignatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmAreaAcademica())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenNAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmNivelAcademico())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenPAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmPeriodoAcademico())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenSeccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmSeccion())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenTEvaluacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmTipoEvaluacion())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmInscripcion())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmMatricula())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenApoderado_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmApoderado())
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

        private void btnOpenTAsistencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmTipoAsistencia())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenTParentesco_Click(object sender, EventArgs e)
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
