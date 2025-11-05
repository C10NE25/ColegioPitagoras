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
            txtBIDDocente.Enabled = false;
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
            txtBIDDocente.Text = "";
            txtBdniDocente.Text = "";
            txtBNombreDocente.Text = "";
            txtBApellidoPaternoDocente.Text = "";
            txtBTelefonoDocente.Text = "";
            txtBDireccionDocente.Text = "";
            cbxEstadoDocente.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entDocente docente = new entDocente();
                docente.DniDoc = txtBdniDocente.Text.Trim();
                docente.NombreDoc = txtBNombreDocente.Text.Trim();
                docente.ApellidosDoc = txtBApellidoPaternoDocente.Text.Trim();
                docente.NumCelularDoc = txtBTelefonoDocente.Text.Trim();
                docente.DireccionDoc = txtBDireccionDocente.Text.Trim();
                docente.EstadoDoc=cbxEstadoDocente.Checked;
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

        private void dgvDocente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDocente.Rows[e.RowIndex];
            txtBIDDocente.Text = fila.Cells[0].Value.ToString();
            txtBdniDocente.Text = fila.Cells[1].Value.ToString();
            txtBNombreDocente.Text = fila.Cells[2].Value.ToString();
            txtBApellidoPaternoDocente.Text = fila.Cells[3].Value.ToString();
            txtBTelefonoDocente.Text = fila.Cells[4].Value.ToString();
            txtBDireccionDocente.Text = fila.Cells[5].Value.ToString();
            cbxEstadoDocente.Checked = Convert.ToBoolean(fila.Cells[6].Value);
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
                docente.IdDocente = int.Parse(txtBIDDocente.Text.Trim());
                docente.DniDoc=txtBdniDocente.Text.Trim();
                docente.NombreDoc = txtBNombreDocente.Text.Trim();
                docente.ApellidosDoc = txtBApellidoPaternoDocente.Text.Trim();
                docente.NumCelularDoc = txtBTelefonoDocente.Text.Trim();
                docente.DireccionDoc = txtBDireccionDocente.Text.Trim();
                docente.EstadoDoc=cbxEstadoDocente.Checked;
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
                docente.IdDocente = int.Parse(txtBIDDocente.Text.Trim());
                cbxEstadoDocente.Checked = false;
                docente.EstadoDoc = cbxEstadoDocente.Checked;
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
    }
}
