namespace CapaPresentacion
{
    partial class frmTipoPlanPago
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
            this.dgvTipoPlanPago = new System.Windows.Forms.DataGridView();
            this.gbxTipoPlanPago = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreTipoPlanPago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPlanPago)).BeginInit();
            this.gbxTipoPlanPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 56);
            this.label1.TabIndex = 89;
            this.label1.Text = "Tipo de Plan de Pago";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1642, 502);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 95;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1642, 362);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 94;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1642, 212);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 93;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1642, 645);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 91;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvTipoPlanPago
            // 
            this.dgvTipoPlanPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPlanPago.Location = new System.Drawing.Point(105, 178);
            this.dgvTipoPlanPago.Name = "dgvTipoPlanPago";
            this.dgvTipoPlanPago.ReadOnly = true;
            this.dgvTipoPlanPago.RowHeadersWidth = 92;
            this.dgvTipoPlanPago.RowTemplate.Height = 37;
            this.dgvTipoPlanPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoPlanPago.Size = new System.Drawing.Size(1432, 601);
            this.dgvTipoPlanPago.TabIndex = 90;
            // 
            // gbxTipoPlanPago
            // 
            this.gbxTipoPlanPago.Controls.Add(this.cbxEstado);
            this.gbxTipoPlanPago.Controls.Add(this.btnAgregar);
            this.gbxTipoPlanPago.Controls.Add(this.btnModificar);
            this.gbxTipoPlanPago.Controls.Add(this.btnCancelar);
            this.gbxTipoPlanPago.Controls.Add(this.label2);
            this.gbxTipoPlanPago.Controls.Add(this.txtNombreTipoPlanPago);
            this.gbxTipoPlanPago.Location = new System.Drawing.Point(307, 842);
            this.gbxTipoPlanPago.Name = "gbxTipoPlanPago";
            this.gbxTipoPlanPago.Size = new System.Drawing.Size(1176, 415);
            this.gbxTipoPlanPago.TabIndex = 92;
            this.gbxTipoPlanPago.TabStop = false;
            this.gbxTipoPlanPago.Text = "Datos del Tipo de Plan de Pago";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 116);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(293, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado Tipo Plan Pago";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(146, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 92);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(484, 217);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 92);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(833, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 92);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreTipoPlanPago
            // 
            this.txtNombreTipoPlanPago.Location = new System.Drawing.Point(175, 54);
            this.txtNombreTipoPlanPago.Name = "txtNombreTipoPlanPago";
            this.txtNombreTipoPlanPago.Size = new System.Drawing.Size(320, 35);
            this.txtNombreTipoPlanPago.TabIndex = 1;
            // 
            // frmTipoPlanPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvTipoPlanPago);
            this.Controls.Add(this.gbxTipoPlanPago);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoPlanPago";
            this.Text = "frmTipoPlanPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPlanPago)).EndInit();
            this.gbxTipoPlanPago.ResumeLayout(false);
            this.gbxTipoPlanPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTipoPlanPago;
        private System.Windows.Forms.GroupBox gbxTipoPlanPago;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTipoPlanPago;
    }
}