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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvNivelAcademico = new System.Windows.Forms.DataGridView();
            this.gbxNivelAcademico = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNivelAcademico = new System.Windows.Forms.TextBox();
            this.txtNombreNivel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivelAcademico)).BeginInit();
            this.gbxNivelAcademico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 56);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nivel Academico";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1645, 501);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 41;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1645, 361);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1645, 211);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1645, 644);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvNivelAcademico
            // 
            this.dgvNivelAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivelAcademico.Location = new System.Drawing.Point(108, 177);
            this.dgvNivelAcademico.Name = "dgvNivelAcademico";
            this.dgvNivelAcademico.ReadOnly = true;
            this.dgvNivelAcademico.RowHeadersWidth = 92;
            this.dgvNivelAcademico.RowTemplate.Height = 37;
            this.dgvNivelAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNivelAcademico.Size = new System.Drawing.Size(1399, 601);
            this.dgvNivelAcademico.TabIndex = 36;
            // 
            // gbxNivelAcademico
            // 
            this.gbxNivelAcademico.Controls.Add(this.cbxEstado);
            this.gbxNivelAcademico.Controls.Add(this.btnAgregar);
            this.gbxNivelAcademico.Controls.Add(this.btnModificar);
            this.gbxNivelAcademico.Controls.Add(this.btnCancelar);
            this.gbxNivelAcademico.Controls.Add(this.label3);
            this.gbxNivelAcademico.Controls.Add(this.label2);
            this.gbxNivelAcademico.Controls.Add(this.txtIDNivelAcademico);
            this.gbxNivelAcademico.Controls.Add(this.txtNombreNivel);
            this.gbxNivelAcademico.Location = new System.Drawing.Point(373, 860);
            this.gbxNivelAcademico.Name = "gbxNivelAcademico";
            this.gbxNivelAcademico.Size = new System.Drawing.Size(1025, 435);
            this.gbxNivelAcademico.TabIndex = 38;
            this.gbxNivelAcademico.TabStop = false;
            this.gbxNivelAcademico.Text = "Datos del Nivel Academico";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 208);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(221, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Nivel";
            this.cbxEstado.UseVisualStyleBackColor = true;
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
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Nivel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Nivel Academico:";
            // 
            // txtIDNivelAcademico
            // 
            this.txtIDNivelAcademico.Location = new System.Drawing.Point(311, 51);
            this.txtIDNivelAcademico.Name = "txtIDNivelAcademico";
            this.txtIDNivelAcademico.Size = new System.Drawing.Size(139, 35);
            this.txtIDNivelAcademico.TabIndex = 1;
            // 
            // txtNombreNivel
            // 
            this.txtNombreNivel.Location = new System.Drawing.Point(253, 124);
            this.txtNombreNivel.Name = "txtNombreNivel";
            this.txtNombreNivel.Size = new System.Drawing.Size(338, 35);
            this.txtNombreNivel.TabIndex = 0;
            // 
            // frmNivelAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvNivelAcademico);
            this.Controls.Add(this.gbxNivelAcademico);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvNivelAcademico;
        private System.Windows.Forms.GroupBox gbxNivelAcademico;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNivelAcademico;
        private System.Windows.Forms.TextBox txtNombreNivel;
    }
}