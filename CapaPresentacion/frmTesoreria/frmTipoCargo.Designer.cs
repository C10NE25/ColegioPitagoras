namespace CapaPresentacion.frmAcademico
{
    partial class frmTipoCargo
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
            this.cbTarifa = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoCargo = new System.Windows.Forms.TextBox();
            this.txtNombreTipoCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbxTipoCargo = new System.Windows.Forms.GroupBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvTipoCargo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxTipoCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTarifa
            // 
            this.cbTarifa.FormattingEnabled = true;
            this.cbTarifa.Location = new System.Drawing.Point(236, 106);
            this.cbTarifa.Name = "cbTarifa";
            this.cbTarifa.Size = new System.Drawing.Size(195, 24);
            this.cbTarifa.TabIndex = 66;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(681, 51);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 33);
            this.btnNuevo.TabIndex = 75;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre tipo cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Tipo Cargo";
            // 
            // txtIdTipoCargo
            // 
            this.txtIdTipoCargo.Location = new System.Drawing.Point(356, 29);
            this.txtIdTipoCargo.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdTipoCargo.Name = "txtIdTipoCargo";
            this.txtIdTipoCargo.Size = new System.Drawing.Size(75, 22);
            this.txtIdTipoCargo.TabIndex = 1;
            // 
            // txtNombreTipoCargo
            // 
            this.txtNombreTipoCargo.Location = new System.Drawing.Point(236, 63);
            this.txtNombreTipoCargo.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreTipoCargo.Name = "txtNombreTipoCargo";
            this.txtNombreTipoCargo.Size = new System.Drawing.Size(195, 22);
            this.txtNombreTipoCargo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tipo Cargo";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(681, 100);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 76;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tarifa";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(383, 184);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 38);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(517, 184);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbxTipoCargo
            // 
            this.gbxTipoCargo.Controls.Add(this.btnDeshabilitar);
            this.gbxTipoCargo.Controls.Add(this.cbTarifa);
            this.gbxTipoCargo.Controls.Add(this.label4);
            this.gbxTipoCargo.Controls.Add(this.btnAgregar);
            this.gbxTipoCargo.Controls.Add(this.btnModificar);
            this.gbxTipoCargo.Controls.Add(this.cbxEstado);
            this.gbxTipoCargo.Controls.Add(this.label3);
            this.gbxTipoCargo.Controls.Add(this.label2);
            this.gbxTipoCargo.Controls.Add(this.txtIdTipoCargo);
            this.gbxTipoCargo.Controls.Add(this.txtNombreTipoCargo);
            this.gbxTipoCargo.Location = new System.Drawing.Point(10, 299);
            this.gbxTipoCargo.Margin = new System.Windows.Forms.Padding(1);
            this.gbxTipoCargo.Name = "gbxTipoCargo";
            this.gbxTipoCargo.Padding = new System.Windows.Forms.Padding(1);
            this.gbxTipoCargo.Size = new System.Drawing.Size(803, 240);
            this.gbxTipoCargo.TabIndex = 73;
            this.gbxTipoCargo.TabStop = false;
            this.gbxTipoCargo.Text = "Datos de Tipo Cargo";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(655, 184);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(132, 38);
            this.btnDeshabilitar.TabIndex = 69;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(19, 136);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(145, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Periodo";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(681, 202);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 32);
            this.btnCerrar.TabIndex = 74;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvTipoCargo
            // 
            this.dgvTipoCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCargo.Location = new System.Drawing.Point(10, 51);
            this.dgvTipoCargo.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTipoCargo.Name = "dgvTipoCargo";
            this.dgvTipoCargo.ReadOnly = true;
            this.dgvTipoCargo.RowHeadersWidth = 92;
            this.dgvTipoCargo.RowTemplate.Height = 37;
            this.dgvTipoCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCargo.Size = new System.Drawing.Size(649, 217);
            this.dgvTipoCargo.TabIndex = 72;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(681, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 33);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTipoCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 544);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbxTipoCargo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvTipoCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoCargo";
            this.Text = "frmTipoCargo";
            this.gbxTipoCargo.ResumeLayout(false);
            this.gbxTipoCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTarifa;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoCargo;
        private System.Windows.Forms.TextBox txtNombreTipoCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbxTipoCargo;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTipoCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}