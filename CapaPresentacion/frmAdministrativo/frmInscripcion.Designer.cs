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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.gbxInscripcion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdInscripcion = new System.Windows.Forms.TextBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.gbSearchEstudiante = new System.Windows.Forms.GroupBox();
            this.txtBApellidoMEstudiante = new System.Windows.Forms.TextBox();
            this.txtBDniEstudiante = new System.Windows.Forms.TextBox();
            this.txtBApellidoPEstudiante = new System.Windows.Forms.TextBox();
            this.txtBNameEstudiante = new System.Windows.Forms.TextBox();
            this.lblApellidoMEstudiante = new System.Windows.Forms.Label();
            this.lbldniEstudiante = new System.Windows.Forms.Label();
            this.lblApellidoPEstudiante = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.btnAddEstudiante = new System.Windows.Forms.Button();
            this.btnSearchEstudiante = new System.Windows.Forms.Button();
            this.lblSearchDniEstudiante = new System.Windows.Forms.Label();
            this.txtBSearchEstudiante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.gbxInscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.gbSearchEstudiante.SuspendLayout();
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
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(374, 308);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(70, 25);
            this.btnDeshabilitar.TabIndex = 131;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(300, 308);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 25);
            this.btnNuevo.TabIndex = 129;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(13, 34);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 30;
            this.dgvInscripcion.RowTemplate.Height = 37;
            this.dgvInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcion.Size = new System.Drawing.Size(430, 270);
            this.dgvInscripcion.TabIndex = 126;
            this.dgvInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellContentClick);
            // 
            // gbxInscripcion
            // 
            this.gbxInscripcion.Controls.Add(this.label3);
            this.gbxInscripcion.Controls.Add(this.dtpFechaInscripcion);
            this.gbxInscripcion.Controls.Add(this.cbxEstado);
            this.gbxInscripcion.Controls.Add(this.btnAgregar);
            this.gbxInscripcion.Controls.Add(this.btnModificar);
            this.gbxInscripcion.Controls.Add(this.btnCancelar);
            this.gbxInscripcion.Controls.Add(this.label2);
            this.gbxInscripcion.Controls.Add(this.txtIdInscripcion);
            this.gbxInscripcion.Location = new System.Drawing.Point(34, 337);
            this.gbxInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInscripcion.Name = "gbxInscripcion";
            this.gbxInscripcion.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInscripcion.Size = new System.Drawing.Size(389, 195);
            this.gbxInscripcion.TabIndex = 128;
            this.gbxInscripcion.TabStop = false;
            this.gbxInscripcion.Text = "Datos de la Inscripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Enabled = false;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(88, 63);
            this.dtpFechaInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(191, 20);
            this.dtpFechaInscripcion.TabIndex = 22;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(22, 98);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(139, 17);
            this.cbxEstado.TabIndex = 19;
            this.cbxEstado.Text = "Estado de la Inscripcion";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(68, 143);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(148, 143);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(228, 143);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdInscripcion
            // 
            this.txtIdInscripcion.Enabled = false;
            this.txtIdInscripcion.Location = new System.Drawing.Point(88, 32);
            this.txtIdInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdInscripcion.Name = "txtIdInscripcion";
            this.txtIdInscripcion.Size = new System.Drawing.Size(73, 20);
            this.txtIdInscripcion.TabIndex = 1;
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(461, 34);
            this.dgvEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersWidth = 30;
            this.dgvEstudiante.RowTemplate.Height = 37;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(575, 270);
            this.dgvEstudiante.TabIndex = 132;
            this.dgvEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellContentClick);
            // 
            // gbSearchEstudiante
            // 
            this.gbSearchEstudiante.Controls.Add(this.txtBApellidoMEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.txtBDniEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.txtBApellidoPEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.txtBNameEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.lblApellidoMEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.lbldniEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.lblApellidoPEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.lblNombreEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.btnAddEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.btnSearchEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.lblSearchDniEstudiante);
            this.gbSearchEstudiante.Controls.Add(this.txtBSearchEstudiante);
            this.gbSearchEstudiante.Location = new System.Drawing.Point(557, 337);
            this.gbSearchEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearchEstudiante.Name = "gbSearchEstudiante";
            this.gbSearchEstudiante.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearchEstudiante.Size = new System.Drawing.Size(389, 195);
            this.gbSearchEstudiante.TabIndex = 129;
            this.gbSearchEstudiante.TabStop = false;
            this.gbSearchEstudiante.Text = "Datos del Estudiante";
            // 
            // txtBApellidoMEstudiante
            // 
            this.txtBApellidoMEstudiante.Location = new System.Drawing.Point(166, 130);
            this.txtBApellidoMEstudiante.Name = "txtBApellidoMEstudiante";
            this.txtBApellidoMEstudiante.ReadOnly = true;
            this.txtBApellidoMEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoMEstudiante.TabIndex = 142;
            // 
            // txtBDniEstudiante
            // 
            this.txtBDniEstudiante.Location = new System.Drawing.Point(166, 160);
            this.txtBDniEstudiante.Name = "txtBDniEstudiante";
            this.txtBDniEstudiante.ReadOnly = true;
            this.txtBDniEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBDniEstudiante.TabIndex = 141;
            // 
            // txtBApellidoPEstudiante
            // 
            this.txtBApellidoPEstudiante.Location = new System.Drawing.Point(166, 94);
            this.txtBApellidoPEstudiante.Name = "txtBApellidoPEstudiante";
            this.txtBApellidoPEstudiante.ReadOnly = true;
            this.txtBApellidoPEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoPEstudiante.TabIndex = 140;
            // 
            // txtBNameEstudiante
            // 
            this.txtBNameEstudiante.Location = new System.Drawing.Point(166, 59);
            this.txtBNameEstudiante.Name = "txtBNameEstudiante";
            this.txtBNameEstudiante.ReadOnly = true;
            this.txtBNameEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBNameEstudiante.TabIndex = 139;
            // 
            // lblApellidoMEstudiante
            // 
            this.lblApellidoMEstudiante.AutoSize = true;
            this.lblApellidoMEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoMEstudiante.Location = new System.Drawing.Point(75, 133);
            this.lblApellidoMEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoMEstudiante.Name = "lblApellidoMEstudiante";
            this.lblApellidoMEstudiante.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMEstudiante.TabIndex = 138;
            this.lblApellidoMEstudiante.Text = "Apellido Materno:";
            // 
            // lbldniEstudiante
            // 
            this.lbldniEstudiante.AutoSize = true;
            this.lbldniEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lbldniEstudiante.Location = new System.Drawing.Point(75, 167);
            this.lbldniEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldniEstudiante.Name = "lbldniEstudiante";
            this.lbldniEstudiante.Size = new System.Drawing.Size(29, 13);
            this.lbldniEstudiante.TabIndex = 137;
            this.lbldniEstudiante.Text = "DNI:";
            // 
            // lblApellidoPEstudiante
            // 
            this.lblApellidoPEstudiante.AutoSize = true;
            this.lblApellidoPEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoPEstudiante.Location = new System.Drawing.Point(75, 97);
            this.lblApellidoPEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoPEstudiante.Name = "lblApellidoPEstudiante";
            this.lblApellidoPEstudiante.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPEstudiante.TabIndex = 136;
            this.lblApellidoPEstudiante.Text = "Apellido Paterno:";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(75, 62);
            this.lblNombreEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEstudiante.TabIndex = 135;
            this.lblNombreEstudiante.Text = "Nombre:";
            // 
            // btnAddEstudiante
            // 
            this.btnAddEstudiante.Location = new System.Drawing.Point(345, 25);
            this.btnAddEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEstudiante.Name = "btnAddEstudiante";
            this.btnAddEstudiante.Size = new System.Drawing.Size(22, 22);
            this.btnAddEstudiante.TabIndex = 134;
            this.btnAddEstudiante.Text = "+";
            this.btnAddEstudiante.UseVisualStyleBackColor = true;
            this.btnAddEstudiante.Click += new System.EventHandler(this.btnAddEstudiante_Click);
            // 
            // btnSearchEstudiante
            // 
            this.btnSearchEstudiante.Location = new System.Drawing.Point(269, 25);
            this.btnSearchEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchEstudiante.Name = "btnSearchEstudiante";
            this.btnSearchEstudiante.Size = new System.Drawing.Size(70, 23);
            this.btnSearchEstudiante.TabIndex = 133;
            this.btnSearchEstudiante.Text = "Buscar";
            this.btnSearchEstudiante.UseVisualStyleBackColor = true;
            this.btnSearchEstudiante.Click += new System.EventHandler(this.btnSearchEstudiante_Click);
            // 
            // lblSearchDniEstudiante
            // 
            this.lblSearchDniEstudiante.AutoSize = true;
            this.lblSearchDniEstudiante.Location = new System.Drawing.Point(21, 30);
            this.lblSearchDniEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDniEstudiante.Name = "lblSearchDniEstudiante";
            this.lblSearchDniEstudiante.Size = new System.Drawing.Size(76, 13);
            this.lblSearchDniEstudiante.TabIndex = 7;
            this.lblSearchDniEstudiante.Text = "Ingrese el dni :";
            // 
            // txtBSearchEstudiante
            // 
            this.txtBSearchEstudiante.Location = new System.Drawing.Point(107, 27);
            this.txtBSearchEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.txtBSearchEstudiante.Name = "txtBSearchEstudiante";
            this.txtBSearchEstudiante.Size = new System.Drawing.Size(151, 20);
            this.txtBSearchEstudiante.TabIndex = 1;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 542);
            this.Controls.Add(this.gbSearchEstudiante);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvInscripcion);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.gbSearchEstudiante.ResumeLayout(false);
            this.gbSearchEstudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.GroupBox gbxInscripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdInscripcion;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.GroupBox gbSearchEstudiante;
        private System.Windows.Forms.Label lblSearchDniEstudiante;
        private System.Windows.Forms.TextBox txtBSearchEstudiante;
        private System.Windows.Forms.Button btnAddEstudiante;
        private System.Windows.Forms.Button btnSearchEstudiante;
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