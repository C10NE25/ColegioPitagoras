namespace CapaPresentacion
{
    partial class frmInscripcion
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
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.gbxInscripcion = new System.Windows.Forms.GroupBox();
            this.btnAddEstudiante = new System.Windows.Forms.Button();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdInscripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.gbxInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Inscripcion";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(483, 308);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 25);
            this.btnNuevo.TabIndex = 129;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(13, 34);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 92;
            this.dgvInscripcion.RowTemplate.Height = 37;
            this.dgvInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcion.Size = new System.Drawing.Size(540, 270);
            this.dgvInscripcion.TabIndex = 126;
            // 
            // gbxInscripcion
            // 
            this.gbxInscripcion.Controls.Add(this.label3);
            this.gbxInscripcion.Controls.Add(this.dtpFechaInscripcion);
            this.gbxInscripcion.Controls.Add(this.btnAgregar);
            this.gbxInscripcion.Controls.Add(this.btnCancelar);
            this.gbxInscripcion.Controls.Add(this.label2);
            this.gbxInscripcion.Controls.Add(this.txtIdInscripcion);
            this.gbxInscripcion.Location = new System.Drawing.Point(13, 337);
            this.gbxInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInscripcion.Name = "gbxInscripcion";
            this.gbxInscripcion.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInscripcion.Size = new System.Drawing.Size(313, 195);
            this.gbxInscripcion.TabIndex = 128;
            this.gbxInscripcion.TabStop = false;
            this.gbxInscripcion.Text = "Datos de la Inscripcion";
            // 
            // btnAddEstudiante
            // 
            this.btnAddEstudiante.Location = new System.Drawing.Point(811, 357);
            this.btnAddEstudiante.Name = "btnAddEstudiante";
            this.btnAddEstudiante.Size = new System.Drawing.Size(22, 21);
            this.btnAddEstudiante.TabIndex = 26;
            this.btnAddEstudiante.Text = "+";
            this.btnAddEstudiante.UseVisualStyleBackColor = true;
            this.btnAddEstudiante.Click += new System.EventHandler(this.btnAddEstudiante_Click);
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(615, 358);
            this.cbEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(172, 21);
            this.cbEstudiante.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(86, 57);
            this.dtpFechaInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(191, 20);
            this.dtpFechaInscripcion.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(65, 143);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(151, 143);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdInscripcion
            // 
            this.txtIdInscripcion.Enabled = false;
            this.txtIdInscripcion.Location = new System.Drawing.Point(86, 27);
            this.txtIdInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdInscripcion.Name = "txtIdInscripcion";
            this.txtIdInscripcion.Size = new System.Drawing.Size(70, 20);
            this.txtIdInscripcion.TabIndex = 1;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 543);
            this.Controls.Add(this.btnAddEstudiante);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbEstudiante);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxInscripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.gbxInscripcion.ResumeLayout(false);
            this.gbxInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.GroupBox gbxInscripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdInscripcion;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEstudiante;
    }
}