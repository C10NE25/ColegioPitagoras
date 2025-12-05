namespace CapaPresentacion
{
    partial class frmConsulta
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
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnApoderado = new System.Windows.Forms.Button();
            this.bnInscripcion = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Location = new System.Drawing.Point(120, 125);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(109, 183);
            this.btnEstudiante.TabIndex = 0;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApoderado
            // 
            this.btnApoderado.Location = new System.Drawing.Point(267, 125);
            this.btnApoderado.Name = "btnApoderado";
            this.btnApoderado.Size = new System.Drawing.Size(109, 183);
            this.btnApoderado.TabIndex = 1;
            this.btnApoderado.Text = "Apoderado";
            this.btnApoderado.UseVisualStyleBackColor = true;
            this.btnApoderado.Click += new System.EventHandler(this.btnApoderado_Click);
            // 
            // bnInscripcion
            // 
            this.bnInscripcion.Location = new System.Drawing.Point(430, 125);
            this.bnInscripcion.Name = "bnInscripcion";
            this.bnInscripcion.Size = new System.Drawing.Size(109, 183);
            this.bnInscripcion.TabIndex = 2;
            this.bnInscripcion.Text = "Inscripcion";
            this.bnInscripcion.UseVisualStyleBackColor = true;
            this.bnInscripcion.Click += new System.EventHandler(this.bnInscripcion_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(577, 125);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(109, 183);
            this.btnMatricula.TabIndex = 3;
            this.btnMatricula.Text = "Matricula";
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija la consulta a visualizar";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.bnInscripcion);
            this.Controls.Add(this.btnApoderado);
            this.Controls.Add(this.btnEstudiante);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnApoderado;
        private System.Windows.Forms.Button bnInscripcion;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label label1;
    }
}