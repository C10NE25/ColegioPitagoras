namespace CapaPresentacion.frmAcademico
{
    partial class frmTipoParentesco
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
            this.dgvParenteco = new System.Windows.Forms.DataGridView();
            this.gbxParentesco = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtBtipoParentesco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBIdParentesco = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblidDocente = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitleTipoParentesco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParenteco)).BeginInit();
            this.gbxParentesco.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParenteco
            // 
            this.dgvParenteco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParenteco.Location = new System.Drawing.Point(10, 37);
            this.dgvParenteco.Name = "dgvParenteco";
            this.dgvParenteco.RowHeadersWidth = 51;
            this.dgvParenteco.Size = new System.Drawing.Size(343, 368);
            this.dgvParenteco.TabIndex = 19;
            this.dgvParenteco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParenteco_CellClick);
            // 
            // gbxParentesco
            // 
            this.gbxParentesco.Controls.Add(this.btnAgregar);
            this.gbxParentesco.Controls.Add(this.btnModificar);
            this.gbxParentesco.Controls.Add(this.txtBtipoParentesco);
            this.gbxParentesco.Controls.Add(this.btnCancelar);
            this.gbxParentesco.Controls.Add(this.txtBIdParentesco);
            this.gbxParentesco.Controls.Add(this.cbxEstado);
            this.gbxParentesco.Controls.Add(this.label2);
            this.gbxParentesco.Controls.Add(this.lblidDocente);
            this.gbxParentesco.Location = new System.Drawing.Point(364, 37);
            this.gbxParentesco.Name = "gbxParentesco";
            this.gbxParentesco.Size = new System.Drawing.Size(335, 128);
            this.gbxParentesco.TabIndex = 20;
            this.gbxParentesco.TabStop = false;
            this.gbxParentesco.Text = "Datos Parentesco";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(24, 84);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(125, 84);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 31);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBtipoParentesco
            // 
            this.txtBtipoParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBtipoParentesco.Location = new System.Drawing.Point(108, 54);
            this.txtBtipoParentesco.Name = "txtBtipoParentesco";
            this.txtBtipoParentesco.Size = new System.Drawing.Size(100, 20);
            this.txtBtipoParentesco.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(226, 84);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBIdParentesco
            // 
            this.txtBIdParentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBIdParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBIdParentesco.Location = new System.Drawing.Point(108, 22);
            this.txtBIdParentesco.Name = "txtBIdParentesco";
            this.txtBIdParentesco.Size = new System.Drawing.Size(54, 20);
            this.txtBIdParentesco.TabIndex = 15;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Checked = true;
            this.cbxEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEstado.Location = new System.Drawing.Point(217, 17);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(108, 30);
            this.cbxEstado.TabIndex = 14;
            this.cbxEstado.Text = "Estado \r\n[Activo | Inactivo]";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Parentesco";
            // 
            // lblidDocente
            // 
            this.lblidDocente.AutoSize = true;
            this.lblidDocente.Location = new System.Drawing.Point(4, 25);
            this.lblidDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidDocente.Name = "lblidDocente";
            this.lblidDocente.Size = new System.Drawing.Size(21, 13);
            this.lblidDocente.TabIndex = 8;
            this.lblidDocente.Text = "ID:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(258, 409);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 27);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(157, 409);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 27);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitleTipoParentesco
            // 
            this.lblTitleTipoParentesco.AutoSize = true;
            this.lblTitleTipoParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTipoParentesco.Location = new System.Drawing.Point(12, 9);
            this.lblTitleTipoParentesco.Name = "lblTitleTipoParentesco";
            this.lblTitleTipoParentesco.Size = new System.Drawing.Size(139, 20);
            this.lblTitleTipoParentesco.TabIndex = 27;
            this.lblTitleTipoParentesco.Text = "Tipo Parentesco";
            // 
            // frmTipoParentesco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 441);
            this.Controls.Add(this.lblTitleTipoParentesco);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxParentesco);
            this.Controls.Add(this.dgvParenteco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTipoParentesco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Parentesco";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParenteco)).EndInit();
            this.gbxParentesco.ResumeLayout(false);
            this.gbxParentesco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvParenteco;
        private System.Windows.Forms.GroupBox gbxParentesco;
        private System.Windows.Forms.Label lblidDocente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIdParentesco;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.TextBox txtBtipoParentesco;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitleTipoParentesco;
    }
}