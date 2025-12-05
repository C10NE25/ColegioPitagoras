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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmViewEstudiante())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnApoderado_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmViewApoderado())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void bnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmViewInscripcion())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmViewMatricula())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
