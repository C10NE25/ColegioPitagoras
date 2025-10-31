﻿using System;
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
    public partial class frmTutor : Form
    {
        public frmTutor()
        {
            InitializeComponent();
            gbxTutor.Enabled = false;
            txtIDTutor.Enabled = false;
            listarTutor();

        }

        private void listarTutor()
        {
            dgvTutor.DataSource = logApoderado.Instancia.ListarApoderados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxTutor.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiarVariables();
        }

        private void limpiarVariables()
        {
            txtIDTutor.Text = "";
            txtDniTutor.Text = "";
            txtNombreTutor.Text = "";
            txtApellidoTutor.Text = "";
            txtNroCelularTutor.Text = "";
            txtDireccionTutor.Text = "";
            cbxEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Insertar Tutor
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.DniApo = txtDniTutor.Text.Trim();
                tutor.NombreApo = txtNombreTutor.Text.Trim();
                tutor.ApellidosApo = txtApellidoTutor.Text.Trim();
                tutor.NumCelularApo = txtNroCelularTutor.Text.Trim();
                tutor.DireccionApo = txtDireccionTutor.Text.Trim();
                tutor.EstadoApot = cbxEstado.Checked;
                logApoderado.Instancia.InsertarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbxTutor.Enabled=true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
                tutor.DniApo = txtDniTutor.Text.Trim();
                tutor.NombreApo = txtNombreTutor.Text.Trim();
                tutor.ApellidosApo = txtApellidoTutor.Text.Trim();
                tutor.NumCelularApo = txtNroCelularTutor.Text.Trim();
                tutor.DireccionApo = txtDireccionTutor.Text.Trim();
                tutor.EstadoApot = cbxEstado.Checked;
                logApoderado.Instancia.EditarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxTutor.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entApoderado tutor = new entApoderado();
                tutor.IdApoderado = Convert.ToInt32(txtIDTutor.Text.Trim());
                cbxEstado.Checked = false;
                tutor.EstadoApot = cbxEstado.Checked;
                logApoderado.Instancia.DeshabilitarApoderado(tutor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar tutor: " + ex.Message);
            }
            limpiarVariables();
            gbxTutor.Enabled = false;
            listarTutor();
        }

        private void dgvTutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTutor.Rows[e.RowIndex];
            txtIDTutor.Text = fila.Cells[0].Value.ToString();
            txtDniTutor.Text = fila.Cells[1].Value.ToString();
            txtNombreTutor.Text = fila.Cells[2].Value.ToString();
            txtApellidoTutor.Text = fila.Cells[3].Value.ToString();
            txtNroCelularTutor.Text = fila.Cells[4].Value.ToString();
            txtDireccionTutor.Text = fila.Cells[5].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(fila.Cells[6].Value);
        }
    }
}
