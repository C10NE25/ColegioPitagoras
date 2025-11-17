namespace CapaPresentacion
{
    partial class frmAsistencias
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
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.gbxAsistencias = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSearchEstudiantes = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBApellidoMEstudiante = new System.Windows.Forms.TextBox();
            this.txtBDniEstudiante = new System.Windows.Forms.TextBox();
            this.txtBApellidoPEstudiante = new System.Windows.Forms.TextBox();
            this.txtBNameEstudiante = new System.Windows.Forms.TextBox();
            this.lblApellidoMEstudiante = new System.Windows.Forms.Label();
            this.lbldniEstudiante = new System.Windows.Forms.Label();
            this.lblApellidoPEstudiante = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.gbxAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSearchEstudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Asistencias";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(427, 282);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 25);
            this.btnNuevo.TabIndex = 57;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(11, 37);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.RowHeadersWidth = 92;
            this.dgvAsistencia.RowTemplate.Height = 37;
            this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencia.Size = new System.Drawing.Size(498, 241);
            this.dgvAsistencia.TabIndex = 54;
            // 
            // gbxAsistencias
            // 
            this.gbxAsistencias.Controls.Add(this.comboBox1);
            this.gbxAsistencias.Controls.Add(this.label3);
            this.gbxAsistencias.Controls.Add(this.label4);
            this.gbxAsistencias.Controls.Add(this.dtpFecha);
            this.gbxAsistencias.Controls.Add(this.cbxEstado);
            this.gbxAsistencias.Controls.Add(this.btnAgregar);
            this.gbxAsistencias.Controls.Add(this.btnCancelar);
            this.gbxAsistencias.Location = new System.Drawing.Point(51, 321);
            this.gbxAsistencias.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAsistencias.Name = "gbxAsistencias";
            this.gbxAsistencias.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAsistencias.Size = new System.Drawing.Size(305, 164);
            this.gbxAsistencias.TabIndex = 56;
            this.gbxAsistencias.TabStop = false;
            this.gbxAsistencias.Text = "Asistencias de estudiantes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo Asistencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(93, 63);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(15, 97);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(68, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Presente";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(58, 128);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 22);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(158, 128);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 22);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(513, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 241);
            this.dataGridView1.TabIndex = 58;
            // 
            // gbSearchEstudiantes
            // 
            this.gbSearchEstudiantes.Controls.Add(this.button1);
            this.gbSearchEstudiantes.Controls.Add(this.btnBuscar);
            this.gbSearchEstudiantes.Controls.Add(this.textBox1);
            this.gbSearchEstudiantes.Controls.Add(this.txtBApellidoMEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.txtBDniEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.txtBApellidoPEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.txtBNameEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.lblApellidoMEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.lbldniEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.lblApellidoPEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.lblNombreEstudiante);
            this.gbSearchEstudiantes.Controls.Add(this.label7);
            this.gbSearchEstudiantes.Location = new System.Drawing.Point(551, 304);
            this.gbSearchEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearchEstudiantes.Name = "gbSearchEstudiantes";
            this.gbSearchEstudiantes.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearchEstudiantes.Size = new System.Drawing.Size(407, 195);
            this.gbSearchEstudiantes.TabIndex = 57;
            this.gbSearchEstudiantes.TabStop = false;
            this.gbSearchEstudiantes.Text = "Datos Estudiantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingrese el DNI:";
            // 
            // txtBApellidoMEstudiante
            // 
            this.txtBApellidoMEstudiante.Location = new System.Drawing.Point(144, 131);
            this.txtBApellidoMEstudiante.Name = "txtBApellidoMEstudiante";
            this.txtBApellidoMEstudiante.ReadOnly = true;
            this.txtBApellidoMEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoMEstudiante.TabIndex = 46;
            // 
            // txtBDniEstudiante
            // 
            this.txtBDniEstudiante.Location = new System.Drawing.Point(144, 161);
            this.txtBDniEstudiante.Name = "txtBDniEstudiante";
            this.txtBDniEstudiante.ReadOnly = true;
            this.txtBDniEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBDniEstudiante.TabIndex = 45;
            // 
            // txtBApellidoPEstudiante
            // 
            this.txtBApellidoPEstudiante.Location = new System.Drawing.Point(144, 95);
            this.txtBApellidoPEstudiante.Name = "txtBApellidoPEstudiante";
            this.txtBApellidoPEstudiante.ReadOnly = true;
            this.txtBApellidoPEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBApellidoPEstudiante.TabIndex = 44;
            // 
            // txtBNameEstudiante
            // 
            this.txtBNameEstudiante.Location = new System.Drawing.Point(144, 60);
            this.txtBNameEstudiante.Name = "txtBNameEstudiante";
            this.txtBNameEstudiante.ReadOnly = true;
            this.txtBNameEstudiante.Size = new System.Drawing.Size(138, 20);
            this.txtBNameEstudiante.TabIndex = 43;
            // 
            // lblApellidoMEstudiante
            // 
            this.lblApellidoMEstudiante.AutoSize = true;
            this.lblApellidoMEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoMEstudiante.Location = new System.Drawing.Point(53, 134);
            this.lblApellidoMEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoMEstudiante.Name = "lblApellidoMEstudiante";
            this.lblApellidoMEstudiante.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMEstudiante.TabIndex = 42;
            this.lblApellidoMEstudiante.Text = "Apellido Materno:";
            // 
            // lbldniEstudiante
            // 
            this.lbldniEstudiante.AutoSize = true;
            this.lbldniEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lbldniEstudiante.Location = new System.Drawing.Point(53, 168);
            this.lbldniEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldniEstudiante.Name = "lbldniEstudiante";
            this.lbldniEstudiante.Size = new System.Drawing.Size(29, 13);
            this.lbldniEstudiante.TabIndex = 41;
            this.lbldniEstudiante.Text = "DNI:";
            // 
            // lblApellidoPEstudiante
            // 
            this.lblApellidoPEstudiante.AutoSize = true;
            this.lblApellidoPEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblApellidoPEstudiante.Location = new System.Drawing.Point(53, 98);
            this.lblApellidoPEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblApellidoPEstudiante.Name = "lblApellidoPEstudiante";
            this.lblApellidoPEstudiante.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPEstudiante.TabIndex = 40;
            this.lblApellidoPEstudiante.Text = "Apellido Paterno:";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.Gray;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(53, 63);
            this.lblNombreEstudiante.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEstudiante.TabIndex = 39;
            this.lblNombreEstudiante.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 47;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(296, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 22);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(367, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 48;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 527);
            this.Controls.Add(this.gbSearchEstudiantes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.gbxAsistencias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAsistencias";
            this.Text = "frmAsistencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.gbxAsistencias.ResumeLayout(false);
            this.gbxAsistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSearchEstudiantes.ResumeLayout(false);
            this.gbSearchEstudiantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.GroupBox gbxAsistencias;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbSearchEstudiantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBApellidoMEstudiante;
        private System.Windows.Forms.TextBox txtBDniEstudiante;
        private System.Windows.Forms.TextBox txtBApellidoPEstudiante;
        private System.Windows.Forms.TextBox txtBNameEstudiante;
        private System.Windows.Forms.Label lblApellidoMEstudiante;
        private System.Windows.Forms.Label lbldniEstudiante;
        private System.Windows.Forms.Label lblApellidoPEstudiante;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Button button1;
    }
}