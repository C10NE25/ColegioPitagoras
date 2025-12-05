namespace CapaPresentacion.frmAcademico
{
    partial class frmTipoEvaluacion
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
            this.dgvTipoEvaluacion = new System.Windows.Forms.DataGridView();
            this.gbTipoEvaluacion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNomTipoNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoEvaluacion = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEvaluacion)).BeginInit();
            this.gbTipoEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Evaluaciones";
            // 
            // dgvTipoEvaluacion
            // 
            this.dgvTipoEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoEvaluacion.Location = new System.Drawing.Point(17, 46);
            this.dgvTipoEvaluacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTipoEvaluacion.Name = "dgvTipoEvaluacion";
            this.dgvTipoEvaluacion.RowHeadersWidth = 30;
            this.dgvTipoEvaluacion.RowTemplate.Height = 24;
            this.dgvTipoEvaluacion.Size = new System.Drawing.Size(432, 446);
            this.dgvTipoEvaluacion.TabIndex = 43;
            this.dgvTipoEvaluacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoEvaluacion_CellClick);
            this.dgvTipoEvaluacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoEvaluacion_CellContentClick);
            // 
            // gbTipoEvaluacion
            // 
            this.gbTipoEvaluacion.Controls.Add(this.btnAgregar);
            this.gbTipoEvaluacion.Controls.Add(this.btnModificar);
            this.gbTipoEvaluacion.Controls.Add(this.cbxEstado);
            this.gbTipoEvaluacion.Controls.Add(this.btnCancelar);
            this.gbTipoEvaluacion.Controls.Add(this.txtNomTipoNota);
            this.gbTipoEvaluacion.Controls.Add(this.label3);
            this.gbTipoEvaluacion.Controls.Add(this.label2);
            this.gbTipoEvaluacion.Controls.Add(this.txtIdTipoEvaluacion);
            this.gbTipoEvaluacion.Location = new System.Drawing.Point(471, 46);
            this.gbTipoEvaluacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTipoEvaluacion.Name = "gbTipoEvaluacion";
            this.gbTipoEvaluacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTipoEvaluacion.Size = new System.Drawing.Size(359, 217);
            this.gbTipoEvaluacion.TabIndex = 44;
            this.gbTipoEvaluacion.TabStop = false;
            this.gbTipoEvaluacion.Text = "Dato de Evaluaciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(40, 161);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 36);
            this.btnAgregar.TabIndex = 151;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(139, 161);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 36);
            this.btnModificar.TabIndex = 152;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(13, 123);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(192, 20);
            this.cbxEstado.TabIndex = 134;
            this.cbxEstado.Text = "Estado de Tipo Evaluacion";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(237, 161);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 36);
            this.btnCancelar.TabIndex = 153;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNomTipoNota
            // 
            this.txtNomTipoNota.Location = new System.Drawing.Point(147, 71);
            this.txtNomTipoNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomTipoNota.Name = "txtNomTipoNota";
            this.txtNomTipoNota.Size = new System.Drawing.Size(167, 22);
            this.txtNomTipoNota.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Evaluacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txtIdTipoEvaluacion
            // 
            this.txtIdTipoEvaluacion.Location = new System.Drawing.Point(147, 34);
            this.txtIdTipoEvaluacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdTipoEvaluacion.Name = "txtIdTipoEvaluacion";
            this.txtIdTipoEvaluacion.ReadOnly = true;
            this.txtIdTipoEvaluacion.Size = new System.Drawing.Size(79, 22);
            this.txtIdTipoEvaluacion.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(348, 498);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 32);
            this.btnEditar.TabIndex = 149;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(255, 500);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 31);
            this.btnNuevo.TabIndex = 148;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmTipoEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 540);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbTipoEvaluacion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoEvaluacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTipoEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEvaluacion)).EndInit();
            this.gbTipoEvaluacion.ResumeLayout(false);
            this.gbTipoEvaluacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoEvaluacion;
        private System.Windows.Forms.GroupBox gbTipoEvaluacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoEvaluacion;
        private System.Windows.Forms.TextBox txtNomTipoNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}