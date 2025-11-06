namespace CapaPresentacion
{
    partial class frmDocente
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
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.gbxDocente = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.txtNroCelularDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtIDDocente = new System.Windows.Forms.TextBox();
            this.txtDniDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.gbxDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Docente";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(609, 321);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(99, 27);
            this.btnDeshabilitar.TabIndex = 23;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(508, 321);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 27);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(407, 321);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 27);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(710, 322);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 26);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Location = new System.Drawing.Point(15, 47);
            this.dgvDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.ReadOnly = true;
            this.dgvDocente.RowHeadersWidth = 92;
            this.dgvDocente.RowTemplate.Height = 37;
            this.dgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocente.Size = new System.Drawing.Size(792, 269);
            this.dgvDocente.TabIndex = 18;
            this.dgvDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocente_CellClick);
            this.dgvDocente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDocente_DataBindingComplete);
            // 
            // gbxDocente
            // 
            this.gbxDocente.Controls.Add(this.cbxEstado);
            this.gbxDocente.Controls.Add(this.label7);
            this.gbxDocente.Controls.Add(this.btnAgregar);
            this.gbxDocente.Controls.Add(this.label6);
            this.gbxDocente.Controls.Add(this.label5);
            this.gbxDocente.Controls.Add(this.btnModificar);
            this.gbxDocente.Controls.Add(this.label4);
            this.gbxDocente.Controls.Add(this.btnCancelar);
            this.gbxDocente.Controls.Add(this.label3);
            this.gbxDocente.Controls.Add(this.label2);
            this.gbxDocente.Controls.Add(this.txtDireccionDocente);
            this.gbxDocente.Controls.Add(this.txtNroCelularDocente);
            this.gbxDocente.Controls.Add(this.txtApellidoDocente);
            this.gbxDocente.Controls.Add(this.txtNombreDocente);
            this.gbxDocente.Controls.Add(this.txtIDDocente);
            this.gbxDocente.Controls.Add(this.txtDniDocente);
            this.gbxDocente.Location = new System.Drawing.Point(15, 350);
            this.gbxDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxDocente.Name = "gbxDocente";
            this.gbxDocente.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxDocente.Size = new System.Drawing.Size(792, 177);
            this.gbxDocente.TabIndex = 20;
            this.gbxDocente.TabStop = false;
            this.gbxDocente.Text = "Datos del Docente";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(332, 24);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(120, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Docente";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(677, 50);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(677, 90);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(677, 127);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nro Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
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
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionDocente.Location = new System.Drawing.Point(345, 83);
            this.txtDireccionDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(147, 20);
            this.txtDireccionDocente.TabIndex = 5;
            // 
            // txtNroCelularDocente
            // 
            this.txtNroCelularDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroCelularDocente.Location = new System.Drawing.Point(345, 56);
            this.txtNroCelularDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNroCelularDocente.Name = "txtNroCelularDocente";
            this.txtNroCelularDocente.Size = new System.Drawing.Size(147, 20);
            this.txtNroCelularDocente.TabIndex = 4;
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoDocente.Location = new System.Drawing.Point(99, 115);
            this.txtApellidoDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(147, 20);
            this.txtApellidoDocente.TabIndex = 3;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDocente.Location = new System.Drawing.Point(99, 61);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(147, 20);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // txtIDDocente
            // 
            this.txtIDDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDocente.Location = new System.Drawing.Point(99, 24);
            this.txtIDDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtIDDocente.Name = "txtIDDocente";
            this.txtIDDocente.Size = new System.Drawing.Size(62, 20);
            this.txtIDDocente.TabIndex = 1;
            // 
            // txtDniDocente
            // 
            this.txtDniDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniDocente.Location = new System.Drawing.Point(369, 115);
            this.txtDniDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDniDocente.Name = "txtDniDocente";
            this.txtDniDocente.Size = new System.Drawing.Size(147, 20);
            this.txtDniDocente.TabIndex = 0;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 552);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.gbxDocente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmDocente";
            this.Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.gbxDocente.ResumeLayout(false);
            this.gbxDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.GroupBox gbxDocente;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.TextBox txtNroCelularDocente;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtIDDocente;
        private System.Windows.Forms.TextBox txtDniDocente;
    }
}