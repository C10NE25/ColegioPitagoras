namespace CapaPresentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTesoreria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenAdministrativo = new System.Windows.Forms.Button();
            this.btnAbrirDocente = new System.Windows.Forms.Button();
            this.btnOpenEstudiante = new System.Windows.Forms.Button();
            this.btnOpenNotas = new System.Windows.Forms.Button();
            this.btnOpenAsistencia = new System.Windows.Forms.Button();
            this.btnOpenCurso = new System.Windows.Forms.Button();
            this.btnAbrirConsultas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido a Colegio Pitagoras!";
            // 
            // btnOpenTesoreria
            // 
            this.btnOpenTesoreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTesoreria.Image = global::CapaPresentacion.Properties.Resources.IconTesoreria32x32;
            this.btnOpenTesoreria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTesoreria.Location = new System.Drawing.Point(220, 230);
            this.btnOpenTesoreria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenTesoreria.Name = "btnOpenTesoreria";
            this.btnOpenTesoreria.Size = new System.Drawing.Size(160, 117);
            this.btnOpenTesoreria.TabIndex = 12;
            this.btnOpenTesoreria.Text = "Tesoreria";
            this.btnOpenTesoreria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTesoreria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenTesoreria.UseVisualStyleBackColor = true;
            this.btnOpenTesoreria.Click += new System.EventHandler(this.btnOpenTesoreria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo_Pitagoras;
            this.pictureBox1.Location = new System.Drawing.Point(415, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenAdministrativo
            // 
            this.btnOpenAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAdministrativo.Image = global::CapaPresentacion.Properties.Resources.IconAdministrativo32x32;
            this.btnOpenAdministrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAdministrativo.Location = new System.Drawing.Point(220, 113);
            this.btnOpenAdministrativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenAdministrativo.Name = "btnOpenAdministrativo";
            this.btnOpenAdministrativo.Size = new System.Drawing.Size(160, 109);
            this.btnOpenAdministrativo.TabIndex = 10;
            this.btnOpenAdministrativo.Text = "Administrativo";
            this.btnOpenAdministrativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAdministrativo.UseVisualStyleBackColor = true;
            this.btnOpenAdministrativo.Click += new System.EventHandler(this.btnOpenAdministrativo_Click);
            // 
            // btnAbrirDocente
            // 
            this.btnAbrirDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirDocente.Image")));
            this.btnAbrirDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirDocente.Location = new System.Drawing.Point(25, 249);
            this.btnAbrirDocente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirDocente.Name = "btnAbrirDocente";
            this.btnAbrirDocente.Size = new System.Drawing.Size(187, 62);
            this.btnAbrirDocente.TabIndex = 9;
            this.btnAbrirDocente.Text = "Docente";
            this.btnAbrirDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirDocente.UseVisualStyleBackColor = true;
            this.btnAbrirDocente.Click += new System.EventHandler(this.btnAbrirDocente_Click);
            // 
            // btnOpenEstudiante
            // 
            this.btnOpenEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEstudiante.Image = global::CapaPresentacion.Properties.Resources.IconEstudiante32x32;
            this.btnOpenEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenEstudiante.Location = new System.Drawing.Point(25, 111);
            this.btnOpenEstudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenEstudiante.Name = "btnOpenEstudiante";
            this.btnOpenEstudiante.Size = new System.Drawing.Size(187, 62);
            this.btnOpenEstudiante.TabIndex = 8;
            this.btnOpenEstudiante.Text = "Estudiante";
            this.btnOpenEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenEstudiante.UseVisualStyleBackColor = true;
            this.btnOpenEstudiante.Click += new System.EventHandler(this.btnAbrirEstudiante_Click);
            // 
            // btnOpenNotas
            // 
            this.btnOpenNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNotas.Image = global::CapaPresentacion.Properties.Resources.IconNotas32x32;
            this.btnOpenNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenNotas.Location = new System.Drawing.Point(25, 318);
            this.btnOpenNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenNotas.Name = "btnOpenNotas";
            this.btnOpenNotas.Size = new System.Drawing.Size(187, 62);
            this.btnOpenNotas.TabIndex = 7;
            this.btnOpenNotas.Text = "Notas";
            this.btnOpenNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenNotas.UseVisualStyleBackColor = true;
            this.btnOpenNotas.Click += new System.EventHandler(this.btnOpenNotas_Click);
            // 
            // btnOpenAsistencia
            // 
            this.btnOpenAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAsistencia.Image = global::CapaPresentacion.Properties.Resources.IconAsistencia32x32;
            this.btnOpenAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAsistencia.Location = new System.Drawing.Point(25, 180);
            this.btnOpenAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenAsistencia.Name = "btnOpenAsistencia";
            this.btnOpenAsistencia.Size = new System.Drawing.Size(187, 62);
            this.btnOpenAsistencia.TabIndex = 6;
            this.btnOpenAsistencia.Text = "Asistencia";
            this.btnOpenAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAsistencia.UseVisualStyleBackColor = true;
            this.btnOpenAsistencia.Click += new System.EventHandler(this.btnOpenAsistencia_Click);
            // 
            // btnOpenCurso
            // 
            this.btnOpenCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCurso.Image = global::CapaPresentacion.Properties.Resources.IconCurso32x32;
            this.btnOpenCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCurso.Location = new System.Drawing.Point(25, 386);
            this.btnOpenCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenCurso.Name = "btnOpenCurso";
            this.btnOpenCurso.Size = new System.Drawing.Size(187, 62);
            this.btnOpenCurso.TabIndex = 5;
            this.btnOpenCurso.Text = "Curso";
            this.btnOpenCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCurso.UseVisualStyleBackColor = true;
            this.btnOpenCurso.Click += new System.EventHandler(this.btnOpenCurso_Click);
            // 
            // btnAbrirConsultas
            // 
            this.btnAbrirConsultas.Location = new System.Drawing.Point(220, 354);
            this.btnAbrirConsultas.Name = "btnAbrirConsultas";
            this.btnAbrirConsultas.Size = new System.Drawing.Size(160, 94);
            this.btnAbrirConsultas.TabIndex = 13;
            this.btnAbrirConsultas.Text = "Consulta";
            this.btnAbrirConsultas.UseMnemonic = false;
            this.btnAbrirConsultas.UseVisualStyleBackColor = true;
            this.btnAbrirConsultas.Click += new System.EventHandler(this.btnAbrirConsultas_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 485);
            this.Controls.Add(this.btnAbrirConsultas);
            this.Controls.Add(this.btnOpenTesoreria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenAdministrativo);
            this.Controls.Add(this.btnAbrirDocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenEstudiante);
            this.Controls.Add(this.btnOpenNotas);
            this.Controls.Add(this.btnOpenAsistencia);
            this.Controls.Add(this.btnOpenCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio Pitagoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenNotas;
        private System.Windows.Forms.Button btnOpenAsistencia;
        private System.Windows.Forms.Button btnOpenCurso;
        private System.Windows.Forms.Button btnOpenEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirDocente;
        private System.Windows.Forms.Button btnOpenAdministrativo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenTesoreria;
        private System.Windows.Forms.Button btnAbrirConsultas;
    }
}

