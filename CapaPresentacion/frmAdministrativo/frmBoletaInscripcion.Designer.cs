namespace CapaPresentacion
{
    partial class frmBoletaInscripcion
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
            this.dgvBoletaInscripcion = new System.Windows.Forms.DataGridView();
            this.gbxBoletaInscripcion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaBoletaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCarpetaInscripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaInscripcion)).BeginInit();
            this.gbxBoletaInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 56);
            this.label1.TabIndex = 65;
            this.label1.Text = "Boleta de Inscripcion";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1629, 499);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 125;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1629, 359);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 124;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1629, 209);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 123;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1629, 642);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 121;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvBoletaInscripcion
            // 
            this.dgvBoletaInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletaInscripcion.Location = new System.Drawing.Point(92, 175);
            this.dgvBoletaInscripcion.Name = "dgvBoletaInscripcion";
            this.dgvBoletaInscripcion.ReadOnly = true;
            this.dgvBoletaInscripcion.RowHeadersWidth = 92;
            this.dgvBoletaInscripcion.RowTemplate.Height = 37;
            this.dgvBoletaInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletaInscripcion.Size = new System.Drawing.Size(1432, 601);
            this.dgvBoletaInscripcion.TabIndex = 120;
            // 
            // gbxBoletaInscripcion
            // 
            this.gbxBoletaInscripcion.Controls.Add(this.label3);
            this.gbxBoletaInscripcion.Controls.Add(this.dtpFechaBoletaInscripcion);
            this.gbxBoletaInscripcion.Controls.Add(this.cbxEstado);
            this.gbxBoletaInscripcion.Controls.Add(this.btnAgregar);
            this.gbxBoletaInscripcion.Controls.Add(this.btnModificar);
            this.gbxBoletaInscripcion.Controls.Add(this.btnCancelar);
            this.gbxBoletaInscripcion.Controls.Add(this.label2);
            this.gbxBoletaInscripcion.Controls.Add(this.txtIDCarpetaInscripcion);
            this.gbxBoletaInscripcion.Location = new System.Drawing.Point(296, 859);
            this.gbxBoletaInscripcion.Name = "gbxBoletaInscripcion";
            this.gbxBoletaInscripcion.Size = new System.Drawing.Size(1103, 435);
            this.gbxBoletaInscripcion.TabIndex = 122;
            this.gbxBoletaInscripcion.TabStop = false;
            this.gbxBoletaInscripcion.Text = "Datos de la Boleta de Inscripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaBoletaInscripcion
            // 
            this.dtpFechaBoletaInscripcion.Location = new System.Drawing.Point(147, 131);
            this.dtpFechaBoletaInscripcion.Name = "dtpFechaBoletaInscripcion";
            this.dtpFechaBoletaInscripcion.Size = new System.Drawing.Size(460, 35);
            this.dtpFechaBoletaInscripcion.TabIndex = 22;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 217);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(410, 33);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado de la Boleta de Inscripcion";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Carpeta Inscripcion:";
            // 
            // txtIDCarpetaInscripcion
            // 
            this.txtIDCarpetaInscripcion.Location = new System.Drawing.Point(285, 54);
            this.txtIDCarpetaInscripcion.Name = "txtIDCarpetaInscripcion";
            this.txtIDCarpetaInscripcion.Size = new System.Drawing.Size(139, 35);
            this.txtIDCarpetaInscripcion.TabIndex = 1;
            // 
            // frmBoletaInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1951, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvBoletaInscripcion);
            this.Controls.Add(this.gbxBoletaInscripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmBoletaInscripcion";
            this.Text = "frmBoletaInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaInscripcion)).EndInit();
            this.gbxBoletaInscripcion.ResumeLayout(false);
            this.gbxBoletaInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvBoletaInscripcion;
        private System.Windows.Forms.GroupBox gbxBoletaInscripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaBoletaInscripcion;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCarpetaInscripcion;
    }
}