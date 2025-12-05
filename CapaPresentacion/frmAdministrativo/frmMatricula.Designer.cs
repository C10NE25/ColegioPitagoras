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
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAddGradoAcademico = new System.Windows.Forms.Button();
            this.cbGradoAcademico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.gpDatosInscripcion = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBidInscripcion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddInscripcion = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.gbxMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.gpDatosInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 83;
            this.label1.Text = "Matricula";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(529, 384);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 31);
            this.btnNuevo.TabIndex = 123;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(11, 47);
            this.dgvMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.ReadOnly = true;
            this.dgvMatricula.RowHeadersWidth = 30;
            this.dgvMatricula.RowTemplate.Height = 37;
            this.dgvMatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatricula.Size = new System.Drawing.Size(705, 332);
            this.dgvMatricula.TabIndex = 120;
            this.dgvMatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatricula_CellContentClick);
            // 
            // gbxMatricula
            // 
            this.gbxMatricula.Controls.Add(this.ckbEstado);
            this.gbxMatricula.Controls.Add(this.btnModificar);
            this.gbxMatricula.Controls.Add(this.btnAddGradoAcademico);
            this.gbxMatricula.Controls.Add(this.cbGradoAcademico);
            this.gbxMatricula.Controls.Add(this.label5);
            this.gbxMatricula.Controls.Add(this.label3);
            this.gbxMatricula.Controls.Add(this.dtpFechaMatricula);
            this.gbxMatricula.Controls.Add(this.btnAgregar);
            this.gbxMatricula.Controls.Add(this.btnCancelar);
            this.gbxMatricula.Controls.Add(this.label2);
            this.gbxMatricula.Controls.Add(this.txtIdMatricula);
            this.gbxMatricula.Location = new System.Drawing.Point(157, 420);
            this.gbxMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxMatricula.Name = "gbxMatricula";
            this.gbxMatricula.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxMatricula.Size = new System.Drawing.Size(445, 261);
            this.gbxMatricula.TabIndex = 122;
            this.gbxMatricula.TabStop = false;
            this.gbxMatricula.Text = "Datos de la Matricula";
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Checked = true;
            this.ckbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEstado.Location = new System.Drawing.Point(21, 154);
            this.ckbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(72, 20);
            this.ckbEstado.TabIndex = 30;
            this.ckbEstado.Text = "Estado";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(157, 198);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 38);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAddGradoAcademico
            // 
            this.btnAddGradoAcademico.Location = new System.Drawing.Point(355, 70);
            this.btnAddGradoAcademico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGradoAcademico.Name = "btnAddGradoAcademico";
            this.btnAddGradoAcademico.Size = new System.Drawing.Size(29, 26);
            this.btnAddGradoAcademico.TabIndex = 28;
            this.btnAddGradoAcademico.Text = "+";
            this.btnAddGradoAcademico.UseVisualStyleBackColor = true;
            this.btnAddGradoAcademico.Click += new System.EventHandler(this.btnAddGradoAcademico_Click);
            // 
            // cbGradoAcademico
            // 
            this.cbGradoAcademico.FormattingEnabled = true;
            this.cbGradoAcademico.Location = new System.Drawing.Point(157, 70);
            this.cbGradoAcademico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGradoAcademico.Name = "cbGradoAcademico";
            this.cbGradoAcademico.Size = new System.Drawing.Size(189, 24);
            this.cbGradoAcademico.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Grado Academico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(157, 112);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaMatricula.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 198);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(293, 199);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.Enabled = false;
            this.txtIdMatricula.Location = new System.Drawing.Point(157, 30);
            this.txtIdMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(81, 22);
            this.txtIdMatricula.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese ID Inscripcion:";
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(737, 47);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 30;
            this.dgvInscripcion.RowTemplate.Height = 37;
            this.dgvInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcion.Size = new System.Drawing.Size(583, 332);
            this.dgvInscripcion.TabIndex = 124;
            this.dgvInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellContentClick);
            // 
            // gpDatosInscripcion
            // 
            this.gpDatosInscripcion.Controls.Add(this.textBox2);
            this.gpDatosInscripcion.Controls.Add(this.label6);
            this.gpDatosInscripcion.Controls.Add(this.txtBidInscripcion);
            this.gpDatosInscripcion.Controls.Add(this.button2);
            this.gpDatosInscripcion.Controls.Add(this.btnAddInscripcion);
            this.gpDatosInscripcion.Controls.Add(this.label4);
            this.gpDatosInscripcion.Location = new System.Drawing.Point(761, 420);
            this.gpDatosInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosInscripcion.Name = "gpDatosInscripcion";
            this.gpDatosInscripcion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosInscripcion.Size = new System.Drawing.Size(520, 137);
            this.gpDatosInscripcion.TabIndex = 123;
            this.gpDatosInscripcion.TabStop = false;
            this.gpDatosInscripcion.Text = "Datos Inscripcion";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(215, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Estudiante:";
            // 
            // txtBidInscripcion
            // 
            this.txtBidInscripcion.Location = new System.Drawing.Point(215, 34);
            this.txtBidInscripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBidInscripcion.Name = "txtBidInscripcion";
            this.txtBidInscripcion.Size = new System.Drawing.Size(156, 22);
            this.txtBidInscripcion.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddInscripcion
            // 
            this.btnAddInscripcion.Location = new System.Drawing.Point(465, 34);
            this.btnAddInscripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddInscripcion.Name = "btnAddInscripcion";
            this.btnAddInscripcion.Size = new System.Drawing.Size(29, 26);
            this.btnAddInscripcion.TabIndex = 28;
            this.btnAddInscripcion.Text = "+";
            this.btnAddInscripcion.UseVisualStyleBackColor = true;
            this.btnAddInscripcion.Click += new System.EventHandler(this.btnAddInscripcion_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(625, 384);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 31);
            this.btnEditar.TabIndex = 125;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 694);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpDatosInscripcion);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.gbxMatricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.gbxMatricula.ResumeLayout(false);
            this.gbxMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.gpDatosInscripcion.ResumeLayout(false);
            this.gpDatosInscripcion.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddGradoAcademico;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.GroupBox gpDatosInscripcion;
        private System.Windows.Forms.TextBox txtBidInscripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddInscripcion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}