namespace CapaPresentacion
{
    partial class frmAsistencias
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
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.gbxAsistencias = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMatriculaEst = new System.Windows.Forms.TextBox();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.gbxAsistencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 56);
            this.label1.TabIndex = 41;
            this.label1.Text = "Asistencias";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1681, 514);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 59;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1681, 374);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1681, 224);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 57;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1681, 657);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(144, 190);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.RowHeadersWidth = 92;
            this.dgvAsistencia.RowTemplate.Height = 37;
            this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencia.Size = new System.Drawing.Size(1432, 601);
            this.dgvAsistencia.TabIndex = 54;
            // 
            // gbxAsistencias
            // 
            this.gbxAsistencias.Controls.Add(this.label4);
            this.gbxAsistencias.Controls.Add(this.dtpFecha);
            this.gbxAsistencias.Controls.Add(this.cbxEstado);
            this.gbxAsistencias.Controls.Add(this.btnAgregar);
            this.gbxAsistencias.Controls.Add(this.btnModificar);
            this.gbxAsistencias.Controls.Add(this.btnCancelar);
            this.gbxAsistencias.Controls.Add(this.label3);
            this.gbxAsistencias.Controls.Add(this.label2);
            this.gbxAsistencias.Controls.Add(this.txtIDMatriculaEst);
            this.gbxAsistencias.Controls.Add(this.txtIDCurso);
            this.gbxAsistencias.Location = new System.Drawing.Point(371, 869);
            this.gbxAsistencias.Name = "gbxAsistencias";
            this.gbxAsistencias.Size = new System.Drawing.Size(1062, 435);
            this.gbxAsistencias.TabIndex = 56;
            this.gbxAsistencias.TabStop = false;
            this.gbxAsistencias.Text = "Asistencias de estudiantes";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(41, 280);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(142, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Presente";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(782, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(782, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(782, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(187, 191);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(460, 35);
            this.dtpFecha.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha:";
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2002, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.gbxAsistencias);
            this.Controls.Add(this.label1);
            this.Name = "frmAsistencias";
            this.Text = "frmAsistencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.gbxAsistencias.ResumeLayout(false);
            this.gbxAsistencias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.GroupBox gbxAsistencias;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMatriculaEst;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}