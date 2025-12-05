namespace CapaPresentacion.frmAcademico
{
    partial class frmPeriodoAcademico
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
            this.dgvPeriodoAcademico = new System.Windows.Forms.DataGridView();
            this.gbxPeriodoAcademico = new System.Windows.Forms.GroupBox();
            this.txtNombrePeriodoAcademico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPeriodoAcademico = new System.Windows.Forms.TextBox();
            this.txtPeriodoAnioAcademico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodoAcademico)).BeginInit();
            this.gbxPeriodoAcademico.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeriodoAcademico
            // 
            this.dgvPeriodoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodoAcademico.Location = new System.Drawing.Point(16, 51);
            this.dgvPeriodoAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.dgvPeriodoAcademico.Name = "dgvPeriodoAcademico";
            this.dgvPeriodoAcademico.ReadOnly = true;
            this.dgvPeriodoAcademico.RowHeadersWidth = 30;
            this.dgvPeriodoAcademico.RowTemplate.Height = 37;
            this.dgvPeriodoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeriodoAcademico.Size = new System.Drawing.Size(338, 378);
            this.dgvPeriodoAcademico.TabIndex = 58;
            this.dgvPeriodoAcademico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeriodoAcademico_CellClick);
            // 
            // gbxPeriodoAcademico
            // 
            this.gbxPeriodoAcademico.Controls.Add(this.txtNombrePeriodoAcademico);
            this.gbxPeriodoAcademico.Controls.Add(this.label4);
            this.gbxPeriodoAcademico.Controls.Add(this.btnAgregar);
            this.gbxPeriodoAcademico.Controls.Add(this.btnModificar);
            this.gbxPeriodoAcademico.Controls.Add(this.cbxEstado);
            this.gbxPeriodoAcademico.Controls.Add(this.label3);
            this.gbxPeriodoAcademico.Controls.Add(this.label2);
            this.gbxPeriodoAcademico.Controls.Add(this.txtIdPeriodoAcademico);
            this.gbxPeriodoAcademico.Controls.Add(this.txtPeriodoAnioAcademico);
            this.gbxPeriodoAcademico.Location = new System.Drawing.Point(374, 51);
            this.gbxPeriodoAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.gbxPeriodoAcademico.Name = "gbxPeriodoAcademico";
            this.gbxPeriodoAcademico.Padding = new System.Windows.Forms.Padding(1);
            this.gbxPeriodoAcademico.Size = new System.Drawing.Size(391, 195);
            this.gbxPeriodoAcademico.TabIndex = 59;
            this.gbxPeriodoAcademico.TabStop = false;
            this.gbxPeriodoAcademico.Text = "Datos del Periodo Academico";
            // 
            // txtNombrePeriodoAcademico
            // 
            this.txtNombrePeriodoAcademico.Location = new System.Drawing.Point(177, 81);
            this.txtNombrePeriodoAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombrePeriodoAcademico.Name = "txtNombrePeriodoAcademico";
            this.txtNombrePeriodoAcademico.Size = new System.Drawing.Size(147, 20);
            this.txtNombrePeriodoAcademico.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre del Periodo Academico";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(86, 145);
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
            this.btnModificar.Location = new System.Drawing.Point(207, 145);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(15, 119);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(115, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Periodo";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Año del Periodo Academico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdPeriodoAcademico
            // 
            this.txtIdPeriodoAcademico.Location = new System.Drawing.Point(177, 23);
            this.txtIdPeriodoAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdPeriodoAcademico.Name = "txtIdPeriodoAcademico";
            this.txtIdPeriodoAcademico.ReadOnly = true;
            this.txtIdPeriodoAcademico.Size = new System.Drawing.Size(57, 20);
            this.txtIdPeriodoAcademico.TabIndex = 1;
            // 
            // txtPeriodoAnioAcademico
            // 
            this.txtPeriodoAnioAcademico.Location = new System.Drawing.Point(177, 51);
            this.txtPeriodoAnioAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.txtPeriodoAnioAcademico.Name = "txtPeriodoAnioAcademico";
            this.txtPeriodoAnioAcademico.Size = new System.Drawing.Size(147, 20);
            this.txtPeriodoAnioAcademico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Periodo Academico";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(255, 442);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 27);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(154, 442);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 27);
            this.btnNuevo.TabIndex = 61;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPeriodoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 479);
            this.Controls.Add(this.dgvPeriodoAcademico);
            this.Controls.Add(this.gbxPeriodoAcademico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPeriodoAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeriodoAcademico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodoAcademico)).EndInit();
            this.gbxPeriodoAcademico.ResumeLayout(false);
            this.gbxPeriodoAcademico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeriodoAcademico;
        private System.Windows.Forms.GroupBox gbxPeriodoAcademico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPeriodoAcademico;
        private System.Windows.Forms.TextBox txtPeriodoAnioAcademico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombrePeriodoAcademico;
    }
}