namespace CapaPresentacion
{
    partial class frmCurso
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
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.gbxCurso = new System.Windows.Forms.GroupBox();
            this.btnAddAsignatura = new System.Windows.Forms.Button();
            this.btnAddGradoAcademico = new System.Windows.Forms.Button();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.cbGradoAcademico = new System.Windows.Forms.ComboBox();
            this.lblAreaAcademica = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidCurso = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblSearchDniDocente = new System.Windows.Forms.Label();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.gbDatosDocente = new System.Windows.Forms.GroupBox();
            this.txtBApellidoMDocente = new System.Windows.Forms.TextBox();
            this.txtBDniDocente = new System.Windows.Forms.TextBox();
            this.txtBApellidoPDocente = new System.Windows.Forms.TextBox();
            this.txtBNameDocente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchDocente = new System.Windows.Forms.Button();
            this.btnAddDocente = new System.Windows.Forms.Button();
            this.txtBSearchDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.gbxCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.gbDatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Curso";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(571, 362);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 28);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(459, 362);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 30);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(17, 50);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.RowHeadersWidth = 30;
            this.dgvCurso.RowTemplate.Height = 37;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(660, 306);
            this.dgvCurso.TabIndex = 36;
            this.dgvCurso.CellBorderStyleChanged += new System.EventHandler(this.dgvCurso_CellBorderStyleChanged);
            this.dgvCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellClick);
            // 
            // gbxCurso
            // 
            this.gbxCurso.Controls.Add(this.btnAddAsignatura);
            this.gbxCurso.Controls.Add(this.btnAddGradoAcademico);
            this.gbxCurso.Controls.Add(this.cbAsignatura);
            this.gbxCurso.Controls.Add(this.cbGradoAcademico);
            this.gbxCurso.Controls.Add(this.lblAreaAcademica);
            this.gbxCurso.Controls.Add(this.label4);
            this.gbxCurso.Controls.Add(this.cbxEstado);
            this.gbxCurso.Controls.Add(this.btnAgregar);
            this.gbxCurso.Controls.Add(this.btnModificar);
            this.gbxCurso.Controls.Add(this.btnCancelar);
            this.gbxCurso.Controls.Add(this.label3);
            this.gbxCurso.Controls.Add(this.lblidCurso);
            this.gbxCurso.Controls.Add(this.txtIDCurso);
            this.gbxCurso.Controls.Add(this.txtNombreCurso);
            this.gbxCurso.Location = new System.Drawing.Point(131, 396);
            this.gbxCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCurso.Name = "gbxCurso";
            this.gbxCurso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCurso.Size = new System.Drawing.Size(401, 271);
            this.gbxCurso.TabIndex = 38;
            this.gbxCurso.TabStop = false;
            this.gbxCurso.Text = "Datos del Curso";
            // 
            // btnAddAsignatura
            // 
            this.btnAddAsignatura.Location = new System.Drawing.Point(347, 142);
            this.btnAddAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAsignatura.Name = "btnAddAsignatura";
            this.btnAddAsignatura.Size = new System.Drawing.Size(23, 21);
            this.btnAddAsignatura.TabIndex = 21;
            this.btnAddAsignatura.Text = "+";
            this.btnAddAsignatura.UseVisualStyleBackColor = true;
            this.btnAddAsignatura.Click += new System.EventHandler(this.btnAddAsignatura_Click);
            // 
            // btnAddGradoAcademico
            // 
            this.btnAddGradoAcademico.Location = new System.Drawing.Point(347, 110);
            this.btnAddGradoAcademico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGradoAcademico.Name = "btnAddGradoAcademico";
            this.btnAddGradoAcademico.Size = new System.Drawing.Size(23, 21);
            this.btnAddGradoAcademico.TabIndex = 20;
            this.btnAddGradoAcademico.Text = "+";
            this.btnAddGradoAcademico.UseVisualStyleBackColor = true;
            this.btnAddGradoAcademico.Click += new System.EventHandler(this.btnAddGradoAcademico_Click);
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Location = new System.Drawing.Point(145, 140);
            this.cbAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(195, 24);
            this.cbAsignatura.TabIndex = 19;
            // 
            // cbGradoAcademico
            // 
            this.cbGradoAcademico.FormattingEnabled = true;
            this.cbGradoAcademico.Location = new System.Drawing.Point(145, 108);
            this.cbGradoAcademico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGradoAcademico.Name = "cbGradoAcademico";
            this.cbGradoAcademico.Size = new System.Drawing.Size(195, 24);
            this.cbGradoAcademico.TabIndex = 18;
            // 
            // lblAreaAcademica
            // 
            this.lblAreaAcademica.AutoSize = true;
            this.lblAreaAcademica.Location = new System.Drawing.Point(15, 151);
            this.lblAreaAcademica.Name = "lblAreaAcademica";
            this.lblAreaAcademica.Size = new System.Drawing.Size(111, 16);
            this.lblAreaAcademica.TabIndex = 16;
            this.lblAreaAcademica.Text = "Area Academica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grado Academico:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(19, 193);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(132, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Curso";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 229);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(147, 229);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(260, 229);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre Curso:";
            // 
            // lblidCurso
            // 
            this.lblidCurso.AutoSize = true;
            this.lblidCurso.Location = new System.Drawing.Point(15, 31);
            this.lblidCurso.Name = "lblidCurso";
            this.lblidCurso.Size = new System.Drawing.Size(23, 16);
            this.lblidCurso.TabIndex = 7;
            this.lblidCurso.Text = "ID:";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIDCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCurso.Location = new System.Drawing.Point(145, 27);
            this.txtIDCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(73, 22);
            this.txtIDCurso.TabIndex = 1;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCurso.Location = new System.Drawing.Point(145, 68);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(195, 22);
            this.txtNombreCurso.TabIndex = 0;
            // 
            // lblSearchDniDocente
            // 
            this.lblSearchDniDocente.Location = new System.Drawing.Point(23, 31);
            this.lblSearchDniDocente.Name = "lblSearchDniDocente";
            this.lblSearchDniDocente.Size = new System.Drawing.Size(100, 23);
            this.lblSearchDniDocente.TabIndex = 50;
            this.lblSearchDniDocente.Text = "Ingrese el dni:";
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Location = new System.Drawing.Point(697, 50);
            this.dgvDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.ReadOnly = true;
            this.dgvDocente.RowHeadersWidth = 30;
            this.dgvDocente.RowTemplate.Height = 37;
            this.dgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocente.Size = new System.Drawing.Size(557, 306);
            this.dgvDocente.TabIndex = 41;
            this.dgvDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocente_CellContentClick);
            // 
            // gbDatosDocente
            // 
            this.gbDatosDocente.Controls.Add(this.txtBApellidoMDocente);
            this.gbDatosDocente.Controls.Add(this.txtBDniDocente);
            this.gbDatosDocente.Controls.Add(this.txtBApellidoPDocente);
            this.gbDatosDocente.Controls.Add(this.txtBNameDocente);
            this.gbDatosDocente.Controls.Add(this.label13);
            this.gbDatosDocente.Controls.Add(this.label12);
            this.gbDatosDocente.Controls.Add(this.label11);
            this.gbDatosDocente.Controls.Add(this.label10);
            this.gbDatosDocente.Controls.Add(this.btnSearchDocente);
            this.gbDatosDocente.Controls.Add(this.btnAddDocente);
            this.gbDatosDocente.Controls.Add(this.txtBSearchDocente);
            this.gbDatosDocente.Controls.Add(this.lblSearchDniDocente);
            this.gbDatosDocente.Location = new System.Drawing.Point(697, 396);
            this.gbDatosDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosDocente.Name = "gbDatosDocente";
            this.gbDatosDocente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosDocente.Size = new System.Drawing.Size(556, 257);
            this.gbDatosDocente.TabIndex = 42;
            this.gbDatosDocente.TabStop = false;
            this.gbDatosDocente.Text = "Datos del Docente";
            // 
            // txtBApellidoMDocente
            // 
            this.txtBApellidoMDocente.Location = new System.Drawing.Point(255, 159);
            this.txtBApellidoMDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBApellidoMDocente.Name = "txtBApellidoMDocente";
            this.txtBApellidoMDocente.ReadOnly = true;
            this.txtBApellidoMDocente.Size = new System.Drawing.Size(183, 22);
            this.txtBApellidoMDocente.TabIndex = 46;
            // 
            // txtBDniDocente
            // 
            this.txtBDniDocente.Location = new System.Drawing.Point(255, 196);
            this.txtBDniDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBDniDocente.Name = "txtBDniDocente";
            this.txtBDniDocente.ReadOnly = true;
            this.txtBDniDocente.Size = new System.Drawing.Size(183, 22);
            this.txtBDniDocente.TabIndex = 45;
            // 
            // txtBApellidoPDocente
            // 
            this.txtBApellidoPDocente.Location = new System.Drawing.Point(255, 114);
            this.txtBApellidoPDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBApellidoPDocente.Name = "txtBApellidoPDocente";
            this.txtBApellidoPDocente.ReadOnly = true;
            this.txtBApellidoPDocente.Size = new System.Drawing.Size(183, 22);
            this.txtBApellidoPDocente.TabIndex = 44;
            // 
            // txtBNameDocente
            // 
            this.txtBNameDocente.Location = new System.Drawing.Point(255, 71);
            this.txtBNameDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBNameDocente.Name = "txtBNameDocente";
            this.txtBNameDocente.ReadOnly = true;
            this.txtBNameDocente.Size = new System.Drawing.Size(183, 22);
            this.txtBNameDocente.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(133, 162);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Apellido Materno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(133, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "DNI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(133, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Apellido Paterno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(133, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Nombre:";
            // 
            // btnSearchDocente
            // 
            this.btnSearchDocente.Location = new System.Drawing.Point(376, 28);
            this.btnSearchDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDocente.Name = "btnSearchDocente";
            this.btnSearchDocente.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDocente.TabIndex = 47;
            this.btnSearchDocente.Text = "Buscar";
            this.btnSearchDocente.Click += new System.EventHandler(this.btnSearchDocente_Click);
            // 
            // btnAddDocente
            // 
            this.btnAddDocente.Location = new System.Drawing.Point(456, 27);
            this.btnAddDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDocente.Name = "btnAddDocente";
            this.btnAddDocente.Size = new System.Drawing.Size(25, 23);
            this.btnAddDocente.TabIndex = 48;
            this.btnAddDocente.Text = "+";
            this.btnAddDocente.Click += new System.EventHandler(this.btnAddDocente_Click);
            // 
            // txtBSearchDocente
            // 
            this.txtBSearchDocente.Location = new System.Drawing.Point(151, 27);
            this.txtBSearchDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBSearchDocente.Name = "txtBSearchDocente";
            this.txtBSearchDocente.Size = new System.Drawing.Size(219, 22);
            this.txtBSearchDocente.TabIndex = 49;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 681);
            this.Controls.Add(this.gbDatosDocente);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.gbxCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.gbxCurso.ResumeLayout(false);
            this.gbxCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.gbDatosDocente.ResumeLayout(false);
            this.gbDatosDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.GroupBox gbxCurso;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label lblSearchDniDocente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidCurso;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.ComboBox cbGradoAcademico;
        private System.Windows.Forms.Label lblAreaAcademica;
        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.GroupBox gbDatosDocente;
        private System.Windows.Forms.TextBox txtBSearchDocente;
        private System.Windows.Forms.Button btnAddAsignatura;
        private System.Windows.Forms.Button btnAddGradoAcademico;
        private System.Windows.Forms.Button btnSearchDocente;
        private System.Windows.Forms.Button btnAddDocente;
        private System.Windows.Forms.TextBox txtBApellidoMDocente;
        private System.Windows.Forms.TextBox txtBDniDocente;
        private System.Windows.Forms.TextBox txtBApellidoPDocente;
        private System.Windows.Forms.TextBox txtBNameDocente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}