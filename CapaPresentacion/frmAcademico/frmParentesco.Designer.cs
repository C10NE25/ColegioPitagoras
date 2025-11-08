namespace CapaPresentacion.frmAcademico
{
    partial class frmParentesco
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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParenteco)).BeginInit();
            this.gbxParentesco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Parentesco";
            // 
            // dgvParenteco
            // 
            this.dgvParenteco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParenteco.Location = new System.Drawing.Point(17, 48);
            this.dgvParenteco.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParenteco.Name = "dgvParenteco";
            this.dgvParenteco.RowHeadersWidth = 51;
            this.dgvParenteco.Size = new System.Drawing.Size(1033, 209);
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
            this.gbxParentesco.Location = new System.Drawing.Point(20, 340);
            this.gbxParentesco.Margin = new System.Windows.Forms.Padding(4);
            this.gbxParentesco.Name = "gbxParentesco";
            this.gbxParentesco.Padding = new System.Windows.Forms.Padding(4);
            this.gbxParentesco.Size = new System.Drawing.Size(1031, 124);
            this.gbxParentesco.TabIndex = 20;
            this.gbxParentesco.TabStop = false;
            this.gbxParentesco.Text = "Datos Parentesco";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(616, 70);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 38);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(751, 70);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBtipoParentesco
            // 
            this.txtBtipoParentesco.Location = new System.Drawing.Point(144, 66);
            this.txtBtipoParentesco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBtipoParentesco.Name = "txtBtipoParentesco";
            this.txtBtipoParentesco.Size = new System.Drawing.Size(132, 22);
            this.txtBtipoParentesco.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(885, 70);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 38);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBIdParentesco
            // 
            this.txtBIdParentesco.Location = new System.Drawing.Point(144, 27);
            this.txtBIdParentesco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBIdParentesco.Name = "txtBIdParentesco";
            this.txtBIdParentesco.Size = new System.Drawing.Size(132, 22);
            this.txtBIdParentesco.TabIndex = 15;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(341, 21);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(129, 36);
            this.cbxEstado.TabIndex = 14;
            this.cbxEstado.Text = "Estado \r\n[Activo | Inactivo]";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Parentesco";
            // 
            // lblidDocente
            // 
            this.lblidDocente.AutoSize = true;
            this.lblidDocente.Location = new System.Drawing.Point(5, 31);
            this.lblidDocente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidDocente.Name = "lblidDocente";
            this.lblidDocente.Size = new System.Drawing.Size(23, 16);
            this.lblidDocente.TabIndex = 8;
            this.lblidDocente.Text = "ID:";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(784, 276);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(132, 33);
            this.btnDeshabilitar.TabIndex = 27;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(649, 276);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(515, 276);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 33);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(919, 277);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 32);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmParentesco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 516);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxParentesco);
            this.Controls.Add(this.dgvParenteco);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParentesco";
            this.Text = "frmParentesco";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParenteco)).EndInit();
            this.gbxParentesco.ResumeLayout(false);
            this.gbxParentesco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParenteco;
        private System.Windows.Forms.GroupBox gbxParentesco;
        private System.Windows.Forms.Label lblidDocente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIdParentesco;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.TextBox txtBtipoParentesco;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}