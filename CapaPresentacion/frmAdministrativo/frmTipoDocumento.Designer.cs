namespace CapaPresentacion
{
    partial class frmTipoDocumento
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
            this.dgvTipoDocumento = new System.Windows.Forms.DataGridView();
            this.gbxTipoDocumento = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreTipoDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).BeginInit();
            this.gbxTipoDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 56);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo de Documentos";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(1635, 510);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(230, 95);
            this.btnDeshabilitar.TabIndex = 101;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1635, 370);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 92);
            this.btnEditar.TabIndex = 100;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1635, 220);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(230, 92);
            this.btnNuevo.TabIndex = 99;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1635, 653);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 95);
            this.btnCerrar.TabIndex = 97;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvTipoDocumento
            // 
            this.dgvTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDocumento.Location = new System.Drawing.Point(98, 186);
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.ReadOnly = true;
            this.dgvTipoDocumento.RowHeadersWidth = 92;
            this.dgvTipoDocumento.RowTemplate.Height = 37;
            this.dgvTipoDocumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoDocumento.Size = new System.Drawing.Size(1432, 601);
            this.dgvTipoDocumento.TabIndex = 96;
            // 
            // gbxTipoDocumento
            // 
            this.gbxTipoDocumento.Controls.Add(this.cbxEstado);
            this.gbxTipoDocumento.Controls.Add(this.btnAgregar);
            this.gbxTipoDocumento.Controls.Add(this.btnModificar);
            this.gbxTipoDocumento.Controls.Add(this.btnCancelar);
            this.gbxTipoDocumento.Controls.Add(this.label2);
            this.gbxTipoDocumento.Controls.Add(this.txtNombreTipoDocumento);
            this.gbxTipoDocumento.Location = new System.Drawing.Point(300, 850);
            this.gbxTipoDocumento.Name = "gbxTipoDocumento";
            this.gbxTipoDocumento.Size = new System.Drawing.Size(1176, 415);
            this.gbxTipoDocumento.TabIndex = 98;
            this.gbxTipoDocumento.TabStop = false;
            this.gbxTipoDocumento.Text = "Datos del Tipo de Documento";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(32, 116);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(379, 33);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado del Tipo de Documento";
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
            // txtNombreTipoDocumento
            // 
            this.txtNombreTipoDocumento.Location = new System.Drawing.Point(175, 54);
            this.txtNombreTipoDocumento.Name = "txtNombreTipoDocumento";
            this.txtNombreTipoDocumento.Size = new System.Drawing.Size(320, 35);
            this.txtNombreTipoDocumento.TabIndex = 1;
            // 
            // frmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1959, 1374);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvTipoDocumento);
            this.Controls.Add(this.gbxTipoDocumento);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoDocumento";
            this.Text = "frmTipoDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).EndInit();
            this.gbxTipoDocumento.ResumeLayout(false);
            this.gbxTipoDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTipoDocumento;
        private System.Windows.Forms.GroupBox gbxTipoDocumento;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTipoDocumento;
    }
}