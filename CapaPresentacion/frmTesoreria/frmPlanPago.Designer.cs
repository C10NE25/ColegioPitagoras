namespace CapaPresentacion
{
    partial class frmPlanPago
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
            this.dgvPlanPago = new System.Windows.Forms.DataGridView();
            this.gbxPlanPago = new System.Windows.Forms.GroupBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDBoletaInscripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTipoPlanPago = new System.Windows.Forms.TextBox();
            this.txtIDBoletaMatricula = new System.Windows.Forms.TextBox();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoPlanPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).BeginInit();
            this.gbxPlanPago.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 56);
            this.label1.TabIndex = 95;
            this.label1.Text = "Plan de Pago";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1633, 494);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 101;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1633, 354);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 100;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1633, 204);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 99;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1633, 637);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 97;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvPlanPago
            // 
            this.dgvPlanPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanPago.Location = new System.Drawing.Point(96, 255);
            this.dgvPlanPago.Name = "dgvPlanPago";
            this.dgvPlanPago.ReadOnly = true;
            this.dgvPlanPago.RowHeadersWidth = 92;
            this.dgvPlanPago.RowTemplate.Height = 37;
            this.dgvPlanPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPago.Size = new System.Drawing.Size(1432, 601);
            this.dgvPlanPago.TabIndex = 96;
            // 
            // gbxPlanPago
            // 
            this.gbxPlanPago.Controls.Add(this.txtMontoTotal);
            this.gbxPlanPago.Controls.Add(this.label7);
            this.gbxPlanPago.Controls.Add(this.label6);
            this.gbxPlanPago.Controls.Add(this.textBox1);
            this.gbxPlanPago.Controls.Add(this.label5);
            this.gbxPlanPago.Controls.Add(this.txtIDBoletaInscripcion);
            this.gbxPlanPago.Controls.Add(this.label4);
            this.gbxPlanPago.Controls.Add(this.dtpFecha);
            this.gbxPlanPago.Controls.Add(this.cbxEstado);
            this.gbxPlanPago.Controls.Add(this.btnAgregar);
            this.gbxPlanPago.Controls.Add(this.btnModificar);
            this.gbxPlanPago.Controls.Add(this.btnCancelar);
            this.gbxPlanPago.Controls.Add(this.label3);
            this.gbxPlanPago.Controls.Add(this.label2);
            this.gbxPlanPago.Controls.Add(this.txtIDTipoPlanPago);
            this.gbxPlanPago.Controls.Add(this.txtIDBoletaMatricula);
            this.gbxPlanPago.Location = new System.Drawing.Point(122, 892);
            this.gbxPlanPago.Name = "gbxPlanPago";
            this.gbxPlanPago.Size = new System.Drawing.Size(1483, 435);
            this.gbxPlanPago.TabIndex = 98;
            this.gbxPlanPago.TabStop = false;
            this.gbxPlanPago.Text = "Datos del Plan de Pago";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(304, 308);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(182, 35);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Monto Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID de Matricula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 35);
            this.textBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID de Boleta Inscripcion";
            // 
            // txtIDBoletaInscripcion
            // 
            this.txtIDBoletaInscripcion.Location = new System.Drawing.Point(304, 186);
            this.txtIDBoletaInscripcion.Name = "txtIDBoletaInscripcion";
            this.txtIDBoletaInscripcion.Size = new System.Drawing.Size(139, 35);
            this.txtIDBoletaInscripcion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(689, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(460, 35);
            this.dtpFecha.TabIndex = 14;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(577, 116);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(311, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Plan de Pago";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(1203, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(1203, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1203, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de Boleta Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Tipo Plan de Pago:";
            // 
            // txtIDTipoPlanPago
            // 
            this.txtIDTipoPlanPago.Location = new System.Drawing.Point(304, 54);
            this.txtIDTipoPlanPago.Name = "txtIDTipoPlanPago";
            this.txtIDTipoPlanPago.Size = new System.Drawing.Size(139, 35);
            this.txtIDTipoPlanPago.TabIndex = 1;
            // 
            // txtIDBoletaMatricula
            // 
            this.txtIDBoletaMatricula.Location = new System.Drawing.Point(304, 127);
            this.txtIDBoletaMatricula.Name = "txtIDBoletaMatricula";
            this.txtIDBoletaMatricula.Size = new System.Drawing.Size(139, 35);
            this.txtIDBoletaMatricula.TabIndex = 0;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.cmbEstadoPlanPago);
            this.gbxBusqueda.Controls.Add(this.btnBuscar);
            this.gbxBusqueda.Controls.Add(this.label9);
            this.gbxBusqueda.Location = new System.Drawing.Point(258, 139);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(1221, 93);
            this.gbxBusqueda.TabIndex = 102;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Busqueda de Planes de Pago";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(964, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(224, 61);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 29);
            this.label9.TabIndex = 55;
            this.label9.Text = "Estado de Plan de Pago:";
            // 
            // cmbEstadoPlanPago
            // 
            this.cmbEstadoPlanPago.FormattingEnabled = true;
            this.cmbEstadoPlanPago.Location = new System.Drawing.Point(314, 45);
            this.cmbEstadoPlanPago.Name = "cmbEstadoPlanPago";
            this.cmbEstadoPlanPago.Size = new System.Drawing.Size(321, 37);
            this.cmbEstadoPlanPago.TabIndex = 58;
            // 
            // frmPlanPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1374);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvPlanPago);
            this.Controls.Add(this.gbxPlanPago);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanPago";
            this.Text = "frmPlanPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).EndInit();
            this.gbxPlanPago.ResumeLayout(false);
            this.gbxPlanPago.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPlanPago;
        private System.Windows.Forms.GroupBox gbxPlanPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDTipoPlanPago;
        private System.Windows.Forms.TextBox txtIDBoletaMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDBoletaInscripcion;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.ComboBox cmbEstadoPlanPago;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
    }
}