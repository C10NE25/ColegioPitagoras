namespace CapaPresentacion.frmTesoreria
{
    partial class frmTarifa
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.txtMontoTarifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTarifa = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNombreTarifa = new System.Windows.Forms.TextBox();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.gbxTarifa = new System.Windows.Forms.GroupBox();
            this.cbAnioAcademico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            this.gbxTarifa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(888, 168);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 38);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(453, 236);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(127, 38);
            this.btnDeshabilitar.TabIndex = 65;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // txtMontoTarifa
            // 
            this.txtMontoTarifa.Location = new System.Drawing.Point(319, 100);
            this.txtMontoTarifa.Margin = new System.Windows.Forms.Padding(1);
            this.txtMontoTarifa.Name = "txtMontoTarifa";
            this.txtMontoTarifa.Size = new System.Drawing.Size(112, 22);
            this.txtMontoTarifa.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Monto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(179, 236);
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
            this.btnModificar.Location = new System.Drawing.Point(319, 236);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(19, 181);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(72, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de la tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Tarifa";
            // 
            // txtIdTarifa
            // 
            this.txtIdTarifa.Location = new System.Drawing.Point(236, 28);
            this.txtIdTarifa.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdTarifa.Name = "txtIdTarifa";
            this.txtIdTarifa.Size = new System.Drawing.Size(75, 22);
            this.txtIdTarifa.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(888, 235);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 32);
            this.btnCerrar.TabIndex = 67;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNombreTarifa
            // 
            this.txtNombreTarifa.Location = new System.Drawing.Point(236, 63);
            this.txtNombreTarifa.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreTarifa.Name = "txtNombreTarifa";
            this.txtNombreTarifa.Size = new System.Drawing.Size(195, 22);
            this.txtNombreTarifa.TabIndex = 0;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Location = new System.Drawing.Point(42, 72);
            this.dgvTarifa.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.ReadOnly = true;
            this.dgvTarifa.RowHeadersWidth = 92;
            this.dgvTarifa.RowTemplate.Height = 37;
            this.dgvTarifa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifa.Size = new System.Drawing.Size(809, 217);
            this.dgvTarifa.TabIndex = 65;
            // 
            // gbxTarifa
            // 
            this.gbxTarifa.Controls.Add(this.cbAnioAcademico);
            this.gbxTarifa.Controls.Add(this.label5);
            this.gbxTarifa.Controls.Add(this.btnDeshabilitar);
            this.gbxTarifa.Controls.Add(this.txtMontoTarifa);
            this.gbxTarifa.Controls.Add(this.label4);
            this.gbxTarifa.Controls.Add(this.btnAgregar);
            this.gbxTarifa.Controls.Add(this.btnModificar);
            this.gbxTarifa.Controls.Add(this.cbxEstado);
            this.gbxTarifa.Controls.Add(this.label3);
            this.gbxTarifa.Controls.Add(this.label2);
            this.gbxTarifa.Controls.Add(this.txtIdTarifa);
            this.gbxTarifa.Controls.Add(this.txtNombreTarifa);
            this.gbxTarifa.Location = new System.Drawing.Point(42, 320);
            this.gbxTarifa.Margin = new System.Windows.Forms.Padding(1);
            this.gbxTarifa.Name = "gbxTarifa";
            this.gbxTarifa.Padding = new System.Windows.Forms.Padding(1);
            this.gbxTarifa.Size = new System.Drawing.Size(585, 292);
            this.gbxTarifa.TabIndex = 66;
            this.gbxTarifa.TabStop = false;
            this.gbxTarifa.Text = "Dato de la Tarifa";
            // 
            // cbAnioAcademico
            // 
            this.cbAnioAcademico.FormattingEnabled = true;
            this.cbAnioAcademico.Location = new System.Drawing.Point(236, 136);
            this.cbAnioAcademico.Name = "cbAnioAcademico";
            this.cbAnioAcademico.Size = new System.Drawing.Size(195, 24);
            this.cbAnioAcademico.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Año Academico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tarifa";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(888, 118);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(888, 72);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 33);
            this.btnNuevo.TabIndex = 68;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 640);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvTarifa);
            this.Controls.Add(this.gbxTarifa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTarifa";
            this.Text = "frmTarifa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            this.gbxTarifa.ResumeLayout(false);
            this.gbxTarifa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.TextBox txtMontoTarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTarifa;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNombreTarifa;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private System.Windows.Forms.GroupBox gbxTarifa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbAnioAcademico;
        private System.Windows.Forms.Label label5;
    }
}