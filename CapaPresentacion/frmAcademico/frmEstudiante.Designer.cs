namespace CapaPresentacion
{
    partial class frmEstudiante
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.gbxEstudiante = new System.Windows.Forms.GroupBox();
            this.txtApellidoMEstudiante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaNacEstudiante = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.txtApellidoPEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.txtBDniEstudiante = new System.Windows.Forms.TextBox();
            this.dtgApoderado = new System.Windows.Forms.DataGridView();
            this.gbDatosApoderado = new System.Windows.Forms.GroupBox();
            this.btnAddApoderado = new System.Windows.Forms.Button();
            this.txtBApellidoMApoderado = new System.Windows.Forms.TextBox();
            this.txtBDniApoderado = new System.Windows.Forms.TextBox();
            this.txtBApellidoPApoderado = new System.Windows.Forms.TextBox();
            this.txtBNameApoderado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchApoderado = new System.Windows.Forms.Button();
            this.txtBSearchApoderado = new System.Windows.Forms.TextBox();
            this.lbldniApoderado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.gbxEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApoderado)).BeginInit();
            this.gbDatosApoderado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estudiante";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(110, 311);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 24);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(17, 311);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 24);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(17, 36);
            this.dgvEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersWidth = 30;
            this.dgvEstudiante.RowTemplate.Height = 37;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(450, 269);
            this.dgvEstudiante.TabIndex = 12;
            this.dgvEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellClick);
            this.dgvEstudiante.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEstudiante_DataBindingComplete);
            // 
            // gbxEstudiante
            // 
            this.gbxEstudiante.Controls.Add(this.txtApellidoMEstudiante);
            this.gbxEstudiante.Controls.Add(this.label9);
            this.gbxEstudiante.Controls.Add(this.dtpFechaNacEstudiante);
            this.gbxEstudiante.Controls.Add(this.label8);
            this.gbxEstudiante.Controls.Add(this.cbxEstado);
            this.gbxEstudiante.Controls.Add(this.label7);
            this.gbxEstudiante.Controls.Add(this.btnAgregar);
            this.gbxEstudiante.Controls.Add(this.btnModificar);
            this.gbxEstudiante.Controls.Add(this.btnCancelar);
            this.gbxEstudiante.Controls.Add(this.label5);
            this.gbxEstudiante.Controls.Add(this.label4);
            this.gbxEstudiante.Controls.Add(this.label3);
            this.gbxEstudiante.Controls.Add(this.label2);
            this.gbxEstudiante.Controls.Add(this.txtDireccionEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtApellidoPEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtNombreEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtIDEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtBDniEstudiante);
            this.gbxEstudiante.Location = new System.Drawing.Point(17, 337);
            this.gbxEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.gbxEstudiante.Name = "gbxEstudiante";
            this.gbxEstudiante.Padding = new System.Windows.Forms.Padding(1);
            this.gbxEstudiante.Size = new System.Drawing.Size(513, 222);
            this.gbxEstudiante.TabIndex = 14;
            this.gbxEstudiante.TabStop = false;
            this.gbxEstudiante.Text = "Datos del Estudiante";
            // 
            // txtApellidoMEstudiante
            // 
            this.txtApellidoMEstudiante.Location = new System.Drawing.Point(99, 140);
            this.txtApellidoMEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtApellidoMEstudiante.Name = "txtApellidoMEstudiante";
            this.txtApellidoMEstudiante.Size = new System.Drawing.Size(127, 20);
            this.txtApellidoMEstudiante.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apellido Materno";
            // 
            // dtpFechaNacEstudiante
            // 
            this.dtpFechaNacEstudiante.Location = new System.Drawing.Point(367, 79);
            this.dtpFechaNacEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.dtpFechaNacEstudiante.Name = "dtpFechaNacEstudiante";
            this.dtpFechaNacEstudiante.Size = new System.Drawing.Size(127, 20);
            this.dtpFechaNacEstudiante.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(257, 116);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(129, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Estudiante";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(85, 176);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(199, 177);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 27);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(310, 177);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtDireccionEstudiante
            // 
            this.txtDireccionEstudiante.Location = new System.Drawing.Point(367, 47);
            this.txtDireccionEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtDireccionEstudiante.Name = "txtDireccionEstudiante";
            this.txtDireccionEstudiante.Size = new System.Drawing.Size(127, 20);
            this.txtDireccionEstudiante.TabIndex = 5;
            // 
            // txtApellidoPEstudiante
            // 
            this.txtApellidoPEstudiante.Location = new System.Drawing.Point(99, 111);
            this.txtApellidoPEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtApellidoPEstudiante.Name = "txtApellidoPEstudiante";
            this.txtApellidoPEstudiante.Size = new System.Drawing.Size(127, 20);
            this.txtApellidoPEstudiante.TabIndex = 3;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(99, 82);
            this.txtNombreEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(127, 20);
            this.txtNombreEstudiante.TabIndex = 2;
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Location = new System.Drawing.Point(99, 24);
            this.txtIDEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.Size = new System.Drawing.Size(62, 20);
            this.txtIDEstudiante.TabIndex = 1;
            // 
            // txtBDniEstudiante
            // 
            this.txtBDniEstudiante.Location = new System.Drawing.Point(99, 53);
            this.txtBDniEstudiante.Margin = new System.Windows.Forms.Padding(1);
            this.txtBDniEstudiante.Name = "txtBDniEstudiante";
            this.txtBDniEstudiante.Size = new System.Drawing.Size(127, 20);
            this.txtBDniEstudiante.TabIndex = 0;
            // 
            // dtgApoderado
            // 
            this.dtgApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApoderado.Location = new System.Drawing.Point(476, 36);
            this.dtgApoderado.Margin = new System.Windows.Forms.Padding(1);
            this.dtgApoderado.Name = "dtgApoderado";
            this.dtgApoderado.ReadOnly = true;
            this.dtgApoderado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgApoderado.RowHeadersWidth = 30;
            this.dtgApoderado.RowTemplate.Height = 37;
            this.dtgApoderado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgApoderado.Size = new System.Drawing.Size(450, 269);
            this.dtgApoderado.TabIndex = 17;
            this.dtgApoderado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgApoderado_CellContentClick);
            // 
            // gbDatosApoderado
            // 
            this.gbDatosApoderado.Controls.Add(this.btnAddApoderado);
            this.gbDatosApoderado.Controls.Add(this.txtBApellidoMApoderado);
            this.gbDatosApoderado.Controls.Add(this.txtBDniApoderado);
            this.gbDatosApoderado.Controls.Add(this.txtBApellidoPApoderado);
            this.gbDatosApoderado.Controls.Add(this.txtBNameApoderado);
            this.gbDatosApoderado.Controls.Add(this.label13);
            this.gbDatosApoderado.Controls.Add(this.label12);
            this.gbDatosApoderado.Controls.Add(this.label11);
            this.gbDatosApoderado.Controls.Add(this.label10);
            this.gbDatosApoderado.Controls.Add(this.btnSearchApoderado);
            this.gbDatosApoderado.Controls.Add(this.txtBSearchApoderado);
            this.gbDatosApoderado.Controls.Add(this.lbldniApoderado);
            this.gbDatosApoderado.Location = new System.Drawing.Point(544, 337);
            this.gbDatosApoderado.Name = "gbDatosApoderado";
            this.gbDatosApoderado.Size = new System.Drawing.Size(373, 222);
            this.gbDatosApoderado.TabIndex = 18;
            this.gbDatosApoderado.TabStop = false;
            this.gbDatosApoderado.Text = "Datos del Apoderado";
            // 
            // btnAddApoderado
            // 
            this.btnAddApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddApoderado.Location = new System.Drawing.Point(337, 26);
            this.btnAddApoderado.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddApoderado.Name = "btnAddApoderado";
            this.btnAddApoderado.Size = new System.Drawing.Size(20, 20);
            this.btnAddApoderado.TabIndex = 39;
            this.btnAddApoderado.Text = "+";
            this.btnAddApoderado.UseVisualStyleBackColor = true;
            this.btnAddApoderado.Click += new System.EventHandler(this.btnAddApoderado_Click);
            // 
            // txtBApellidoMApoderado
            // 
            this.txtBApellidoMApoderado.Location = new System.Drawing.Point(137, 146);
            this.txtBApellidoMApoderado.Name = "txtBApellidoMApoderado";
            this.txtBApellidoMApoderado.ReadOnly = true;
            this.txtBApellidoMApoderado.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoMApoderado.TabIndex = 38;
            // 
            // txtBDniApoderado
            // 
            this.txtBDniApoderado.Location = new System.Drawing.Point(137, 176);
            this.txtBDniApoderado.Name = "txtBDniApoderado";
            this.txtBDniApoderado.ReadOnly = true;
            this.txtBDniApoderado.Size = new System.Drawing.Size(138, 20);
            this.txtBDniApoderado.TabIndex = 37;
            // 
            // txtBApellidoPApoderado
            // 
            this.txtBApellidoPApoderado.Location = new System.Drawing.Point(137, 110);
            this.txtBApellidoPApoderado.Name = "txtBApellidoPApoderado";
            this.txtBApellidoPApoderado.ReadOnly = true;
            this.txtBApellidoPApoderado.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoPApoderado.TabIndex = 36;
            // 
            // txtBNameApoderado
            // 
            this.txtBNameApoderado.Location = new System.Drawing.Point(137, 75);
            this.txtBNameApoderado.Name = "txtBNameApoderado";
            this.txtBNameApoderado.ReadOnly = true;
            this.txtBNameApoderado.Size = new System.Drawing.Size(138, 20);
            this.txtBNameApoderado.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(46, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Apellido Materno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(46, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "DNI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(46, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Apellido Paterno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(46, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nombre:";
            // 
            // btnSearchApoderado
            // 
            this.btnSearchApoderado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchApoderado.Location = new System.Drawing.Point(279, 25);
            this.btnSearchApoderado.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchApoderado.Name = "btnSearchApoderado";
            this.btnSearchApoderado.Size = new System.Drawing.Size(56, 20);
            this.btnSearchApoderado.TabIndex = 30;
            this.btnSearchApoderado.Text = "Buscar";
            this.btnSearchApoderado.UseVisualStyleBackColor = true;
            this.btnSearchApoderado.Click += new System.EventHandler(this.btnSearchApoderado_Click);
            // 
            // txtBSearchApoderado
            // 
            this.txtBSearchApoderado.Location = new System.Drawing.Point(102, 26);
            this.txtBSearchApoderado.Name = "txtBSearchApoderado";
            this.txtBSearchApoderado.Size = new System.Drawing.Size(173, 20);
            this.txtBSearchApoderado.TabIndex = 29;
            // 
            // lbldniApoderado
            // 
            this.lbldniApoderado.AutoSize = true;
            this.lbldniApoderado.Location = new System.Drawing.Point(16, 29);
            this.lbldniApoderado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldniApoderado.Name = "lbldniApoderado";
            this.lbldniApoderado.Size = new System.Drawing.Size(78, 13);
            this.lbldniApoderado.TabIndex = 28;
            this.lbldniApoderado.Text = "Ingrese el DNI:";
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 574);
            this.Controls.Add(this.gbDatosApoderado);
            this.Controls.Add(this.dtgApoderado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.gbxEstudiante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.gbxEstudiante.ResumeLayout(false);
            this.gbxEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApoderado)).EndInit();
            this.gbDatosApoderado.ResumeLayout(false);
            this.gbDatosApoderado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.GroupBox gbxEstudiante;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionEstudiante;
        private System.Windows.Forms.TextBox txtApellidoPEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.TextBox txtBDniEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacEstudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidoMEstudiante;
        private System.Windows.Forms.DataGridView dtgApoderado;
        private System.Windows.Forms.GroupBox gbDatosApoderado;
        private System.Windows.Forms.TextBox txtBApellidoMApoderado;
        private System.Windows.Forms.TextBox txtBDniApoderado;
        private System.Windows.Forms.TextBox txtBApellidoPApoderado;
        private System.Windows.Forms.TextBox txtBNameApoderado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchApoderado;
        private System.Windows.Forms.TextBox txtBSearchApoderado;
        private System.Windows.Forms.Label lbldniApoderado;
        private System.Windows.Forms.Button btnAddApoderado;
    }
}