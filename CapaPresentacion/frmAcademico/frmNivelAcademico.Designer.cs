namespace CapaPresentacion
{
    partial class frmNivelAcademico
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
            this.dgvNivelAcademico = new System.Windows.Forms.DataGridView();
            this.gbxNivelAcademico = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNivelAcademico = new System.Windows.Forms.TextBox();
            this.txtNombreNivel = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivelAcademico)).BeginInit();
            this.gbxNivelAcademico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nivel Academico";
            // 
            // dgvNivelAcademico
            // 
            this.dgvNivelAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivelAcademico.Location = new System.Drawing.Point(15, 36);
            this.dgvNivelAcademico.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvNivelAcademico.Name = "dgvNivelAcademico";
            this.dgvNivelAcademico.ReadOnly = true;
            this.dgvNivelAcademico.RowHeadersWidth = 92;
            this.dgvNivelAcademico.RowTemplate.Height = 37;
            this.dgvNivelAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNivelAcademico.Size = new System.Drawing.Size(633, 195);
            this.dgvNivelAcademico.TabIndex = 36;
            // 
            // gbxNivelAcademico
            // 
            this.gbxNivelAcademico.Controls.Add(this.btnAgregar);
            this.gbxNivelAcademico.Controls.Add(this.btnModificar);
            this.gbxNivelAcademico.Controls.Add(this.btnCancelar);
            this.gbxNivelAcademico.Controls.Add(this.cbxEstado);
            this.gbxNivelAcademico.Controls.Add(this.label3);
            this.gbxNivelAcademico.Controls.Add(this.label2);
            this.gbxNivelAcademico.Controls.Add(this.txtIDNivelAcademico);
            this.gbxNivelAcademico.Controls.Add(this.txtNombreNivel);
            this.gbxNivelAcademico.Location = new System.Drawing.Point(15, 250);
            this.gbxNivelAcademico.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxNivelAcademico.Name = "gbxNivelAcademico";
            this.gbxNivelAcademico.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxNivelAcademico.Size = new System.Drawing.Size(439, 195);
            this.gbxNivelAcademico.TabIndex = 38;
            this.gbxNivelAcademico.TabStop = false;
            this.gbxNivelAcademico.Text = "Datos del Nivel Academico";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(14, 93);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(103, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Nivel";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Nivel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Nivel Academico:";
            // 
            // txtIDNivelAcademico
            // 
            this.txtIDNivelAcademico.Location = new System.Drawing.Point(198, 19);
            this.txtIDNivelAcademico.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtIDNivelAcademico.Name = "txtIDNivelAcademico";
            this.txtIDNivelAcademico.Size = new System.Drawing.Size(57, 20);
            this.txtIDNivelAcademico.TabIndex = 1;
            // 
            // txtNombreNivel
            // 
            this.txtNombreNivel.Location = new System.Drawing.Point(108, 56);
            this.txtNombreNivel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNombreNivel.Name = "txtNombreNivel";
            this.txtNombreNivel.Size = new System.Drawing.Size(147, 20);
            this.txtNombreNivel.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(124, 151);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(225, 151);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(326, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(549, 375);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 26);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(549, 250);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 27);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(549, 296);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 27);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(549, 336);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(99, 27);
            this.btnDeshabilitar.TabIndex = 42;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // frmNivelAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 479);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvNivelAcademico);
            this.Controls.Add(this.gbxNivelAcademico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmNivelAcademico";
            this.Text = "frmNivelAcademico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivelAcademico)).EndInit();
            this.gbxNivelAcademico.ResumeLayout(false);
            this.gbxNivelAcademico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNivelAcademico;
        private System.Windows.Forms.GroupBox gbxNivelAcademico;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNivelAcademico;
        private System.Windows.Forms.TextBox txtNombreNivel;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}