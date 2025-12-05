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
    public partial class frmViewInscripcion : Form
    {
        public frmViewInscripcion()
        {
            InitializeComponent();
            cargarDataGridView();
        }
        void cargarDataGridView()
        {
            dgvInscripcion.DataSource = logInscripcion.Instancia.ListarInscripcion();
        }
    }
}
