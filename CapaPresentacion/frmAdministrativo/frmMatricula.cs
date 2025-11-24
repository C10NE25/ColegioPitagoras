using CapaEntidad;
using CapaLogica;
using CapaPresentacion.VistasClases;
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
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
            ListarInscripcion();
            ListarMatricula();
        }
        public void ListarInscripcion() {
            var listaOriginal = logInscripcion.Instancia.ListarInscripcion();
            var listaVista = listaOriginal.Select(x => new InscripcionView
            {
                IdInscripcion = x.IdInscripcion,
                IdEstudiante = x.estudiante.IdEstudiante,
                FechaInscripcion = x.FechaInscripcion,
                Estado = x.EstadoInscripcion
            }).ToList();
            dgvInscripcion.DataSource = listaVista;
        }
        private void ListarMatricula()
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchInscripcion_Click(object sender, EventArgs e)
        {
            int idInscripcion = int.Parse(txtBSearchInscripcion.Text);
            entInscripcion inscripcion = logInscripcion.Instancia.BuscarInscripcionPorId(idInscripcion);

            if (inscripcion != null)
            {
                txtBNameEstudiante.Text = inscripcion.estudiante.NombreEst.ToString();
                txtBApellidoPEstudiante.Text = inscripcion.estudiante.ApellidosPatEst.ToString();
                txtBApellidoMEstudiante.Text = inscripcion.estudiante.ApellidosMatEst.ToString();
                txtBDniEstudiante.Text = inscripcion.estudiante.DniEst.ToString();
                MessageBox.Show($"Inscripcion encontrada, estudiante: {inscripcion.estudiante.NombreEst}");
            }
            else
            {
                MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
