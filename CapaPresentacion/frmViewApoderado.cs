using CapaLogica;
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
    public partial class frmViewApoderado : Form
    {
        public frmViewApoderado()
        {
            InitializeComponent();
            cargarDataGridView();
        }
        void cargarDataGridView()
        {
            dgvApoderado.DataSource = logApoderado.Instancia.ListarApoderados();
        }
    }
}
