namespace CapaPresentacion.frmAcademico
{
    partial class frmAsignatura
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
            this.dgvAsignatura = new System.Windows.Forms.DataGridView();
            this.gbxSeccion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAsignatura = new System.Windows.Forms.TextBox();
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).BeginInit();
            this.gbxSeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsignatura
            // 
            this.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignatura.Location = new System.Drawing.Point(13, 50);
            this.dgvAsignatura.Margin = new System.Windows.Forms.Padding(1);
            this.dgvAsignatura.Name = "dgvAsignatura";
            this.dgvAsignatura.ReadOnly = true;
            this.dgvAsignatura.RowHeadersWidth = 92;
            this.dgvAsignatura.RowTemplate.Height = 37;
            this.dgvAsignatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignatura.Size = new System.Drawing.Size(844, 217);
            this.dgvAsignatura.TabIndex = 51;
            this.dgvAsignatura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignatura_CellClick);
            // 
            // gbxSeccion
            // 
            this.gbxSeccion.Controls.Add(this.btnAgregar);
            this.gbxSeccion.Controls.Add(this.btnModificar);
            this.gbxSeccion.Controls.Add(this.btnCancelar);
            this.gbxSeccion.Controls.Add(this.cbxEstado);
            this.gbxSeccion.Controls.Add(this.label3);
            this.gbxSeccion.Controls.Add(this.label2);
            this.gbxSeccion.Controls.Add(this.txtIdAsignatura);
            this.gbxSeccion.Controls.Add(this.txtNombreAsignatura);
            this.gbxSeccion.Location = new System.Drawing.Point(13, 298);
            this.gbxSeccion.Margin = new System.Windows.Forms.Padding(1);
            this.gbxSeccion.Name = "gbxSeccion";
            this.gbxSeccion.Padding = new System.Windows.Forms.Padding(1);
            this.gbxSeccion.Size = new System.Drawing.Size(585, 240);
            this.gbxSeccion.TabIndex = 52;
            this.gbxSeccion.TabStop = false;
            this.gbxSeccion.Text = "Datos de la Asignatura";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(165, 186);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 38);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(300, 186);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 38);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(435, 186);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(19, 114);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(1);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(172, 20);
            this.cbxEstado.TabIndex = 13;
            this.cbxEstado.Text = "Estado de la Asignatura";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de la Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Asignatura";
            // 
            // txtIdAsignatura
            // 
            this.txtIdAsignatura.Location = new System.Drawing.Point(236, 28);
            this.txtIdAsignatura.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdAsignatura.Name = "txtIdAsignatura";
            this.txtIdAsignatura.Size = new System.Drawing.Size(75, 22);
            this.txtIdAsignatura.TabIndex = 1;
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.Location = new System.Drawing.Point(236, 63);
            this.txtNombreAsignatura.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(195, 22);
            this.txtNombreAsignatura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Asignatura";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(665, 427);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(132, 33);
            this.btnDeshabilitar.TabIndex = 56;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(665, 378);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(665, 321);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 33);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(665, 475);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 32);
            this.btnCerrar.TabIndex = 53;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 554);
            this.Controls.Add(this.dgvAsignatura);
            this.Controls.Add(this.gbxSeccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAsignatura";
            this.Text = "frmAsignatura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).EndInit();
            this.gbxSeccion.ResumeLayout(false);
            this.gbxSeccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsignatura;
        private System.Windows.Forms.GroupBox gbxSeccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAsignatura;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
    }
}