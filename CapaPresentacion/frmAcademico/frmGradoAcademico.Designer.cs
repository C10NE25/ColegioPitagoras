namespace CapaPresentacion
{
    partial class frmGradoAcademico
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
            this.dgvGradoAcademico = new System.Windows.Forms.DataGridView();
            this.gbxGradoAcademico = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDGradoAcademico = new System.Windows.Forms.TextBox();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradoAcademico)).BeginInit();
            this.gbxGradoAcademico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grado Academico";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(399, 248);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(100, 30);
            this.btnDeshabilitar.TabIndex = 35;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(295, 247);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 31);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(191, 248);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(503, 250);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvGradoAcademico
            // 
            this.dgvGradoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradoAcademico.Location = new System.Drawing.Point(17, 52);
            this.dgvGradoAcademico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGradoAcademico.Name = "dgvGradoAcademico";
            this.dgvGradoAcademico.ReadOnly = true;
            this.dgvGradoAcademico.RowHeadersWidth = 92;
            this.dgvGradoAcademico.RowTemplate.Height = 37;
            this.dgvGradoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradoAcademico.Size = new System.Drawing.Size(586, 182);
            this.dgvGradoAcademico.TabIndex = 30;
            // 
            // gbxGradoAcademico
            // 
            this.gbxGradoAcademico.Controls.Add(this.cbSeccion);
            this.gbxGradoAcademico.Controls.Add(this.cbNivelAcademico);
            this.gbxGradoAcademico.Controls.Add(this.label4);
            this.gbxGradoAcademico.Controls.Add(this.cbxEstado);
            this.gbxGradoAcademico.Controls.Add(this.label7);
            this.gbxGradoAcademico.Controls.Add(this.btnAgregar);
            this.gbxGradoAcademico.Controls.Add(this.btnModificar);
            this.gbxGradoAcademico.Controls.Add(this.btnCancelar);
            this.gbxGradoAcademico.Controls.Add(this.label3);
            this.gbxGradoAcademico.Controls.Add(this.label2);
            this.gbxGradoAcademico.Controls.Add(this.txtIDGradoAcademico);
            this.gbxGradoAcademico.Controls.Add(this.txtNombreGrado);
            this.gbxGradoAcademico.Location = new System.Drawing.Point(17, 298);
            this.gbxGradoAcademico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGradoAcademico.Name = "gbxGradoAcademico";
            this.gbxGradoAcademico.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGradoAcademico.Size = new System.Drawing.Size(586, 240);
            this.gbxGradoAcademico.TabIndex = 32;
            this.gbxGradoAcademico.TabStop = false;
            this.gbxGradoAcademico.Text = "Datos del Grado Academico";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(178, 190);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(135, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Grado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nivel Academico";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(423, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(423, 72);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 31);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(423, 112);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Grado Academico:";
            // 
            // txtIDGradoAcademico
            // 
            this.txtIDGradoAcademico.Location = new System.Drawing.Point(178, 28);
            this.txtIDGradoAcademico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDGradoAcademico.Name = "txtIDGradoAcademico";
            this.txtIDGradoAcademico.Size = new System.Drawing.Size(81, 22);
            this.txtIDGradoAcademico.TabIndex = 1;
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.Location = new System.Drawing.Point(145, 68);
            this.txtNombreGrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.Size = new System.Drawing.Size(195, 22);
            this.txtNombreGrado.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seccion";
            // 
            // cbNivelAcademico
            // 
            this.cbNivelAcademico.FormattingEnabled = true;
            this.cbNivelAcademico.Location = new System.Drawing.Point(145, 112);
            this.cbNivelAcademico.Name = "cbNivelAcademico";
            this.cbNivelAcademico.Size = new System.Drawing.Size(195, 24);
            this.cbNivelAcademico.TabIndex = 15;
            // 
            // cbSeccion
            // 
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(145, 147);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(195, 24);
            this.cbSeccion.TabIndex = 16;
            // 
            // frmGradoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 567);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvGradoAcademico);
            this.Controls.Add(this.gbxGradoAcademico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGradoAcademico";
            this.Text = "frmGradoAcademico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradoAcademico)).EndInit();
            this.gbxGradoAcademico.ResumeLayout(false);
            this.gbxGradoAcademico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvGradoAcademico;
        private System.Windows.Forms.GroupBox gbxGradoAcademico;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDGradoAcademico;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox cbNivelAcademico;
        private System.Windows.Forms.Label label4;
    }
}