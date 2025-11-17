namespace CapaPresentacion
{
    partial class frmNotas
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.gbxNotas = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbTipoEvaluacion = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaNumerica = new System.Windows.Forms.TextBox();
            this.txtIDMatriculaEst = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.gbxNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Notas";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(478, 308);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(73, 26);
            this.btnDeshabilitar.TabIndex = 53;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(402, 308);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 25);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(554, 308);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(73, 26);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvNota
            // 
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(13, 34);
            this.dgvNota.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.ReadOnly = true;
            this.dgvNota.RowHeadersWidth = 92;
            this.dgvNota.RowTemplate.Height = 37;
            this.dgvNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNota.Size = new System.Drawing.Size(614, 270);
            this.dgvNota.TabIndex = 48;
            // 
            // gbxNotas
            // 
            this.gbxNotas.Controls.Add(this.label7);
            this.gbxNotas.Controls.Add(this.dtpFecha);
            this.gbxNotas.Controls.Add(this.comboBox1);
            this.gbxNotas.Controls.Add(this.label6);
            this.gbxNotas.Controls.Add(this.cbEstudiante);
            this.gbxNotas.Controls.Add(this.cmbTipoEvaluacion);
            this.gbxNotas.Controls.Add(this.cbxEstado);
            this.gbxNotas.Controls.Add(this.btnAgregar);
            this.gbxNotas.Controls.Add(this.btnCancelar);
            this.gbxNotas.Controls.Add(this.label5);
            this.gbxNotas.Controls.Add(this.label4);
            this.gbxNotas.Controls.Add(this.label3);
            this.gbxNotas.Controls.Add(this.label2);
            this.gbxNotas.Controls.Add(this.txtNotaNumerica);
            this.gbxNotas.Controls.Add(this.txtIDMatriculaEst);
            this.gbxNotas.Location = new System.Drawing.Point(13, 338);
            this.gbxNotas.Margin = new System.Windows.Forms.Padding(2);
            this.gbxNotas.Name = "gbxNotas";
            this.gbxNotas.Padding = new System.Windows.Forms.Padding(2);
            this.gbxNotas.Size = new System.Drawing.Size(614, 195);
            this.gbxNotas.TabIndex = 50;
            this.gbxNotas.TabStop = false;
            this.gbxNotas.Text = "Notas de estudiantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(344, 97);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Curso";
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(111, 58);
            this.cbEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(145, 21);
            this.cbEstudiante.TabIndex = 15;
            // 
            // cmbTipoEvaluacion
            // 
            this.cmbTipoEvaluacion.FormattingEnabled = true;
            this.cmbTipoEvaluacion.Location = new System.Drawing.Point(111, 95);
            this.cmbTipoEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoEvaluacion.Name = "cmbTipoEvaluacion";
            this.cmbTipoEvaluacion.Size = new System.Drawing.Size(145, 21);
            this.cmbTipoEvaluacion.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(268, 138);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(111, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado de la Nota";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(389, 170);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 22);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(501, 170);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 22);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota Numerica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Evaluacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Nota";
            // 
            // txtNotaNumerica
            // 
            this.txtNotaNumerica.Location = new System.Drawing.Point(344, 56);
            this.txtNotaNumerica.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaNumerica.Name = "txtNotaNumerica";
            this.txtNotaNumerica.Size = new System.Drawing.Size(84, 20);
            this.txtNotaNumerica.TabIndex = 3;
            // 
            // txtIDMatriculaEst
            // 
            this.txtIDMatriculaEst.Location = new System.Drawing.Point(111, 23);
            this.txtIDMatriculaEst.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDMatriculaEst.Name = "txtIDMatriculaEst";
            this.txtIDMatriculaEst.Size = new System.Drawing.Size(62, 20);
            this.txtIDMatriculaEst.TabIndex = 1;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 546);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.gbxNotas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.gbxNotas.ResumeLayout(false);
            this.gbxNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.GroupBox gbxNotas;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaNumerica;
        private System.Windows.Forms.TextBox txtIDMatriculaEst;
        private System.Windows.Forms.ComboBox cmbTipoEvaluacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}