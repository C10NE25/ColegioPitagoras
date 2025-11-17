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
