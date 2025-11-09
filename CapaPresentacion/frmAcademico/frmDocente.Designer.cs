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
            this.lblApellidoPDocente = new System.Windows.Forms.Label();
            this.txtBApellidoPDocente = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.lblApellidoMDocente = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbldniDocente = new System.Windows.Forms.Label();
            this.lblidDocente = new System.Windows.Forms.Label();
            this.txtBDireccionDocente = new System.Windows.Forms.TextBox();
            this.txtBTelefonoDocente = new System.Windows.Forms.TextBox();
            this.txtBApellidoMDocente = new System.Windows.Forms.TextBox();
            this.txtBNombreDocente = new System.Windows.Forms.TextBox();
            this.txtBidDocente = new System.Windows.Forms.TextBox();
            this.txtBdniDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.gbxDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Docente";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(812, 395);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(132, 33);
            this.btnDeshabilitar.TabIndex = 23;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(677, 395);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(543, 395);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 33);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(947, 396);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 32);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Location = new System.Drawing.Point(20, 58);
            this.dgvDocente.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.ReadOnly = true;
            this.dgvDocente.RowHeadersWidth = 92;
            this.dgvDocente.RowTemplate.Height = 37;
            this.dgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocente.Size = new System.Drawing.Size(1056, 331);
            this.dgvDocente.TabIndex = 18;
            this.dgvDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocente_CellClick);
            this.dgvDocente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDocente_DataBindingComplete);
            // 
            // gbxDocente
            // 
            this.gbxDocente.Controls.Add(this.lblApellidoPDocente);
            this.gbxDocente.Controls.Add(this.txtBApellidoPDocente);
            this.gbxDocente.Controls.Add(this.cbxEstado);
            this.gbxDocente.Controls.Add(this.lblDireccionDocente);
            this.gbxDocente.Controls.Add(this.btnAgregar);
            this.gbxDocente.Controls.Add(this.lblTelefonoDocente);
            this.gbxDocente.Controls.Add(this.lblApellidoMDocente);
            this.gbxDocente.Controls.Add(this.btnModificar);
            this.gbxDocente.Controls.Add(this.lblNombreDocente);
            this.gbxDocente.Controls.Add(this.btnCancelar);
            this.gbxDocente.Controls.Add(this.lbldniDocente);
            this.gbxDocente.Controls.Add(this.lblidDocente);
            this.gbxDocente.Controls.Add(this.txtBDireccionDocente);
            this.gbxDocente.Controls.Add(this.txtBTelefonoDocente);
            this.gbxDocente.Controls.Add(this.txtBApellidoMDocente);
            this.gbxDocente.Controls.Add(this.txtBNombreDocente);
            this.gbxDocente.Controls.Add(this.txtBidDocente);
            this.gbxDocente.Controls.Add(this.txtBdniDocente);
            this.gbxDocente.Location = new System.Drawing.Point(20, 431);
            this.gbxDocente.Margin = new System.Windows.Forms.Padding(1);
            this.gbxDocente.Name = "gbxDocente";
            this.gbxDocente.Padding = new System.Windows.Forms.Padding(1);
            this.gbxDocente.Size = new System.Drawing.Size(1056, 230);
            this.gbxDocente.TabIndex = 20;
            this.gbxDocente.TabStop = false;
            this.gbxDocente.Text = "Datos del Docente";
            // 
            // lblApellidoPDocente
            // 
            this.lblApellidoPDocente.AutoSize = true;
            this.lblApellidoPDocente.Location = new System.Drawing.Point(369, 84);
            this.lblApellidoPDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoPDocente.Name = "lblApellidoPDocente";
            this.lblApellidoPDocente.Size = new System.Drawing.Size(110, 16);
            this.lblApellidoPDocente.TabIndex = 15;
            this.lblApellidoPDocente.Text = "Apellido Paterno:";
            // 
            // txtBApellidoPDocente
            // 
            this.txtBApellidoPDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBApellidoPDocente.Location = new System.Drawing.Point(488, 81);
            this.txtBApellidoPDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBApellidoPDocente.Name = "txtBApellidoPDocente";
            this.txtBApellidoPDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBApellidoPDocente.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(247, 28);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(129, 36);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado \r\n[Activo | Inactivo]";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(723, 122);
            this.lblDireccionDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionDocente.TabIndex = 12;
            this.lblDireccionDocente.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(645, 178);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(369, 130);
            this.lblTelefonoDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoDocente.TabIndex = 11;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // lblApellidoMDocente
            // 
            this.lblApellidoMDocente.AutoSize = true;
            this.lblApellidoMDocente.Location = new System.Drawing.Point(717, 84);
            this.lblApellidoMDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoMDocente.Name = "lblApellidoMDocente";
            this.lblApellidoMDocente.Size = new System.Drawing.Size(112, 16);
            this.lblApellidoMDocente.TabIndex = 10;
            this.lblApellidoMDocente.Text = "Apellido Materno:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(780, 178);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(15, 84);
            this.lblNombreDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreDocente.TabIndex = 9;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(914, 178);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbldniDocente
            // 
            this.lbldniDocente.AutoSize = true;
            this.lbldniDocente.Location = new System.Drawing.Point(13, 122);
            this.lbldniDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldniDocente.Name = "lbldniDocente";
            this.lbldniDocente.Size = new System.Drawing.Size(33, 16);
            this.lbldniDocente.TabIndex = 8;
            this.lbldniDocente.Text = "DNI:";
            // 
            // lblidDocente
            // 
            this.lblidDocente.AutoSize = true;
            this.lblidDocente.Location = new System.Drawing.Point(16, 38);
            this.lblidDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidDocente.Name = "lblidDocente";
            this.lblidDocente.Size = new System.Drawing.Size(23, 16);
            this.lblidDocente.TabIndex = 7;
            this.lblidDocente.Text = "ID:";
            // 
            // txtBDireccionDocente
            // 
            this.txtBDireccionDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBDireccionDocente.Location = new System.Drawing.Point(839, 119);
            this.txtBDireccionDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBDireccionDocente.Name = "txtBDireccionDocente";
            this.txtBDireccionDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBDireccionDocente.TabIndex = 5;
            // 
            // txtBTelefonoDocente
            // 
            this.txtBTelefonoDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBTelefonoDocente.Location = new System.Drawing.Point(488, 122);
            this.txtBTelefonoDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBTelefonoDocente.Name = "txtBTelefonoDocente";
            this.txtBTelefonoDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBTelefonoDocente.TabIndex = 4;
            // 
            // txtBApellidoMDocente
            // 
            this.txtBApellidoMDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBApellidoMDocente.Location = new System.Drawing.Point(839, 80);
            this.txtBApellidoMDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBApellidoMDocente.Name = "txtBApellidoMDocente";
            this.txtBApellidoMDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBApellidoMDocente.TabIndex = 3;
            // 
            // txtBNombreDocente
            // 
            this.txtBNombreDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNombreDocente.Location = new System.Drawing.Point(135, 80);
            this.txtBNombreDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBNombreDocente.Name = "txtBNombreDocente";
            this.txtBNombreDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBNombreDocente.TabIndex = 2;
            // 
            // txtBidDocente
            // 
            this.txtBidDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBidDocente.Location = new System.Drawing.Point(135, 38);
            this.txtBidDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBidDocente.Name = "txtBidDocente";
            this.txtBidDocente.Size = new System.Drawing.Size(82, 22);
            this.txtBidDocente.TabIndex = 1;
            // 
            // txtBdniDocente
            // 
            this.txtBdniDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBdniDocente.Location = new System.Drawing.Point(135, 119);
            this.txtBdniDocente.Margin = new System.Windows.Forms.Padding(1);
            this.txtBdniDocente.Name = "txtBdniDocente";
            this.txtBdniDocente.Size = new System.Drawing.Size(195, 22);
            this.txtBdniDocente.TabIndex = 0;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 678);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.gbxDocente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
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
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.Label lblApellidoMDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.Label lbldniDocente;
        private System.Windows.Forms.Label lblidDocente;
        private System.Windows.Forms.TextBox txtBDireccionDocente;
        private System.Windows.Forms.TextBox txtBTelefonoDocente;
        private System.Windows.Forms.TextBox txtBApellidoMDocente;
        private System.Windows.Forms.TextBox txtBNombreDocente;
        private System.Windows.Forms.TextBox txtBidDocente;
        private System.Windows.Forms.TextBox txtBdniDocente;
        private System.Windows.Forms.Label lblApellidoPDocente;
        private System.Windows.Forms.TextBox txtBApellidoPDocente;
    }
}