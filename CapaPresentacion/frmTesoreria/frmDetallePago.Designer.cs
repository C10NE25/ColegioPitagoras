namespace CapaPresentacion.frmTesoreria
{
    partial class frmDetallePago
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
            this.dgvDetPago = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.txtIdDetallePago = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoCargo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetPago)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetPago
            // 
            this.dgvDetPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetPago.Location = new System.Drawing.Point(13, 32);
            this.dgvDetPago.Name = "dgvDetPago";
            this.dgvDetPago.RowHeadersWidth = 51;
            this.dgvDetPago.RowTemplate.Height = 24;
            this.dgvDetPago.Size = new System.Drawing.Size(695, 200);
            this.dgvDetPago.TabIndex = 0;
            this.dgvDetPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetPago_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(774, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 42);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(774, 110);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(109, 42);
            this.btnDeshabilitar.TabIndex = 2;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxEstado);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.cbTipoCargo);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.cbPago);
            this.gbxDatos.Controls.Add(this.txtMonto);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.btnAgregar);
            this.gbxDatos.Controls.Add(this.txtIdDetallePago);
            this.gbxDatos.Controls.Add(this.label);
            this.gbxDatos.Location = new System.Drawing.Point(13, 264);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(870, 218);
            this.gbxDatos.TabIndex = 3;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 16);
            this.label.TabIndex = 0;
            this.label.Text = "ID";
            // 
            // txtIdDetallePago
            // 
            this.txtIdDetallePago.Location = new System.Drawing.Point(113, 60);
            this.txtIdDetallePago.Name = "txtIdDetallePago";
            this.txtIdDetallePago.Size = new System.Drawing.Size(100, 22);
            this.txtIdDetallePago.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(692, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(113, 116);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Location = new System.Drawing.Point(398, 57);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(187, 24);
            this.cbPago.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Cargo";
            // 
            // cbTipoCargo
            // 
            this.cbTipoCargo.FormattingEnabled = true;
            this.cbTipoCargo.Location = new System.Drawing.Point(401, 108);
            this.cbTipoCargo.Name = "cbTipoCargo";
            this.cbTipoCargo.Size = new System.Drawing.Size(187, 24);
            this.cbTipoCargo.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(692, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(323, 165);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(71, 20);
            this.cbxEstado.TabIndex = 10;
            this.cbxEstado.Text = "estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // frmDetallePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 554);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDetPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetallePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetallePago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetPago)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetPago;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdDetallePago;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbTipoCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnCancelar;
    }
}