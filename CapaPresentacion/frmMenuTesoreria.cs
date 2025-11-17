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
    public partial class frmMenuTesoreria : Form
    {
        public frmMenuTesoreria()
        {
            InitializeComponent();
        }

        private void btnOpenModalidaPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmModalidadPago())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenNAcademico_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmTipoCargo())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnOpenApoderado_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new frmDetallePago())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
