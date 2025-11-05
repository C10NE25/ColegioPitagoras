namespace CapaPresentacion
{
    partial class frmBoletaPago
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
            this.dgvBoletaPago = new System.Windows.Forms.DataGridView();
            this.gbxBoletaPago = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.cmbModalidadPago = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtIDPlangPago = new System.Windows.Forms.TextBox();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstudianteBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaPago)).BeginInit();
            this.gbxBoletaPago.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 56);
            this.label1.TabIndex = 101;
            this.label1.Text = "Boleta de Pago";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1625, 481);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 107;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1625, 341);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 106;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1625, 191);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 105;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1625, 624);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 103;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvBoletaPago
            // 
            this.dgvBoletaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletaPago.Location = new System.Drawing.Point(90, 256);
            this.dgvBoletaPago.Name = "dgvBoletaPago";
            this.dgvBoletaPago.ReadOnly = true;
            this.dgvBoletaPago.RowHeadersWidth = 92;
            this.dgvBoletaPago.RowTemplate.Height = 37;
            this.dgvBoletaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletaPago.Size = new System.Drawing.Size(1432, 601);
            this.dgvBoletaPago.TabIndex = 102;
            // 
            // gbxBoletaPago
            // 
            this.gbxBoletaPago.Controls.Add(this.label3);
            this.gbxBoletaPago.Controls.Add(this.dtpFechaPago);
            this.gbxBoletaPago.Controls.Add(this.cmbModalidadPago);
            this.gbxBoletaPago.Controls.Add(this.btnAgregar);
            this.gbxBoletaPago.Controls.Add(this.btnModificar);
            this.gbxBoletaPago.Controls.Add(this.btnCancelar);
            this.gbxBoletaPago.Controls.Add(this.label5);
            this.gbxBoletaPago.Controls.Add(this.label4);
            this.gbxBoletaPago.Controls.Add(this.label2);
            this.gbxBoletaPago.Controls.Add(this.txtNombreDocente);
            this.gbxBoletaPago.Controls.Add(this.txtIDPlangPago);
            this.gbxBoletaPago.Location = new System.Drawing.Point(294, 889);
            this.gbxBoletaPago.Name = "gbxBoletaPago";
            this.gbxBoletaPago.Size = new System.Drawing.Size(1103, 435);
            this.gbxBoletaPago.TabIndex = 104;
            this.gbxBoletaPago.TabStop = false;
            this.gbxBoletaPago.Text = "Datos del Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha de Pago:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(265, 262);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(452, 35);
            this.dtpFechaPago.TabIndex = 15;
            // 
            // cmbModalidadPago
            // 
            this.cmbModalidadPago.FormattingEnabled = true;
            this.cmbModalidadPago.Location = new System.Drawing.Point(265, 174);
            this.cmbModalidadPago.Name = "cmbModalidadPago";
            this.cmbModalidadPago.Size = new System.Drawing.Size(310, 37);
            this.cmbModalidadPago.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(823, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(823, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(823, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modalidad de Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto Pagado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Plan de Pago:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(237, 111);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(338, 35);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // txtIDPlangPago
            // 
            this.txtIDPlangPago.Location = new System.Drawing.Point(231, 54);
            this.txtIDPlangPago.Name = "txtIDPlangPago";
            this.txtIDPlangPago.Size = new System.Drawing.Size(139, 35);
            this.txtIDPlangPago.TabIndex = 1;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.txtEstudianteBuscar);
            this.gbxBusqueda.Controls.Add(this.btnBuscar);
            this.gbxBusqueda.Controls.Add(this.label9);
            this.gbxBusqueda.Location = new System.Drawing.Point(235, 139);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(1221, 93);
            this.gbxBusqueda.TabIndex = 108;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Busqueda de Pagos por Estudiante";
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
            this.label9.Location = new System.Drawing.Point(113, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 55;
            this.label9.Text = "Estudiante:";
            // 
            // txtEstudianteBuscar
            // 
            this.txtEstudianteBuscar.Location = new System.Drawing.Point(274, 39);
            this.txtEstudianteBuscar.Name = "txtEstudianteBuscar";
            this.txtEstudianteBuscar.Size = new System.Drawing.Size(338, 35);
            this.txtEstudianteBuscar.TabIndex = 58;
            // 
            // frmBoletaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 1374);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvBoletaPago);
            this.Controls.Add(this.gbxBoletaPago);
            this.Controls.Add(this.label1);
            this.Name = "frmBoletaPago";
            this.Text = "frmBoletaPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletaPago)).EndInit();
            this.gbxBoletaPago.ResumeLayout(false);
            this.gbxBoletaPago.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvBoletaPago;
        private System.Windows.Forms.GroupBox gbxBoletaPago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtIDPlangPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.ComboBox cmbModalidadPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.TextBox txtEstudianteBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
    }
}