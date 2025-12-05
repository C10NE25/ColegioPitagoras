namespace CapaPresentacion
{
    partial class frmMatricula
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvMatricula = new System.Windows.Forms.DataGridView();
            this.gbxMatricula = new System.Windows.Forms.GroupBox();
            this.cbGradoAcademico = new System.Windows.Forms.ComboBox();
            this.cbInscripcion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.gbxMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 83;
            this.label1.Text = "Matricula";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(279, 312);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 25);
            this.btnNuevo.TabIndex = 123;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(8, 38);
            this.dgvMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.ReadOnly = true;
            this.dgvMatricula.RowHeadersWidth = 92;
            this.dgvMatricula.RowTemplate.Height = 37;
            this.dgvMatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatricula.Size = new System.Drawing.Size(339, 270);
            this.dgvMatricula.TabIndex = 120;
            // 
            // gbxMatricula
            // 
            this.gbxMatricula.Controls.Add(this.cbGradoAcademico);
            this.gbxMatricula.Controls.Add(this.label5);
            this.gbxMatricula.Controls.Add(this.label3);
            this.gbxMatricula.Controls.Add(this.dtpFechaMatricula);
            this.gbxMatricula.Controls.Add(this.btnAgregar);
            this.gbxMatricula.Controls.Add(this.btnCancelar);
            this.gbxMatricula.Controls.Add(this.label2);
            this.gbxMatricula.Controls.Add(this.txtIdMatricula);
            this.gbxMatricula.Location = new System.Drawing.Point(13, 341);
            this.gbxMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMatricula.Name = "gbxMatricula";
            this.gbxMatricula.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMatricula.Size = new System.Drawing.Size(334, 212);
            this.gbxMatricula.TabIndex = 122;
            this.gbxMatricula.TabStop = false;
            this.gbxMatricula.Text = "Datos de la Matricula";
            // 
            // cbGradoAcademico
            // 
            this.cbGradoAcademico.FormattingEnabled = true;
            this.cbGradoAcademico.Location = new System.Drawing.Point(118, 57);
            this.cbGradoAcademico.Margin = new System.Windows.Forms.Padding(2);
            this.cbGradoAcademico.Name = "cbGradoAcademico";
            this.cbGradoAcademico.Size = new System.Drawing.Size(143, 21);
            this.cbGradoAcademico.TabIndex = 27;
            // 
            // cbInscripcion
            // 
            this.cbInscripcion.FormattingEnabled = true;
            this.cbInscripcion.Location = new System.Drawing.Point(502, 362);
            this.cbInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.cbInscripcion.Name = "cbInscripcion";
            this.cbInscripcion.Size = new System.Drawing.Size(143, 21);
            this.cbInscripcion.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Grado Academico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Location = new System.Drawing.Point(118, 91);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMatricula.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(61, 161);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(163, 161);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Matricula";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.Location = new System.Drawing.Point(118, 24);
            this.txtIdMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(62, 20);
            this.txtIdMatricula.TabIndex = 1;
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 581);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbInscripcion);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.gbxMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.gbxMatricula.ResumeLayout(false);
            this.gbxMatricula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvMatricula;
        private System.Windows.Forms.GroupBox gbxMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMatricula;
        private System.Windows.Forms.ComboBox cbGradoAcademico;
        private System.Windows.Forms.ComboBox cbInscripcion;
        private System.Windows.Forms.Label label5;
    }
}