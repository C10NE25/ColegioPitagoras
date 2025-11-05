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
            this.lblRegistroDocente = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.gbxDocente = new System.Windows.Forms.GroupBox();
            this.cbxEstadoDocente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblApellidoPaternoDocente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidDocente = new System.Windows.Forms.Label();
            this.txtBDireccionDocente = new System.Windows.Forms.TextBox();
            this.txtBApellidoPaternoDocente = new System.Windows.Forms.TextBox();
            this.txtBNombreDocente = new System.Windows.Forms.TextBox();
            this.txtBIDDocente = new System.Windows.Forms.TextBox();
            this.txtBdniDocente = new System.Windows.Forms.TextBox();
            this.lblApellidoMaternoDocente = new System.Windows.Forms.Label();
            this.txtBApellidoMaternoDocente = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.txtBTelefonoDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.gbxDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroDocente
            // 
            this.lblRegistroDocente.AutoSize = true;
            this.lblRegistroDocente.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDocente.Location = new System.Drawing.Point(10, 9);
            this.lblRegistroDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRegistroDocente.Name = "lblRegistroDocente";
            this.lblRegistroDocente.Size = new System.Drawing.Size(184, 26);
            this.lblRegistroDocente.TabIndex = 17;
            this.lblRegistroDocente.Text = "Registrar Docente";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(624, 302);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(99, 26);
            this.btnDeshabilitar.TabIndex = 23;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(517, 302);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 26);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(412, 302);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 26);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(725, 302);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 26);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Location = new System.Drawing.Point(10, 47);
            this.dgvDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.ReadOnly = true;
            this.dgvDocente.RowHeadersWidth = 92;
            this.dgvDocente.RowTemplate.Height = 37;
            this.dgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocente.Size = new System.Drawing.Size(814, 244);
            this.dgvDocente.TabIndex = 18;
            this.dgvDocente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocente_CellDoubleClick);
            this.dgvDocente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDocente_DataBindingComplete);
            // 
            // gbxDocente
            // 
            this.gbxDocente.Controls.Add(this.txtBTelefonoDocente);
            this.gbxDocente.Controls.Add(this.lblTelefonoDocente);
            this.gbxDocente.Controls.Add(this.txtBApellidoMaternoDocente);
            this.gbxDocente.Controls.Add(this.lblApellidoMaternoDocente);
            this.gbxDocente.Controls.Add(this.cbxEstadoDocente);
            this.gbxDocente.Controls.Add(this.label7);
            this.gbxDocente.Controls.Add(this.btnAgregar);
            this.gbxDocente.Controls.Add(this.lblApellidoPaternoDocente);
            this.gbxDocente.Controls.Add(this.label4);
            this.gbxDocente.Controls.Add(this.btnModificar);
            this.gbxDocente.Controls.Add(this.label3);
            this.gbxDocente.Controls.Add(this.btnCancelar);
            this.gbxDocente.Controls.Add(this.lblidDocente);
            this.gbxDocente.Controls.Add(this.txtBDireccionDocente);
            this.gbxDocente.Controls.Add(this.txtBApellidoPaternoDocente);
            this.gbxDocente.Controls.Add(this.txtBNombreDocente);
            this.gbxDocente.Controls.Add(this.txtBIDDocente);
            this.gbxDocente.Controls.Add(this.txtBdniDocente);
            this.gbxDocente.Location = new System.Drawing.Point(10, 330);
            this.gbxDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxDocente.Name = "gbxDocente";
            this.gbxDocente.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbxDocente.Size = new System.Drawing.Size(814, 187);
            this.gbxDocente.TabIndex = 20;
            this.gbxDocente.TabStop = false;
            this.gbxDocente.Text = "Datos del Docente";
            // 
            // cbxEstadoDocente
            // 
            this.cbxEstadoDocente.AutoSize = true;
            this.cbxEstadoDocente.Location = new System.Drawing.Point(536, 63);
            this.cbxEstadoDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxEstadoDocente.Name = "cbxEstadoDocente";
            this.cbxEstadoDocente.Size = new System.Drawing.Size(103, 17);
            this.cbxEstadoDocente.TabIndex = 13;
            this.cbxEstadoDocente.Text = "Estado Docente";
            this.cbxEstadoDocente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(689, 67);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 25);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(689, 105);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 26);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(689, 145);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 26);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblApellidoPaternoDocente
            // 
            this.lblApellidoPaternoDocente.AutoSize = true;
            this.lblApellidoPaternoDocente.Location = new System.Drawing.Point(12, 103);
            this.lblApellidoPaternoDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoPaternoDocente.Name = "lblApellidoPaternoDocente";
            this.lblApellidoPaternoDocente.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaternoDocente.TabIndex = 10;
            this.lblApellidoPaternoDocente.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // lblidDocente
            // 
            this.lblidDocente.AutoSize = true;
            this.lblidDocente.Location = new System.Drawing.Point(12, 26);
            this.lblidDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidDocente.Name = "lblidDocente";
            this.lblidDocente.Size = new System.Drawing.Size(21, 13);
            this.lblidDocente.TabIndex = 7;
            this.lblidDocente.Text = "ID:";
            // 
            // txtBDireccionDocente
            // 
            this.txtBDireccionDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBDireccionDocente.Location = new System.Drawing.Point(355, 142);
            this.txtBDireccionDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBDireccionDocente.Name = "txtBDireccionDocente";
            this.txtBDireccionDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBDireccionDocente.TabIndex = 5;
            // 
            // txtBApellidoPaternoDocente
            // 
            this.txtBApellidoPaternoDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBApellidoPaternoDocente.Location = new System.Drawing.Point(109, 101);
            this.txtBApellidoPaternoDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBApellidoPaternoDocente.Name = "txtBApellidoPaternoDocente";
            this.txtBApellidoPaternoDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBApellidoPaternoDocente.TabIndex = 3;
            // 
            // txtBNombreDocente
            // 
            this.txtBNombreDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNombreDocente.Location = new System.Drawing.Point(109, 62);
            this.txtBNombreDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBNombreDocente.Name = "txtBNombreDocente";
            this.txtBNombreDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBNombreDocente.TabIndex = 2;
            // 
            // txtBIDDocente
            // 
            this.txtBIDDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBIDDocente.Location = new System.Drawing.Point(109, 23);
            this.txtBIDDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBIDDocente.Name = "txtBIDDocente";
            this.txtBIDDocente.Size = new System.Drawing.Size(62, 20);
            this.txtBIDDocente.TabIndex = 1;
            // 
            // txtBdniDocente
            // 
            this.txtBdniDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBdniDocente.Location = new System.Drawing.Point(355, 62);
            this.txtBdniDocente.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBdniDocente.Name = "txtBdniDocente";
            this.txtBdniDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBdniDocente.TabIndex = 0;
            // 
            // lblApellidoMaternoDocente
            // 
            this.lblApellidoMaternoDocente.AutoSize = true;
            this.lblApellidoMaternoDocente.Location = new System.Drawing.Point(12, 144);
            this.lblApellidoMaternoDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoMaternoDocente.Name = "lblApellidoMaternoDocente";
            this.lblApellidoMaternoDocente.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMaternoDocente.TabIndex = 14;
            this.lblApellidoMaternoDocente.Text = "Apellido Materno:";
            // 
            // txtBApellidoMaternoDocente
            // 
            this.txtBApellidoMaternoDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBApellidoMaternoDocente.Location = new System.Drawing.Point(109, 142);
            this.txtBApellidoMaternoDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBApellidoMaternoDocente.Name = "txtBApellidoMaternoDocente";
            this.txtBApellidoMaternoDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBApellidoMaternoDocente.TabIndex = 15;
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(289, 103);
            this.lblTelefonoDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoDocente.TabIndex = 16;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // txtBTelefonoDocente
            // 
            this.txtBTelefonoDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBTelefonoDocente.Location = new System.Drawing.Point(355, 101);
            this.txtBTelefonoDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBTelefonoDocente.Name = "txtBTelefonoDocente";
            this.txtBTelefonoDocente.Size = new System.Drawing.Size(147, 20);
            this.txtBTelefonoDocente.TabIndex = 17;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 528);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.gbxDocente);
            this.Controls.Add(this.lblRegistroDocente);
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

        private System.Windows.Forms.Label lblRegistroDocente;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.GroupBox gbxDocente;
        private System.Windows.Forms.CheckBox cbxEstadoDocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblApellidoPaternoDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidDocente;
        private System.Windows.Forms.TextBox txtBDireccionDocente;
        private System.Windows.Forms.TextBox txtBApellidoPaternoDocente;
        private System.Windows.Forms.TextBox txtBNombreDocente;
        private System.Windows.Forms.TextBox txtBIDDocente;
        private System.Windows.Forms.TextBox txtBdniDocente;
        private System.Windows.Forms.TextBox txtBApellidoMaternoDocente;
        private System.Windows.Forms.Label lblApellidoMaternoDocente;
        private System.Windows.Forms.TextBox txtBTelefonoDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
    }
}