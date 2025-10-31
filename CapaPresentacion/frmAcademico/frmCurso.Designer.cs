namespace CapaPresentacion
{
    partial class frmCurso
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
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.gbxCurso = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDDocente = new System.Windows.Forms.TextBox();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradoAcademico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.gbxCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 56);
            this.label1.TabIndex = 35;
            this.label1.Text = "Curso";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1642, 508);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 41;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1642, 368);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1642, 218);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1642, 651);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(105, 184);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersWidth = 92;
            this.dgvCurso.RowTemplate.Height = 37;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(1399, 601);
            this.dgvCurso.TabIndex = 36;
            // 
            // gbxCurso
            // 
            this.gbxCurso.Controls.Add(this.label4);
            this.gbxCurso.Controls.Add(this.txtGradoAcademico);
            this.gbxCurso.Controls.Add(this.cbxEstado);
            this.gbxCurso.Controls.Add(this.label7);
            this.gbxCurso.Controls.Add(this.btnAgregar);
            this.gbxCurso.Controls.Add(this.btnModificar);
            this.gbxCurso.Controls.Add(this.btnCancelar);
            this.gbxCurso.Controls.Add(this.label3);
            this.gbxCurso.Controls.Add(this.label2);
            this.gbxCurso.Controls.Add(this.txtIDDocente);
            this.gbxCurso.Controls.Add(this.txtIDCurso);
            this.gbxCurso.Controls.Add(this.txtNombreCurso);
            this.gbxCurso.Location = new System.Drawing.Point(370, 867);
            this.gbxCurso.Name = "gbxCurso";
            this.gbxCurso.Size = new System.Drawing.Size(1025, 435);
            this.gbxCurso.TabIndex = 38;
            this.gbxCurso.TabStop = false;
            this.gbxCurso.Text = "Datos del Curso";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 330);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(230, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Curso";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID del Docente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(719, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(719, 177);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(719, 299);
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
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Curso:";
            // 
            // txtIDDocente
            // 
            this.txtIDDocente.Location = new System.Drawing.Point(253, 203);
            this.txtIDDocente.Name = "txtIDDocente";
            this.txtIDDocente.Size = new System.Drawing.Size(338, 35);
            this.txtIDDocente.TabIndex = 5;
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Location = new System.Drawing.Point(311, 51);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(139, 35);
            this.txtIDCurso.TabIndex = 1;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(253, 124);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(338, 35);
            this.txtNombreCurso.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID del Grado Academico:";
            // 
            // txtGradoAcademico
            // 
            this.txtGradoAcademico.Location = new System.Drawing.Point(311, 257);
            this.txtGradoAcademico.Name = "txtGradoAcademico";
            this.txtGradoAcademico.Size = new System.Drawing.Size(338, 35);
            this.txtGradoAcademico.TabIndex = 14;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.gbxCurso);
            this.Controls.Add(this.label1);
            this.Name = "frmCurso";
            this.Text = "frmCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.gbxCurso.ResumeLayout(false);
            this.gbxCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.GroupBox gbxCurso;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDDocente;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradoAcademico;
    }
}