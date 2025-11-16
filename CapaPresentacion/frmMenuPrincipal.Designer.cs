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
            this.gbAcademico = new System.Windows.Forms.GroupBox();
            this.btnOpenGAcademico = new System.Windows.Forms.Button();
            this.btnOpenNotas = new System.Windows.Forms.Button();
            this.btnOpenAsistencia = new System.Windows.Forms.Button();
            this.gbAdministrativo = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDocente = new System.Windows.Forms.Button();
            this.btnOpenEstudiante = new System.Windows.Forms.Button();
            this.btnOpenCurso = new System.Windows.Forms.Button();
            this.gbAcademico.SuspendLayout();
            this.gbAdministrativo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAcademico
            // 
            this.gbAcademico.Controls.Add(this.btnOpenGAcademico);
            this.gbAcademico.Controls.Add(this.btnOpenDocente);
            this.gbAcademico.Controls.Add(this.btnOpenEstudiante);
            this.gbAcademico.Controls.Add(this.btnOpenNotas);
            this.gbAcademico.Controls.Add(this.btnOpenCurso);
            this.gbAcademico.Controls.Add(this.btnOpenAsistencia);
            this.gbAcademico.Location = new System.Drawing.Point(32, 87);
            this.gbAcademico.Name = "gbAcademico";
            this.gbAcademico.Size = new System.Drawing.Size(245, 325);
            this.gbAcademico.TabIndex = 1;
            this.gbAcademico.TabStop = false;
            this.gbAcademico.Text = "Academico";
            // 
            // btnOpenGAcademico
            // 
            this.btnOpenGAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenGAcademico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenGAcademico.Location = new System.Drawing.Point(15, 151);
            this.btnOpenGAcademico.Name = "btnOpenGAcademico";
            this.btnOpenGAcademico.Size = new System.Drawing.Size(173, 40);
            this.btnOpenGAcademico.TabIndex = 10;
            this.btnOpenGAcademico.Text = "Grado Academico";
            this.btnOpenGAcademico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenGAcademico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenGAcademico.UseVisualStyleBackColor = true;
            this.btnOpenGAcademico.Click += new System.EventHandler(this.btnOpenGAcademico_Click);
            // 
            // btnOpenNotas
            // 
            this.btnOpenNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenNotas.Location = new System.Drawing.Point(15, 241);
            this.btnOpenNotas.Name = "btnOpenNotas";
            this.btnOpenNotas.Size = new System.Drawing.Size(173, 40);
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
            this.btnOpenAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAsistencia.Location = new System.Drawing.Point(15, 195);
            this.btnOpenAsistencia.Name = "btnOpenAsistencia";
            this.btnOpenAsistencia.Size = new System.Drawing.Size(173, 40);
            this.btnOpenAsistencia.TabIndex = 6;
            this.btnOpenAsistencia.Text = "Asistencia";
            this.btnOpenAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAsistencia.UseVisualStyleBackColor = true;
            this.btnOpenAsistencia.Click += new System.EventHandler(this.btnOpenAsistencia_Click);
            // 
            // gbAdministrativo
            // 
            this.gbAdministrativo.Controls.Add(this.button9);
            this.gbAdministrativo.Controls.Add(this.button1);
            this.gbAdministrativo.Location = new System.Drawing.Point(300, 87);
            this.gbAdministrativo.Name = "gbAdministrativo";
            this.gbAdministrativo.Size = new System.Drawing.Size(245, 145);
            this.gbAdministrativo.TabIndex = 2;
            this.gbAdministrativo.TabStop = false;
            this.gbAdministrativo.Text = "Administrativo";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(215, 32);
            this.button9.TabIndex = 10;
            this.button9.Text = "Matricula";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Periodo Academico";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(567, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tesoreria";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(15, 68);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(215, 32);
            this.button13.TabIndex = 13;
            this.button13.Text = "Tarifa";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(215, 32);
            this.button11.TabIndex = 12;
            this.button11.Text = "Plan Pago";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido a Colegio Pitagoras!";
            // 
            // btnOpenDocente
            // 
            this.btnOpenDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDocente.Image = global::CapaPresentacion.Properties.Resources.IconDocente32x32;
            this.btnOpenDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDocente.Location = new System.Drawing.Point(15, 60);
            this.btnOpenDocente.Name = "btnOpenDocente";
            this.btnOpenDocente.Size = new System.Drawing.Size(173, 40);
            this.btnOpenDocente.TabIndex = 9;
            this.btnOpenDocente.Text = "Docente";
            this.btnOpenDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenDocente.UseVisualStyleBackColor = true;
            this.btnOpenDocente.Click += new System.EventHandler(this.btnOpenDocente_Click);
            // 
            // btnOpenEstudiante
            // 
            this.btnOpenEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEstudiante.Image = global::CapaPresentacion.Properties.Resources.IconEstudiante32x32;
            this.btnOpenEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenEstudiante.Location = new System.Drawing.Point(15, 16);
            this.btnOpenEstudiante.Name = "btnOpenEstudiante";
            this.btnOpenEstudiante.Size = new System.Drawing.Size(173, 40);
            this.btnOpenEstudiante.TabIndex = 8;
            this.btnOpenEstudiante.Text = "Estudiante";
            this.btnOpenEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenEstudiante.UseVisualStyleBackColor = true;
            this.btnOpenEstudiante.Click += new System.EventHandler(this.btnAbrirEstudiante_Click);
            // 
            // btnOpenCurso
            // 
            this.btnOpenCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCurso.Image = global::CapaPresentacion.Properties.Resources.IconCurso32x32;
            this.btnOpenCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCurso.Location = new System.Drawing.Point(15, 105);
            this.btnOpenCurso.Name = "btnOpenCurso";
            this.btnOpenCurso.Size = new System.Drawing.Size(173, 40);
            this.btnOpenCurso.TabIndex = 5;
            this.btnOpenCurso.Text = "Curso";
            this.btnOpenCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCurso.UseVisualStyleBackColor = true;
            this.btnOpenCurso.Click += new System.EventHandler(this.btnOpenCurso_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAdministrativo);
            this.Controls.Add(this.gbAcademico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio Pitagoras";
            this.gbAcademico.ResumeLayout(false);
            this.gbAdministrativo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAcademico;
        private System.Windows.Forms.GroupBox gbAdministrativo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenNotas;
        private System.Windows.Forms.Button btnOpenAsistencia;
        private System.Windows.Forms.Button btnOpenCurso;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnOpenEstudiante;
        private System.Windows.Forms.Button btnOpenDocente;
        private System.Windows.Forms.Button btnOpenGAcademico;
        private System.Windows.Forms.Label label1;
    }
}

