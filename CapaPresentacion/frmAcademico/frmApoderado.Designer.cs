namespace CapaPresentacion
{
    partial class frmTutor
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
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTutor = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellidoMTutor = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionTutor = new System.Windows.Forms.TextBox();
            this.txtNroCelularTutor = new System.Windows.Forms.TextBox();
            this.txtApellidoPTutor = new System.Windows.Forms.TextBox();
            this.txtNombreTutor = new System.Windows.Forms.TextBox();
            this.txtIDTutor = new System.Windows.Forms.TextBox();
            this.txtDniTutor = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            this.gbxTutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTutor
            // 
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutor.Location = new System.Drawing.Point(16, 53);
            this.dgvTutor.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTutor.MultiSelect = false;
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.ReadOnly = true;
            this.dgvTutor.RowHeadersWidth = 92;
            this.dgvTutor.RowTemplate.Height = 37;
            this.dgvTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutor.Size = new System.Drawing.Size(987, 243);
            this.dgvTutor.TabIndex = 0;
            this.dgvTutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutor_CellClick);
            this.dgvTutor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTutor_DataBindingComplete);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(271, 186);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 26);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(419, 186);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 26);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(569, 186);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 26);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(901, 332);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 25);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apoderado";
            // 
            // gbxTutor
            // 
            this.gbxTutor.Controls.Add(this.label8);
            this.gbxTutor.Controls.Add(this.txtApellidoMTutor);
            this.gbxTutor.Controls.Add(this.cbxEstado);
            this.gbxTutor.Controls.Add(this.label7);
            this.gbxTutor.Controls.Add(this.btnAgregar);
            this.gbxTutor.Controls.Add(this.btnModificar);
            this.gbxTutor.Controls.Add(this.btnCancelar);
            this.gbxTutor.Controls.Add(this.label6);
            this.gbxTutor.Controls.Add(this.label5);
            this.gbxTutor.Controls.Add(this.label4);
            this.gbxTutor.Controls.Add(this.label3);
            this.gbxTutor.Controls.Add(this.label2);
            this.gbxTutor.Controls.Add(this.txtDireccionTutor);
            this.gbxTutor.Controls.Add(this.txtNroCelularTutor);
            this.gbxTutor.Controls.Add(this.txtApellidoPTutor);
            this.gbxTutor.Controls.Add(this.txtNombreTutor);
            this.gbxTutor.Controls.Add(this.txtIDTutor);
            this.gbxTutor.Controls.Add(this.txtDniTutor);
            this.gbxTutor.Location = new System.Drawing.Point(16, 384);
            this.gbxTutor.Margin = new System.Windows.Forms.Padding(1);
            this.gbxTutor.Name = "gbxTutor";
            this.gbxTutor.Padding = new System.Windows.Forms.Padding(1);
            this.gbxTutor.Size = new System.Drawing.Size(987, 240);
            this.gbxTutor.TabIndex = 6;
            this.gbxTutor.TabStop = false;
            this.gbxTutor.Text = "Datos del Apoderado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Apellidos Materno:";
            // 
            // txtApellidoMTutor
            // 
            this.txtApellidoMTutor.Location = new System.Drawing.Point(775, 68);
            this.txtApellidoMTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtApellidoMTutor.Name = "txtApellidoMTutor";
            this.txtApellidoMTutor.Size = new System.Drawing.Size(195, 22);
            this.txtApellidoMTutor.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(271, 28);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(166, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Apoderado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nro Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Apoderado";
            // 
            // txtDireccionTutor
            // 
            this.txtDireccionTutor.Location = new System.Drawing.Point(775, 107);
            this.txtDireccionTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtDireccionTutor.Name = "txtDireccionTutor";
            this.txtDireccionTutor.Size = new System.Drawing.Size(195, 22);
            this.txtDireccionTutor.TabIndex = 5;
            // 
            // txtNroCelularTutor
            // 
            this.txtNroCelularTutor.Location = new System.Drawing.Point(439, 104);
            this.txtNroCelularTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtNroCelularTutor.Name = "txtNroCelularTutor";
            this.txtNroCelularTutor.Size = new System.Drawing.Size(195, 22);
            this.txtNroCelularTutor.TabIndex = 4;
            // 
            // txtApellidoPTutor
            // 
            this.txtApellidoPTutor.Location = new System.Drawing.Point(439, 69);
            this.txtApellidoPTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtApellidoPTutor.Name = "txtApellidoPTutor";
            this.txtApellidoPTutor.Size = new System.Drawing.Size(195, 22);
            this.txtApellidoPTutor.TabIndex = 3;
            // 
            // txtNombreTutor
            // 
            this.txtNombreTutor.Location = new System.Drawing.Point(103, 69);
            this.txtNombreTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreTutor.Name = "txtNombreTutor";
            this.txtNombreTutor.Size = new System.Drawing.Size(195, 22);
            this.txtNombreTutor.TabIndex = 2;
            // 
            // txtIDTutor
            // 
            this.txtIDTutor.Location = new System.Drawing.Point(130, 29);
            this.txtIDTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtIDTutor.Name = "txtIDTutor";
            this.txtIDTutor.Size = new System.Drawing.Size(81, 22);
            this.txtIDTutor.TabIndex = 1;
            // 
            // txtDniTutor
            // 
            this.txtDniTutor.Location = new System.Drawing.Point(103, 103);
            this.txtDniTutor.Margin = new System.Windows.Forms.Padding(1);
            this.txtDniTutor.Name = "txtDniTutor";
            this.txtDniTutor.Size = new System.Drawing.Size(195, 22);
            this.txtDniTutor.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(583, 334);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 27);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(687, 334);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 27);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(791, 332);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(102, 29);
            this.btnDeshabilitar.TabIndex = 9;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 643);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvTutor);
            this.Controls.Add(this.gbxTutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmTutor";
            this.Text = "frmTutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            this.gbxTutor.ResumeLayout(false);
            this.gbxTutor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionTutor;
        private System.Windows.Forms.TextBox txtNroCelularTutor;
        private System.Windows.Forms.TextBox txtApellidoPTutor;
        private System.Windows.Forms.TextBox txtNombreTutor;
        private System.Windows.Forms.TextBox txtIDTutor;
        private System.Windows.Forms.TextBox txtDniTutor;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellidoMTutor;
    }
}