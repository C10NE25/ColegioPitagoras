namespace CapaPresentacion
{
    partial class frmDocumento
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
            this.dgvDocumentoAlumno = new System.Windows.Forms.DataGridView();
            this.gbxDocumento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtIDCarpetaInscripcion = new System.Windows.Forms.TextBox();
            this.txtRutaDoc = new System.Windows.Forms.TextBox();
            this.btnSeleccionarDoc = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentoAlumno)).BeginInit();
            this.gbxDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 56);
            this.label1.TabIndex = 53;
            this.label1.Text = "Documentos del Alumno";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1646, 498);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 113;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1646, 358);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 112;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1646, 208);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 111;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1646, 641);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 109;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentoAlumno
            // 
            this.dgvDocumentoAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentoAlumno.Location = new System.Drawing.Point(109, 174);
            this.dgvDocumentoAlumno.Name = "dgvDocumentoAlumno";
            this.dgvDocumentoAlumno.ReadOnly = true;
            this.dgvDocumentoAlumno.RowHeadersWidth = 92;
            this.dgvDocumentoAlumno.RowTemplate.Height = 37;
            this.dgvDocumentoAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentoAlumno.Size = new System.Drawing.Size(1432, 601);
            this.dgvDocumentoAlumno.TabIndex = 108;
            // 
            // gbxDocumento
            // 
            this.gbxDocumento.Controls.Add(this.cbxEstado);
            this.gbxDocumento.Controls.Add(this.btnSeleccionarDoc);
            this.gbxDocumento.Controls.Add(this.txtRutaDoc);
            this.gbxDocumento.Controls.Add(this.btnAgregar);
            this.gbxDocumento.Controls.Add(this.btnModificar);
            this.gbxDocumento.Controls.Add(this.btnCancelar);
            this.gbxDocumento.Controls.Add(this.label5);
            this.gbxDocumento.Controls.Add(this.label4);
            this.gbxDocumento.Controls.Add(this.label2);
            this.gbxDocumento.Controls.Add(this.txtIDTipoDocumento);
            this.gbxDocumento.Controls.Add(this.txtIDCarpetaInscripcion);
            this.gbxDocumento.Location = new System.Drawing.Point(313, 858);
            this.gbxDocumento.Name = "gbxDocumento";
            this.gbxDocumento.Size = new System.Drawing.Size(1103, 435);
            this.gbxDocumento.TabIndex = 110;
            this.gbxDocumento.TabStop = false;
            this.gbxDocumento.Text = "Datos del Documento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(823, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(823, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(823, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruta del Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Carpeta Inscripcion:";
            // 
            // txtIDTipoDocumento
            // 
            this.txtIDTipoDocumento.Location = new System.Drawing.Point(274, 114);
            this.txtIDTipoDocumento.Name = "txtIDTipoDocumento";
            this.txtIDTipoDocumento.Size = new System.Drawing.Size(150, 35);
            this.txtIDTipoDocumento.TabIndex = 2;
            // 
            // txtIDCarpetaInscripcion
            // 
            this.txtIDCarpetaInscripcion.Location = new System.Drawing.Point(285, 51);
            this.txtIDCarpetaInscripcion.Name = "txtIDCarpetaInscripcion";
            this.txtIDCarpetaInscripcion.Size = new System.Drawing.Size(139, 35);
            this.txtIDCarpetaInscripcion.TabIndex = 1;
            // 
            // txtRutaDoc
            // 
            this.txtRutaDoc.Location = new System.Drawing.Point(274, 176);
            this.txtRutaDoc.Name = "txtRutaDoc";
            this.txtRutaDoc.Size = new System.Drawing.Size(316, 35);
            this.txtRutaDoc.TabIndex = 17;
            // 
            // btnSeleccionarDoc
            // 
            this.btnSeleccionarDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarDoc.Location = new System.Drawing.Point(613, 172);
            this.btnSeleccionarDoc.Name = "btnSeleccionarDoc";
            this.btnSeleccionarDoc.Size = new System.Drawing.Size(69, 43);
            this.btnSeleccionarDoc.TabIndex = 18;
            this.btnSeleccionarDoc.Text = "...";
            this.btnSeleccionarDoc.UseVisualStyleBackColor = true;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(34, 256);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(289, 33);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado del Documento";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // frmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2012, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDocumentoAlumno);
            this.Controls.Add(this.gbxDocumento);
            this.Controls.Add(this.label1);
            this.Name = "frmDocumento";
            this.Text = "frmDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentoAlumno)).EndInit();
            this.gbxDocumento.ResumeLayout(false);
            this.gbxDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDocumentoAlumno;
        private System.Windows.Forms.GroupBox gbxDocumento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDTipoDocumento;
        private System.Windows.Forms.TextBox txtIDCarpetaInscripcion;
        private System.Windows.Forms.Button btnSeleccionarDoc;
        private System.Windows.Forms.TextBox txtRutaDoc;
        private System.Windows.Forms.CheckBox cbxEstado;
    }
}