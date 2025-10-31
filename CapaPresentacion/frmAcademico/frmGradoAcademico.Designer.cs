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
            this.txtIDNivelAcademico = new System.Windows.Forms.TextBox();
            this.txtIDGradoAcademico = new System.Windows.Forms.TextBox();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradoAcademico)).BeginInit();
            this.gbxGradoAcademico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 56);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grado Academico";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1662, 506);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 35;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1662, 366);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1662, 216);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1662, 649);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvGradoAcademico
            // 
            this.dgvGradoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradoAcademico.Location = new System.Drawing.Point(125, 182);
            this.dgvGradoAcademico.Name = "dgvGradoAcademico";
            this.dgvGradoAcademico.ReadOnly = true;
            this.dgvGradoAcademico.RowHeadersWidth = 92;
            this.dgvGradoAcademico.RowTemplate.Height = 37;
            this.dgvGradoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradoAcademico.Size = new System.Drawing.Size(1399, 601);
            this.dgvGradoAcademico.TabIndex = 30;
            // 
            // gbxGradoAcademico
            // 
            this.gbxGradoAcademico.Controls.Add(this.cbxEstado);
            this.gbxGradoAcademico.Controls.Add(this.label7);
            this.gbxGradoAcademico.Controls.Add(this.btnAgregar);
            this.gbxGradoAcademico.Controls.Add(this.btnModificar);
            this.gbxGradoAcademico.Controls.Add(this.btnCancelar);
            this.gbxGradoAcademico.Controls.Add(this.label3);
            this.gbxGradoAcademico.Controls.Add(this.label2);
            this.gbxGradoAcademico.Controls.Add(this.txtIDNivelAcademico);
            this.gbxGradoAcademico.Controls.Add(this.txtIDGradoAcademico);
            this.gbxGradoAcademico.Controls.Add(this.txtNombreGrado);
            this.gbxGradoAcademico.Location = new System.Drawing.Point(390, 865);
            this.gbxGradoAcademico.Name = "gbxGradoAcademico";
            this.gbxGradoAcademico.Size = new System.Drawing.Size(1025, 435);
            this.gbxGradoAcademico.TabIndex = 32;
            this.gbxGradoAcademico.TabStop = false;
            this.gbxGradoAcademico.Text = "Datos del Grado Academico";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 278);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(233, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Grado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "IDNIvelAcademico:";
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
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Grado Academico:";
            // 
            // txtIDNivelAcademico
            // 
            this.txtIDNivelAcademico.Location = new System.Drawing.Point(253, 203);
            this.txtIDNivelAcademico.Name = "txtIDNivelAcademico";
            this.txtIDNivelAcademico.Size = new System.Drawing.Size(338, 35);
            this.txtIDNivelAcademico.TabIndex = 5;
            // 
            // txtIDGradoAcademico
            // 
            this.txtIDGradoAcademico.Location = new System.Drawing.Point(311, 51);
            this.txtIDGradoAcademico.Name = "txtIDGradoAcademico";
            this.txtIDGradoAcademico.Size = new System.Drawing.Size(139, 35);
            this.txtIDGradoAcademico.TabIndex = 1;
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.Location = new System.Drawing.Point(253, 124);
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.Size = new System.Drawing.Size(338, 35);
            this.txtNombreGrado.TabIndex = 0;
            // 
            // frmGradoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvGradoAcademico);
            this.Controls.Add(this.gbxGradoAcademico);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtIDNivelAcademico;
        private System.Windows.Forms.TextBox txtIDGradoAcademico;
        private System.Windows.Forms.TextBox txtNombreGrado;
    }
}