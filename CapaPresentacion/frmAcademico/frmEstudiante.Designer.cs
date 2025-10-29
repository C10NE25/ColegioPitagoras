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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.gbxEstudiante = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.txtIDTutor = new System.Windows.Forms.TextBox();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.txtDniEstudiante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacEstudiante = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.gbxEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estudiante";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1634, 491);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 17;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1634, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1634, 201);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1634, 634);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(97, 167);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersWidth = 92;
            this.dgvEstudiante.RowTemplate.Height = 37;
            this.dgvEstudiante.Size = new System.Drawing.Size(1432, 601);
            this.dgvEstudiante.TabIndex = 12;
            this.dgvEstudiante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellDoubleClick);
            // 
            // gbxEstudiante
            // 
            this.gbxEstudiante.Controls.Add(this.dtpFechaNacEstudiante);
            this.gbxEstudiante.Controls.Add(this.label8);
            this.gbxEstudiante.Controls.Add(this.cbxEstado);
            this.gbxEstudiante.Controls.Add(this.label7);
            this.gbxEstudiante.Controls.Add(this.btnAgregar);
            this.gbxEstudiante.Controls.Add(this.btnModificar);
            this.gbxEstudiante.Controls.Add(this.btnCancelar);
            this.gbxEstudiante.Controls.Add(this.label6);
            this.gbxEstudiante.Controls.Add(this.label5);
            this.gbxEstudiante.Controls.Add(this.label4);
            this.gbxEstudiante.Controls.Add(this.label3);
            this.gbxEstudiante.Controls.Add(this.label2);
            this.gbxEstudiante.Controls.Add(this.txtDireccionEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtIDTutor);
            this.gbxEstudiante.Controls.Add(this.txtApellidoEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtNombreEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtIDEstudiante);
            this.gbxEstudiante.Controls.Add(this.txtDniEstudiante);
            this.gbxEstudiante.Location = new System.Drawing.Point(108, 857);
            this.gbxEstudiante.Name = "gbxEstudiante";
            this.gbxEstudiante.Size = new System.Drawing.Size(1562, 435);
            this.gbxEstudiante.TabIndex = 14;
            this.gbxEstudiante.TabStop = false;
            this.gbxEstudiante.Text = "Datos del Estudiante";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(665, 257);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(223, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Tutor";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(1282, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(1282, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1282, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id Tutor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del Estudiante:";
            // 
            // txtDireccionEstudiante
            // 
            this.txtDireccionEstudiante.Location = new System.Drawing.Point(827, 107);
            this.txtDireccionEstudiante.Name = "txtDireccionEstudiante";
            this.txtDireccionEstudiante.Size = new System.Drawing.Size(338, 35);
            this.txtDireccionEstudiante.TabIndex = 5;
            // 
            // txtIDTutor
            // 
            this.txtIDTutor.Location = new System.Drawing.Point(807, 186);
            this.txtIDTutor.Name = "txtIDTutor";
            this.txtIDTutor.Size = new System.Drawing.Size(338, 35);
            this.txtIDTutor.TabIndex = 4;
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(179, 251);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(338, 35);
            this.txtApellidoEstudiante.TabIndex = 3;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(179, 186);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(338, 35);
            this.txtNombreEstudiante.TabIndex = 2;
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Location = new System.Drawing.Point(231, 54);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.Size = new System.Drawing.Size(139, 35);
            this.txtIDEstudiante.TabIndex = 1;
            // 
            // txtDniEstudiante
            // 
            this.txtDniEstudiante.Location = new System.Drawing.Point(179, 127);
            this.txtDniEstudiante.Name = "txtDniEstudiante";
            this.txtDniEstudiante.Size = new System.Drawing.Size(338, 35);
            this.txtDniEstudiante.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacEstudiante
            // 
            this.dtpFechaNacEstudiante.Location = new System.Drawing.Point(292, 328);
            this.dtpFechaNacEstudiante.Name = "dtpFechaNacEstudiante";
            this.dtpFechaNacEstudiante.Size = new System.Drawing.Size(438, 35);
            this.dtpFechaNacEstudiante.TabIndex = 15;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1962, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.gbxEstudiante);
            this.Controls.Add(this.label1);
            this.Name = "frmEstudiante";
            this.Text = "frmEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.gbxEstudiante.ResumeLayout(false);
            this.gbxEstudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.GroupBox gbxEstudiante;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionEstudiante;
        private System.Windows.Forms.TextBox txtIDTutor;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.TextBox txtDniEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacEstudiante;
    }
}