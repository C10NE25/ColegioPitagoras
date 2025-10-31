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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
            gbxDocente.Enabled = false;
            txtIDDocente.Enabled = false;
            listarDocente();
        }

        private void listarDocente()
        {
            dgvDocente.DataSource = logDocente.Instancia.listarDocentes();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxDocente.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
            btnModificar.Visible = false;
        }

        private void limpiarVariables()
        {
            txtIDDocente.Text = "";
            txtDniDocente.Text = "";
            txtNombreDocente.Text = "";
            txtApellidoDocente.Text = "";
            txtNroCelularDocente.Text = "";
            txtDireccionDocente.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entDocente docente = new entDocente();
                docente.DniDoc = txtDniDocente.Text.Trim();
                docente.NombreDoc = txtNombreDocente.Text.Trim();
                docente.ApellidosDoc = txtApellidoDocente.Text.Trim();
                docente.NumCelularDoc = txtNroCelularDocente.Text.Trim();
                docente.DireccionDoc = txtDireccionDocente.Text.Trim();
                docente.EstadoDoc=cbxEstado.Checked;
                logDocente.Instancia.insertarDocente(docente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar un docente: "+ex);
            }
            limpiarVariables();
            gbxDocente.Enabled = false;
            listarDocente();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxDocente.Enabled = true;
            btnModificar.Visible=true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entDocente docente = new entDocente();
                docente.IdDocente = int.Parse(txtIDDocente.Text.Trim());
                docente.DniDoc=txtDniDocente.Text.Trim();
                docente.NombreDoc = txtNombreDocente.Text.Trim();
                docente.ApellidosDoc = txtApellidoDocente.Text.Trim();
                docente.NumCelularDoc = txtNroCelularDocente.Text.Trim();
                docente.DireccionDoc = txtDireccionDocente.Text.Trim();
                docente.EstadoDoc=cbxEstado.Checked;
                logDocente.Instancia.editarDocente(docente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar docente: "+ex);
            }
            limpiarVariables();
            gbxDocente.Enabled = false;
            listarDocente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxDocente.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entDocente docente = new entDocente();
                docente.IdDocente = int.Parse(txtIDDocente.Text.Trim());
                cbxEstado.Checked = false;
                docente.EstadoDoc = cbxEstado.Checked;
                logDocente.Instancia.deshabilitarDocente(docente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar docente: " + ex);
            }
            limpiarVariables();
            gbxDocente.Enabled=false; listarDocente();
        }

        private void dgvDocente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDocente.ClearSelection();
        }

        private void dgvDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDocente.Rows[e.RowIndex];
            txtIDDocente.Text = fila.Cells[0].Value.ToString();
            txtDniDocente.Text = fila.Cells[1].Value.ToString();
            txtNombreDocente.Text = fila.Cells[2].Value.ToString();
            txtApellidoDocente.Text = fila.Cells[3].Value.ToString();
            txtNroCelularDocente.Text = fila.Cells[4].Value.ToString();
            txtDireccionDocente.Text = fila.Cells[5].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[6].Value);
        }
    }
}
