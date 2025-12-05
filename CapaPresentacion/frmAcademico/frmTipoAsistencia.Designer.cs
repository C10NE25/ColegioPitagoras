namespace CapaPresentacion.frmAcademico
{
    partial class frmTipoAsistencia
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
            this.dgvTipoAsistencia = new System.Windows.Forms.DataGridView();
            this.gbxTipoAsistencia = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.txtBTipoAsistencia = new System.Windows.Forms.TextBox();
            this.txtBidTipoAsistencia = new System.Windows.Forms.TextBox();
            this.txtTipoAsistencia = new System.Windows.Forms.Label();
            this.txtIdTipoAsistencia = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAsistencia)).BeginInit();
            this.gbxTipoAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tipo Asistencia";
            // 
            // dgvTipoAsistencia
            // 
            this.dgvTipoAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoAsistencia.Location = new System.Drawing.Point(17, 49);
            this.dgvTipoAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTipoAsistencia.Name = "dgvTipoAsistencia";
            this.dgvTipoAsistencia.RowHeadersWidth = 30;
            this.dgvTipoAsistencia.RowTemplate.Height = 24;
            this.dgvTipoAsistencia.Size = new System.Drawing.Size(492, 409);
            this.dgvTipoAsistencia.TabIndex = 86;
            this.dgvTipoAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoAsistencia_CellClick);
            this.dgvTipoAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoAsistencia_CellContentClick);
            // 
            // gbxTipoAsistencia
            // 
            this.gbxTipoAsistencia.Controls.Add(this.btnAgregar);
            this.gbxTipoAsistencia.Controls.Add(this.btnModificar);
            this.gbxTipoAsistencia.Controls.Add(this.btnCancelar);
            this.gbxTipoAsistencia.Controls.Add(this.cbxEstado);
            this.gbxTipoAsistencia.Controls.Add(this.txtBTipoAsistencia);
            this.gbxTipoAsistencia.Controls.Add(this.txtBidTipoAsistencia);
            this.gbxTipoAsistencia.Controls.Add(this.txtTipoAsistencia);
            this.gbxTipoAsistencia.Controls.Add(this.txtIdTipoAsistencia);
            this.gbxTipoAsistencia.Location = new System.Drawing.Point(520, 55);
            this.gbxTipoAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTipoAsistencia.Name = "gbxTipoAsistencia";
            this.gbxTipoAsistencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTipoAsistencia.Size = new System.Drawing.Size(387, 225);
            this.gbxTipoAsistencia.TabIndex = 87;
            this.gbxTipoAsistencia.TabStop = false;
            this.gbxTipoAsistencia.Text = "Datos Tipo Asistencia";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(36, 172);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 36);
            this.btnAgregar.TabIndex = 140;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(147, 172);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 36);
            this.btnModificar.TabIndex = 141;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(257, 172);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 36);
            this.btnCancelar.TabIndex = 142;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(11, 126);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(187, 20);
            this.cbxEstado.TabIndex = 133;
            this.cbxEstado.Text = "Estado de Tipo Asistencia";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtBTipoAsistencia
            // 
            this.txtBTipoAsistencia.Location = new System.Drawing.Point(141, 74);
            this.txtBTipoAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBTipoAsistencia.Name = "txtBTipoAsistencia";
            this.txtBTipoAsistencia.Size = new System.Drawing.Size(141, 22);
            this.txtBTipoAsistencia.TabIndex = 3;
            // 
            // txtBidTipoAsistencia
            // 
            this.txtBidTipoAsistencia.Location = new System.Drawing.Point(141, 30);
            this.txtBidTipoAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBidTipoAsistencia.Name = "txtBidTipoAsistencia";
            this.txtBidTipoAsistencia.Size = new System.Drawing.Size(141, 22);
            this.txtBidTipoAsistencia.TabIndex = 2;
            // 
            // txtTipoAsistencia
            // 
            this.txtTipoAsistencia.AutoSize = true;
            this.txtTipoAsistencia.Location = new System.Drawing.Point(7, 78);
            this.txtTipoAsistencia.Name = "txtTipoAsistencia";
            this.txtTipoAsistencia.Size = new System.Drawing.Size(119, 16);
            this.txtTipoAsistencia.TabIndex = 1;
            this.txtTipoAsistencia.Text = "Tipo de Asistencia";
            // 
            // txtIdTipoAsistencia
            // 
            this.txtIdTipoAsistencia.AutoSize = true;
            this.txtIdTipoAsistencia.Location = new System.Drawing.Point(7, 32);
            this.txtIdTipoAsistencia.Name = "txtIdTipoAsistencia";
            this.txtIdTipoAsistencia.Size = new System.Drawing.Size(23, 16);
            this.txtIdTipoAsistencia.TabIndex = 0;
            this.txtIdTipoAsistencia.Text = "ID:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(408, 465);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 32);
            this.btnEditar.TabIndex = 145;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(313, 465);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 31);
            this.btnNuevo.TabIndex = 144;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmTipoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 503);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbxTipoAsistencia);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoAsistencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTipoAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAsistencia)).EndInit();
            this.gbxTipoAsistencia.ResumeLayout(false);
            this.gbxTipoAsistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoAsistencia;
        private System.Windows.Forms.GroupBox gbxTipoAsistencia;
        private System.Windows.Forms.TextBox txtBTipoAsistencia;
        private System.Windows.Forms.TextBox txtBidTipoAsistencia;
        private System.Windows.Forms.Label txtTipoAsistencia;
        private System.Windows.Forms.Label txtIdTipoAsistencia;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
    }
}