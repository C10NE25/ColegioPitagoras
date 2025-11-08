namespace CapaPresentacion.frmAcademico
{
    partial class frmTipoAsistencia
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
            this.dgvTipoAsistencia = new System.Windows.Forms.DataGridView();
            this.gbxTipoAsistencia = new System.Windows.Forms.GroupBox();
            this.txtIdTipoAsistencia = new System.Windows.Forms.Label();
            this.txtTipoAsistencia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAsistencia)).BeginInit();
            this.gbxTipoAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tipo Asistencia";
            // 
            // dgvTipoAsistencia
            // 
            this.dgvTipoAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoAsistencia.Location = new System.Drawing.Point(17, 55);
            this.dgvTipoAsistencia.Name = "dgvTipoAsistencia";
            this.dgvTipoAsistencia.RowHeadersWidth = 51;
            this.dgvTipoAsistencia.RowTemplate.Height = 24;
            this.dgvTipoAsistencia.Size = new System.Drawing.Size(492, 151);
            this.dgvTipoAsistencia.TabIndex = 86;
            // 
            // gbxTipoAsistencia
            // 
            this.gbxTipoAsistencia.Controls.Add(this.btnAgregar);
            this.gbxTipoAsistencia.Controls.Add(this.btnModificar);
            this.gbxTipoAsistencia.Controls.Add(this.btnCancelar);
            this.gbxTipoAsistencia.Controls.Add(this.cbxEstado);
            this.gbxTipoAsistencia.Controls.Add(this.textBox2);
            this.gbxTipoAsistencia.Controls.Add(this.textBox1);
            this.gbxTipoAsistencia.Controls.Add(this.txtTipoAsistencia);
            this.gbxTipoAsistencia.Controls.Add(this.txtIdTipoAsistencia);
            this.gbxTipoAsistencia.Location = new System.Drawing.Point(17, 279);
            this.gbxTipoAsistencia.Name = "gbxTipoAsistencia";
            this.gbxTipoAsistencia.Size = new System.Drawing.Size(492, 200);
            this.gbxTipoAsistencia.TabIndex = 87;
            this.gbxTipoAsistencia.TabStop = false;
            this.gbxTipoAsistencia.Text = "Datos Tipo Asistencia";
            // 
            // txtIdTipoAsistencia
            // 
            this.txtIdTipoAsistencia.AutoSize = true;
            this.txtIdTipoAsistencia.Location = new System.Drawing.Point(7, 32);
            this.txtIdTipoAsistencia.Name = "txtIdTipoAsistencia";
            this.txtIdTipoAsistencia.Size = new System.Drawing.Size(108, 16);
            this.txtIdTipoAsistencia.TabIndex = 0;
            this.txtIdTipoAsistencia.Text = "idTipoAsistencia";
            // 
            // txtTipoAsistencia
            // 
            this.txtTipoAsistencia.AutoSize = true;
            this.txtTipoAsistencia.Location = new System.Drawing.Point(7, 77);
            this.txtTipoAsistencia.Name = "txtTipoAsistencia";
            this.txtTipoAsistencia.Size = new System.Drawing.Size(119, 16);
            this.txtTipoAsistencia.TabIndex = 1;
            this.txtTipoAsistencia.Text = "Tipo de Asistencia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 3;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(10, 126);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(187, 20);
            this.cbxEstado.TabIndex = 133;
            this.cbxEstado.Text = "Estado de Tipo Asistencia";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(384, 32);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 36);
            this.btnAgregar.TabIndex = 140;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(384, 77);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 36);
            this.btnModificar.TabIndex = 141;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(384, 126);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 36);
            this.btnCancelar.TabIndex = 142;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(262, 225);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(104, 30);
            this.btnDeshabilitar.TabIndex = 146;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(157, 223);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 32);
            this.btnEditar.TabIndex = 145;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(63, 224);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 31);
            this.btnNuevo.TabIndex = 144;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(370, 226);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 29);
            this.btnCerrar.TabIndex = 143;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmTipoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 503);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbxTipoAsistencia);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoAsistencia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoAsistencia";
            this.Text = "frmTipoAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAsistencia)).EndInit();
            this.gbxTipoAsistencia.ResumeLayout(false);
            this.gbxTipoAsistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoAsistencia;
        private System.Windows.Forms.GroupBox gbxTipoAsistencia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTipoAsistencia;
        private System.Windows.Forms.Label txtIdTipoAsistencia;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
    }
}