namespace CapaPresentacion
{
    partial class frmBoletaMatricula
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
            this.dgvBoletaMatricula = new System.Windows.Forms.DataGridView();
            this.gbxBoletaMatricula = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaBoletaMatricula = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDInscripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaMatricula)).BeginInit();
            this.gbxBoletaMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 56);
            this.label1.TabIndex = 71;
            this.label1.Text = "Boleta de Matricula";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1637, 503);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 132;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1637, 363);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 131;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1637, 213);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 130;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1637, 646);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 128;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvBoletaMatricula
            // 
            this.dgvBoletaMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletaMatricula.Location = new System.Drawing.Point(100, 179);
            this.dgvBoletaMatricula.Name = "dgvBoletaMatricula";
            this.dgvBoletaMatricula.ReadOnly = true;
            this.dgvBoletaMatricula.RowHeadersWidth = 92;
            this.dgvBoletaMatricula.RowTemplate.Height = 37;
            this.dgvBoletaMatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletaMatricula.Size = new System.Drawing.Size(1432, 601);
            this.dgvBoletaMatricula.TabIndex = 127;
            // 
            // gbxBoletaMatricula
            // 
            this.gbxBoletaMatricula.Controls.Add(this.label3);
            this.gbxBoletaMatricula.Controls.Add(this.dtpFechaBoletaMatricula);
            this.gbxBoletaMatricula.Controls.Add(this.cbxEstado);
            this.gbxBoletaMatricula.Controls.Add(this.btnAgregar);
            this.gbxBoletaMatricula.Controls.Add(this.btnModificar);
            this.gbxBoletaMatricula.Controls.Add(this.btnCancelar);
            this.gbxBoletaMatricula.Controls.Add(this.label2);
            this.gbxBoletaMatricula.Controls.Add(this.txtIDInscripcion);
            this.gbxBoletaMatricula.Location = new System.Drawing.Point(304, 863);
            this.gbxBoletaMatricula.Name = "gbxBoletaMatricula";
            this.gbxBoletaMatricula.Size = new System.Drawing.Size(1103, 435);
            this.gbxBoletaMatricula.TabIndex = 129;
            this.gbxBoletaMatricula.TabStop = false;
            this.gbxBoletaMatricula.Text = "Datos de la Boleta de Matricula";
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
            // dtpFechaBoletaMatricula
            // 
            this.dtpFechaBoletaMatricula.Location = new System.Drawing.Point(147, 131);
            this.dtpFechaBoletaMatricula.Name = "dtpFechaBoletaMatricula";
            this.dtpFechaBoletaMatricula.Size = new System.Drawing.Size(460, 35);
            this.dtpFechaBoletaMatricula.TabIndex = 22;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 217);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(391, 33);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado de la Boleta de Matricula";
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
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Inscripcion:";
            // 
            // txtIDInscripcion
            // 
            this.txtIDInscripcion.Location = new System.Drawing.Point(247, 54);
            this.txtIDInscripcion.Name = "txtIDInscripcion";
            this.txtIDInscripcion.Size = new System.Drawing.Size(139, 35);
            this.txtIDInscripcion.TabIndex = 1;
            // 
            // frmBoletaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1966, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvBoletaMatricula);
            this.Controls.Add(this.gbxBoletaMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmBoletaMatricula";
            this.Text = "frmBoletaMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaMatricula)).EndInit();
            this.gbxBoletaMatricula.ResumeLayout(false);
            this.gbxBoletaMatricula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvBoletaMatricula;
        private System.Windows.Forms.GroupBox gbxBoletaMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaBoletaMatricula;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDInscripcion;
    }
}