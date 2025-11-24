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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSearchEstudiante = new System.Windows.Forms.Label();
            this.lblidMatricula = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBSearchInscripcion = new System.Windows.Forms.TextBox();
            this.btnSearchInscripcion = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.txtBApellidoMEstudiante = new System.Windows.Forms.TextBox();
            this.txtBDniEstudiante = new System.Windows.Forms.TextBox();
            this.txtBApellidoPEstudiante = new System.Windows.Forms.TextBox();
            this.txtBNameEstudiante = new System.Windows.Forms.TextBox();
            this.lblApellidoMEstudiante = new System.Windows.Forms.Label();
            this.lbldniEstudiante = new System.Windows.Forms.Label();
            this.lblApellidoPEstudiante = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.gbxMatricula.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
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
            this.btnNuevo.Location = new System.Drawing.Point(453, 312);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 24);
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
            this.dgvMatricula.Size = new System.Drawing.Size(594, 270);
            this.dgvMatricula.TabIndex = 120;
            this.dgvMatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatricula_CellContentClick);
            // 
            // gbxMatricula
            // 
            this.gbxMatricula.Controls.Add(this.cbGradoAcademico);
            this.gbxMatricula.Controls.Add(this.label5);
            this.gbxMatricula.Controls.Add(this.label3);
            this.gbxMatricula.Controls.Add(this.dtpFechaMatricula);
            this.gbxMatricula.Controls.Add(this.cbxEstado);
            this.gbxMatricula.Controls.Add(this.btnAgregar);
            this.gbxMatricula.Controls.Add(this.btnModificar);
            this.gbxMatricula.Controls.Add(this.btnCancelar);
            this.gbxMatricula.Controls.Add(this.lblidMatricula);
            this.gbxMatricula.Controls.Add(this.txtIdMatricula);
            this.gbxMatricula.Location = new System.Drawing.Point(102, 340);
            this.gbxMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMatricula.Name = "gbxMatricula";
            this.gbxMatricula.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMatricula.Size = new System.Drawing.Size(411, 201);
            this.gbxMatricula.TabIndex = 122;
            this.gbxMatricula.TabStop = false;
            this.gbxMatricula.Text = "Datos de la Matricula";
            // 
            // cbGradoAcademico
            // 
            this.cbGradoAcademico.FormattingEnabled = true;
            this.cbGradoAcademico.Location = new System.Drawing.Point(118, 60);
            this.cbGradoAcademico.Margin = new System.Windows.Forms.Padding(2);
            this.cbGradoAcademico.Name = "cbGradoAcademico";
            this.cbGradoAcademico.Size = new System.Drawing.Size(143, 21);
            this.cbGradoAcademico.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Grado Academico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Location = new System.Drawing.Point(118, 95);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMatricula.TabIndex = 22;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(16, 133);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(131, 17);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado de la Matricula";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(44, 161);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(146, 163);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 29);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(248, 163);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblSearchEstudiante
            // 
            this.lblSearchEstudiante.AutoSize = true;
            this.lblSearchEstudiante.Location = new System.Drawing.Point(38, 34);
            this.lblSearchEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEstudiante.Name = "lblSearchEstudiante";
            this.lblSearchEstudiante.Size = new System.Drawing.Size(67, 13);
            this.lblSearchEstudiante.TabIndex = 9;
            this.lblSearchEstudiante.Text = "Ingrese el id:";
            // 
            // lblidMatricula
            // 
            this.lblidMatricula.AutoSize = true;
            this.lblidMatricula.Location = new System.Drawing.Point(11, 25);
            this.lblidMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidMatricula.Name = "lblidMatricula";
            this.lblidMatricula.Size = new System.Drawing.Size(21, 13);
            this.lblidMatricula.TabIndex = 7;
            this.lblidMatricula.Text = "ID:";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.Enabled = false;
            this.txtIdMatricula.Location = new System.Drawing.Point(118, 24);
            this.txtIdMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(62, 20);
            this.txtIdMatricula.TabIndex = 1;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(525, 312);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(78, 24);
            this.btnDeshabilitar.TabIndex = 125;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBApellidoMEstudiante);
            this.groupBox1.Controls.Add(this.txtBDniEstudiante);
            this.groupBox1.Controls.Add(this.txtBApellidoPEstudiante);
            this.groupBox1.Controls.Add(this.txtBNameEstudiante);
            this.groupBox1.Controls.Add(this.lblApellidoMEstudiante);
            this.groupBox1.Controls.Add(this.lbldniEstudiante);
            this.groupBox1.Controls.Add(this.lblApellidoPEstudiante);
            this.groupBox1.Controls.Add(this.lblNombreEstudiante);
            this.groupBox1.Controls.Add(this.btnSearchInscripcion);
            this.groupBox1.Controls.Add(this.txtBSearchInscripcion);
            this.groupBox1.Controls.Add(this.lblSearchEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(701, 340);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 201);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Inscripcion";
            // 
            // txtBSearchInscripcion
            // 
            this.txtBSearchInscripcion.Location = new System.Drawing.Point(123, 31);
            this.txtBSearchInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtBSearchInscripcion.Name = "txtBSearchInscripcion";
            this.txtBSearchInscripcion.Size = new System.Drawing.Size(143, 20);
            this.txtBSearchInscripcion.TabIndex = 28;
            // 
            // btnSearchInscripcion
            // 
            this.btnSearchInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchInscripcion.Location = new System.Drawing.Point(270, 30);
            this.btnSearchInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchInscripcion.Name = "btnSearchInscripcion";
            this.btnSearchInscripcion.Size = new System.Drawing.Size(75, 21);
            this.btnSearchInscripcion.TabIndex = 28;
            this.btnSearchInscripcion.Text = "Buscar";
            this.btnSearchInscripcion.UseVisualStyleBackColor = true;
            this.btnSearchInscripcion.Click += new System.EventHandler(this.btnSearchInscripcion_Click);
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(615, 38);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 92;
            this.dgvInscripcion.RowTemplate.Height = 37;
            this.dgvInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcion.Size = new System.Drawing.Size(541, 270);
            this.dgvInscripcion.TabIndex = 126;
            this.dgvInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellContentClick);
            // 
            // txtBApellidoMEstudiante
            // 
            this.txtBApellidoMEstudiante.Location = new System.Drawing.Point(170, 135);
            this.txtBApellidoMEstudiante.Name = "txtBApellidoMEstudiante";
            this.txtBApellidoMEstudiante.ReadOnly = true;
            this.txtBApellidoMEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoMEstudiante.TabIndex = 150;
            // 
            // txtBDniEstudiante
            // 
            this.txtBDniEstudiante.Location = new System.Drawing.Point(170, 165);
            this.txtBDniEstudiante.Name = "txtBDniEstudiante";
            this.txtBDniEstudiante.ReadOnly = true;
            this.txtBDniEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBDniEstudiante.TabIndex = 149;
            // 
            // txtBApellidoPEstudiante
            // 
            this.txtBApellidoPEstudiante.Location = new System.Drawing.Point(170, 99);
            this.txtBApellidoPEstudiante.Name = "txtBApellidoPEstudiante";
            this.txtBApellidoPEstudiante.ReadOnly = true;
            this.txtBApellidoPEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoPEstudiante.TabIndex = 148;
            // 
            // txtBNameEstudiante
            // 
            this.txtBNameEstudiante.Location = new System.Drawing.Point(170, 64);
            this.txtBNameEstudiante.Name = "txtBNameEstudiante";
            this.txtBNameEstudiante.ReadOnly = true;
            this.txtBNameEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBNameEstudiante.TabIndex = 147;
            // 
            // lblApellidoMEstudiante
            // 
            this.lblApellidoMEstudiante.AutoSize = true;
            this.lblApellidoMEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoMEstudiante.Location = new System.Drawing.Point(79, 138);
            this.lblApellidoMEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoMEstudiante.Name = "lblApellidoMEstudiante";
            this.lblApellidoMEstudiante.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMEstudiante.TabIndex = 146;
            this.lblApellidoMEstudiante.Text = "Apellido Materno:";
            // 
            // lbldniEstudiante
            // 
            this.lbldniEstudiante.AutoSize = true;
            this.lbldniEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lbldniEstudiante.Location = new System.Drawing.Point(79, 172);
            this.lbldniEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldniEstudiante.Name = "lbldniEstudiante";
            this.lbldniEstudiante.Size = new System.Drawing.Size(29, 13);
            this.lbldniEstudiante.TabIndex = 145;
            this.lbldniEstudiante.Text = "DNI:";
            // 
            // lblApellidoPEstudiante
            // 
            this.lblApellidoPEstudiante.AutoSize = true;
            this.lblApellidoPEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoPEstudiante.Location = new System.Drawing.Point(79, 102);
            this.lblApellidoPEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoPEstudiante.Name = "lblApellidoPEstudiante";
            this.lblApellidoPEstudiante.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPEstudiante.TabIndex = 144;
            this.lblApellidoPEstudiante.Text = "Apellido Paterno:";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(79, 67);
            this.lblNombreEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEstudiante.TabIndex = 143;
            this.lblNombreEstudiante.Text = "Nombre:";
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 552);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.gbxMatricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.gbxMatricula.ResumeLayout(false);
            this.gbxMatricula.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
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
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSearchEstudiante;
        private System.Windows.Forms.Label lblidMatricula;
        private System.Windows.Forms.TextBox txtIdMatricula;
        private System.Windows.Forms.ComboBox cbGradoAcademico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchInscripcion;
        private System.Windows.Forms.TextBox txtBSearchInscripcion;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.TextBox txtBApellidoMEstudiante;
        private System.Windows.Forms.TextBox txtBDniEstudiante;
        private System.Windows.Forms.TextBox txtBApellidoPEstudiante;
        private System.Windows.Forms.TextBox txtBNameEstudiante;
        private System.Windows.Forms.Label lblApellidoMEstudiante;
        private System.Windows.Forms.Label lbldniEstudiante;
        private System.Windows.Forms.Label lblApellidoPEstudiante;
        private System.Windows.Forms.Label lblNombreEstudiante;
    }
}