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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidNAcademico = new System.Windows.Forms.Label();
            this.txtIDNivelAcademico = new System.Windows.Forms.TextBox();
            this.txtNombreNivel = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.dgvNivelAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.dgvNivelAcademico.Name = "dgvNivelAcademico";
            this.dgvNivelAcademico.ReadOnly = true;
            this.dgvNivelAcademico.RowHeadersWidth = 30;
            this.dgvNivelAcademico.RowTemplate.Height = 37;
            this.dgvNivelAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNivelAcademico.Size = new System.Drawing.Size(328, 406);
            this.dgvNivelAcademico.TabIndex = 36;
            this.dgvNivelAcademico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNivelAcademico_CellClick);
            // 
            // gbxNivelAcademico
            // 
            this.gbxNivelAcademico.Controls.Add(this.btnAgregar);
            this.gbxNivelAcademico.Controls.Add(this.btnModificar);
            this.gbxNivelAcademico.Controls.Add(this.btnCancelar);
            this.gbxNivelAcademico.Controls.Add(this.cbxEstado);
            this.gbxNivelAcademico.Controls.Add(this.label3);
            this.gbxNivelAcademico.Controls.Add(this.lblidNAcademico);
            this.gbxNivelAcademico.Controls.Add(this.txtIDNivelAcademico);
            this.gbxNivelAcademico.Controls.Add(this.txtNombreNivel);
            this.gbxNivelAcademico.Location = new System.Drawing.Point(355, 36);
            this.gbxNivelAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.gbxNivelAcademico.Name = "gbxNivelAcademico";
            this.gbxNivelAcademico.Padding = new System.Windows.Forms.Padding(1);
            this.gbxNivelAcademico.Size = new System.Drawing.Size(328, 170);
            this.gbxNivelAcademico.TabIndex = 38;
            this.gbxNivelAcademico.TabStop = false;
            this.gbxNivelAcademico.Text = "Datos del Nivel Academico";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(13, 126);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(114, 126);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(215, 126);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(14, 93);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(103, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Nivel";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Nivel:";
            // 
            // lblidNAcademico
            // 
            this.lblidNAcademico.AutoSize = true;
            this.lblidNAcademico.Location = new System.Drawing.Point(12, 33);
            this.lblidNAcademico.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidNAcademico.Name = "lblidNAcademico";
            this.lblidNAcademico.Size = new System.Drawing.Size(21, 13);
            this.lblidNAcademico.TabIndex = 7;
            this.lblidNAcademico.Text = "ID:";
            // 
            // txtIDNivelAcademico
            // 
            this.txtIDNivelAcademico.Location = new System.Drawing.Point(108, 26);
            this.txtIDNivelAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.txtIDNivelAcademico.Name = "txtIDNivelAcademico";
            this.txtIDNivelAcademico.Size = new System.Drawing.Size(57, 20);
            this.txtIDNivelAcademico.TabIndex = 1;
            // 
            // txtNombreNivel
            // 
            this.txtNombreNivel.Location = new System.Drawing.Point(108, 60);
            this.txtNombreNivel.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreNivel.Name = "txtNombreNivel";
            this.txtNombreNivel.Size = new System.Drawing.Size(147, 20);
            this.txtNombreNivel.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(177, 446);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 27);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(261, 446);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 27);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmNivelAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 479);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvNivelAcademico);
            this.Controls.Add(this.gbxNivelAcademico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmNivelAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblidNAcademico;
        private System.Windows.Forms.TextBox txtIDNivelAcademico;
        private System.Windows.Forms.TextBox txtNombreNivel;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
    }
}