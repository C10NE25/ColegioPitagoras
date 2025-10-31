namespace CapaPresentacion
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.gbxNotas = new System.Windows.Forms.GroupBox();
            this.cmbTipoEvaluacion = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaNumerica = new System.Windows.Forms.TextBox();
            this.txtIDMatriculaEst = new System.Windows.Forms.TextBox();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatriculaBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.gbxNotas.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 56);
            this.label1.TabIndex = 47;
            this.label1.Text = "Notas";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1645, 491);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 53;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1645, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1645, 201);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1645, 634);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvNota
            // 
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(107, 255);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.ReadOnly = true;
            this.dgvNota.RowHeadersWidth = 92;
            this.dgvNota.RowTemplate.Height = 37;
            this.dgvNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNota.Size = new System.Drawing.Size(1432, 601);
            this.dgvNota.TabIndex = 48;
            // 
            // gbxNotas
            // 
            this.gbxNotas.Controls.Add(this.cmbTipoEvaluacion);
            this.gbxNotas.Controls.Add(this.cbxEstado);
            this.gbxNotas.Controls.Add(this.btnAgregar);
            this.gbxNotas.Controls.Add(this.btnModificar);
            this.gbxNotas.Controls.Add(this.btnCancelar);
            this.gbxNotas.Controls.Add(this.label5);
            this.gbxNotas.Controls.Add(this.label4);
            this.gbxNotas.Controls.Add(this.label3);
            this.gbxNotas.Controls.Add(this.label2);
            this.gbxNotas.Controls.Add(this.txtNotaNumerica);
            this.gbxNotas.Controls.Add(this.txtIDMatriculaEst);
            this.gbxNotas.Controls.Add(this.txtIDCurso);
            this.gbxNotas.Location = new System.Drawing.Point(120, 906);
            this.gbxNotas.Name = "gbxNotas";
            this.gbxNotas.Size = new System.Drawing.Size(1562, 435);
            this.gbxNotas.TabIndex = 50;
            this.gbxNotas.TabStop = false;
            this.gbxNotas.Text = "Notas de estudiantes";
            // 
            // cmbTipoEvaluacion
            // 
            this.cmbTipoEvaluacion.FormattingEnabled = true;
            this.cmbTipoEvaluacion.Location = new System.Drawing.Point(259, 192);
            this.cmbTipoEvaluacion.Name = "cmbTipoEvaluacion";
            this.cmbTipoEvaluacion.Size = new System.Drawing.Size(274, 37);
            this.cmbTipoEvaluacion.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(693, 130);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(236, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado de la Nota";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(1282, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(1282, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1282, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota Numerica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Evaluacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "IDCurso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Matricula Estudiante:";
            // 
            // txtNotaNumerica
            // 
            this.txtNotaNumerica.Location = new System.Drawing.Point(804, 51);
            this.txtNotaNumerica.Name = "txtNotaNumerica";
            this.txtNotaNumerica.Size = new System.Drawing.Size(338, 35);
            this.txtNotaNumerica.TabIndex = 3;
            // 
            // txtIDMatriculaEst
            // 
            this.txtIDMatriculaEst.Location = new System.Drawing.Point(304, 54);
            this.txtIDMatriculaEst.Name = "txtIDMatriculaEst";
            this.txtIDMatriculaEst.Size = new System.Drawing.Size(139, 35);
            this.txtIDMatriculaEst.TabIndex = 1;
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Location = new System.Drawing.Point(179, 127);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(338, 35);
            this.txtIDCurso.TabIndex = 0;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.btnBuscar);
            this.gbxBusqueda.Controls.Add(this.txtMatriculaBusqueda);
            this.gbxBusqueda.Controls.Add(this.label6);
            this.gbxBusqueda.Location = new System.Drawing.Point(264, 129);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(1221, 93);
            this.gbxBusqueda.TabIndex = 54;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Busqueda de Notas por Alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Id Matricula Estudiante:";
            // 
            // txtMatriculaBusqueda
            // 
            this.txtMatriculaBusqueda.Location = new System.Drawing.Point(287, 45);
            this.txtMatriculaBusqueda.Name = "txtMatriculaBusqueda";
            this.txtMatriculaBusqueda.Size = new System.Drawing.Size(158, 35);
            this.txtMatriculaBusqueda.TabIndex = 56;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(628, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(224, 61);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1959, 1374);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.gbxNotas);
            this.Controls.Add(this.label1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.gbxNotas.ResumeLayout(false);
            this.gbxNotas.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.GroupBox gbxNotas;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaNumerica;
        private System.Windows.Forms.TextBox txtIDMatriculaEst;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.ComboBox cmbTipoEvaluacion;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMatriculaBusqueda;
        private System.Windows.Forms.Label label6;
    }
}