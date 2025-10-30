namespace CapaPresentacion
{
    partial class frmCarpetaInscripcion
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
            this.dgvCarpetaInscripcion = new System.Windows.Forms.DataGridView();
            this.gbxCarpetaInscripcion = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.cmbTipoRegistro = new System.Windows.Forms.ComboBox();
            this.cmbInstitucionOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaCarpetaInscripcion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarpetaInscripcion)).BeginInit();
            this.gbxCarpetaInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 56);
            this.label1.TabIndex = 59;
            this.label1.Text = "Carpeta de Inscripcion";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1626, 498);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 119;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1626, 358);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 118;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1626, 208);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 117;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1626, 641);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 115;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvCarpetaInscripcion
            // 
            this.dgvCarpetaInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarpetaInscripcion.Location = new System.Drawing.Point(89, 174);
            this.dgvCarpetaInscripcion.Name = "dgvCarpetaInscripcion";
            this.dgvCarpetaInscripcion.ReadOnly = true;
            this.dgvCarpetaInscripcion.RowHeadersWidth = 92;
            this.dgvCarpetaInscripcion.RowTemplate.Height = 37;
            this.dgvCarpetaInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarpetaInscripcion.Size = new System.Drawing.Size(1432, 601);
            this.dgvCarpetaInscripcion.TabIndex = 114;
            // 
            // gbxCarpetaInscripcion
            // 
            this.gbxCarpetaInscripcion.Controls.Add(this.label3);
            this.gbxCarpetaInscripcion.Controls.Add(this.dtpFechaCarpetaInscripcion);
            this.gbxCarpetaInscripcion.Controls.Add(this.cmbInstitucionOrigen);
            this.gbxCarpetaInscripcion.Controls.Add(this.cmbTipoRegistro);
            this.gbxCarpetaInscripcion.Controls.Add(this.cbxEstado);
            this.gbxCarpetaInscripcion.Controls.Add(this.btnAgregar);
            this.gbxCarpetaInscripcion.Controls.Add(this.btnModificar);
            this.gbxCarpetaInscripcion.Controls.Add(this.btnCancelar);
            this.gbxCarpetaInscripcion.Controls.Add(this.label5);
            this.gbxCarpetaInscripcion.Controls.Add(this.label4);
            this.gbxCarpetaInscripcion.Controls.Add(this.label2);
            this.gbxCarpetaInscripcion.Controls.Add(this.txtIDEstudiante);
            this.gbxCarpetaInscripcion.Location = new System.Drawing.Point(293, 858);
            this.gbxCarpetaInscripcion.Name = "gbxCarpetaInscripcion";
            this.gbxCarpetaInscripcion.Size = new System.Drawing.Size(1103, 435);
            this.gbxCarpetaInscripcion.TabIndex = 116;
            this.gbxCarpetaInscripcion.TabStop = false;
            this.gbxCarpetaInscripcion.Text = "Datos de la Carpeta de Inscripcion";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(34, 308);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(426, 33);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado de la Carpeta de Inscripcion";
            this.cbxEstado.UseVisualStyleBackColor = true;
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
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Institucion de Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Estudiante:";
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Location = new System.Drawing.Point(274, 54);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.Size = new System.Drawing.Size(139, 35);
            this.txtIDEstudiante.TabIndex = 1;
            // 
            // cmbTipoRegistro
            // 
            this.cmbTipoRegistro.FormattingEnabled = true;
            this.cmbTipoRegistro.Location = new System.Drawing.Point(274, 117);
            this.cmbTipoRegistro.Name = "cmbTipoRegistro";
            this.cmbTipoRegistro.Size = new System.Drawing.Size(300, 37);
            this.cmbTipoRegistro.TabIndex = 20;
            // 
            // cmbInstitucionOrigen
            // 
            this.cmbInstitucionOrigen.FormattingEnabled = true;
            this.cmbInstitucionOrigen.Location = new System.Drawing.Point(274, 176);
            this.cmbInstitucionOrigen.Name = "cmbInstitucionOrigen";
            this.cmbInstitucionOrigen.Size = new System.Drawing.Size(300, 37);
            this.cmbInstitucionOrigen.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaCarpetaInscripcion
            // 
            this.dtpFechaCarpetaInscripcion.Location = new System.Drawing.Point(155, 243);
            this.dtpFechaCarpetaInscripcion.Name = "dtpFechaCarpetaInscripcion";
            this.dtpFechaCarpetaInscripcion.Size = new System.Drawing.Size(460, 35);
            this.dtpFechaCarpetaInscripcion.TabIndex = 22;
            // 
            // frmCarpetaInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvCarpetaInscripcion);
            this.Controls.Add(this.gbxCarpetaInscripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmCarpetaInscripcion";
            this.Text = "frmCarpetaInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarpetaInscripcion)).EndInit();
            this.gbxCarpetaInscripcion.ResumeLayout(false);
            this.gbxCarpetaInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCarpetaInscripcion;
        private System.Windows.Forms.GroupBox gbxCarpetaInscripcion;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.ComboBox cmbTipoRegistro;
        private System.Windows.Forms.ComboBox cmbInstitucionOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaCarpetaInscripcion;
    }
}