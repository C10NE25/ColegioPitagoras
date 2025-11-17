namespace CapaPresentacion.frmTesoreria
{
    partial class frmModalidadPago
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
            this.dgvModalidadPago = new System.Windows.Forms.DataGridView();
            this.gbxModalidadPago = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdModalidadPago = new System.Windows.Forms.TextBox();
            this.txtTipoModalidadPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadPago)).BeginInit();
            this.gbxModalidadPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModalidadPago
            // 
            this.dgvModalidadPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidadPago.Location = new System.Drawing.Point(18, 46);
            this.dgvModalidadPago.Margin = new System.Windows.Forms.Padding(1);
            this.dgvModalidadPago.Name = "dgvModalidadPago";
            this.dgvModalidadPago.ReadOnly = true;
            this.dgvModalidadPago.RowHeadersWidth = 92;
            this.dgvModalidadPago.RowTemplate.Height = 37;
            this.dgvModalidadPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidadPago.Size = new System.Drawing.Size(439, 372);
            this.dgvModalidadPago.TabIndex = 58;
            this.dgvModalidadPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModalidadPago_CellClick);
            // 
            // gbxModalidadPago
            // 
            this.gbxModalidadPago.Controls.Add(this.btnCancelar);
            this.gbxModalidadPago.Controls.Add(this.btnAgregar);
            this.gbxModalidadPago.Controls.Add(this.btnModificar);
            this.gbxModalidadPago.Controls.Add(this.cbxEstado);
            this.gbxModalidadPago.Controls.Add(this.label3);
            this.gbxModalidadPago.Controls.Add(this.label2);
            this.gbxModalidadPago.Controls.Add(this.txtIdModalidadPago);
            this.gbxModalidadPago.Controls.Add(this.txtTipoModalidadPago);
            this.gbxModalidadPago.Location = new System.Drawing.Point(468, 46);
            this.gbxModalidadPago.Margin = new System.Windows.Forms.Padding(1);
            this.gbxModalidadPago.Name = "gbxModalidadPago";
            this.gbxModalidadPago.Padding = new System.Windows.Forms.Padding(1);
            this.gbxModalidadPago.Size = new System.Drawing.Size(351, 163);
            this.gbxModalidadPago.TabIndex = 59;
            this.gbxModalidadPago.TabStop = false;
            this.gbxModalidadPago.Text = "Datos de la Modalidad de Pago";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 119);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(36, 119);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(137, 119);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(15, 87);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(180, 17);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado de la Modalidad de Pago";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre Modalidad de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtIdModalidadPago
            // 
            this.txtIdModalidadPago.Location = new System.Drawing.Point(177, 23);
            this.txtIdModalidadPago.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdModalidadPago.Name = "txtIdModalidadPago";
            this.txtIdModalidadPago.Size = new System.Drawing.Size(57, 20);
            this.txtIdModalidadPago.TabIndex = 1;
            // 
            // txtTipoModalidadPago
            // 
            this.txtTipoModalidadPago.Location = new System.Drawing.Point(177, 58);
            this.txtTipoModalidadPago.Margin = new System.Windows.Forms.Padding(1);
            this.txtTipoModalidadPago.Name = "txtTipoModalidadPago";
            this.txtTipoModalidadPago.Size = new System.Drawing.Size(147, 20);
            this.txtTipoModalidadPago.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Modalidad Pago";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(359, 423);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 27);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(258, 423);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 27);
            this.btnNuevo.TabIndex = 61;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmModalidadPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.dgvModalidadPago);
            this.Controls.Add(this.gbxModalidadPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModalidadPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModalidadPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadPago)).EndInit();
            this.gbxModalidadPago.ResumeLayout(false);
            this.gbxModalidadPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModalidadPago;
        private System.Windows.Forms.GroupBox gbxModalidadPago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdModalidadPago;
        private System.Windows.Forms.TextBox txtTipoModalidadPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
    }
}