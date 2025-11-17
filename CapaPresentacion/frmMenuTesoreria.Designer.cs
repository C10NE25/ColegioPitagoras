namespace CapaPresentacion
{
    partial class frmMenuTesoreria
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
            this.lblMenuAdministrativo = new System.Windows.Forms.Label();
            this.btnOpenNAcademico = new System.Windows.Forms.Button();
            this.btnOpenGAcademico = new System.Windows.Forms.Button();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.btnOpenApoderado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuAdministrativo
            // 
            this.lblMenuAdministrativo.AutoSize = true;
            this.lblMenuAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdministrativo.Location = new System.Drawing.Point(12, 20);
            this.lblMenuAdministrativo.Name = "lblMenuAdministrativo";
            this.lblMenuAdministrativo.Size = new System.Drawing.Size(221, 25);
            this.lblMenuAdministrativo.TabIndex = 19;
            this.lblMenuAdministrativo.Text = "Elija la opcion a realizar!";
            // 
            // btnOpenNAcademico
            // 
            this.btnOpenNAcademico.Location = new System.Drawing.Point(21, 197);
            this.btnOpenNAcademico.Name = "btnOpenNAcademico";
            this.btnOpenNAcademico.Size = new System.Drawing.Size(197, 36);
            this.btnOpenNAcademico.TabIndex = 14;
            this.btnOpenNAcademico.Text = "Tipo Cargo";
            this.btnOpenNAcademico.UseVisualStyleBackColor = true;
            // 
            // btnOpenGAcademico
            // 
            this.btnOpenGAcademico.Location = new System.Drawing.Point(21, 113);
            this.btnOpenGAcademico.Name = "btnOpenGAcademico";
            this.btnOpenGAcademico.Size = new System.Drawing.Size(197, 36);
            this.btnOpenGAcademico.TabIndex = 12;
            this.btnOpenGAcademico.Text = "Pago";
            this.btnOpenGAcademico.UseVisualStyleBackColor = true;
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.Location = new System.Drawing.Point(21, 155);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(197, 36);
            this.btnAsignatura.TabIndex = 11;
            this.btnAsignatura.Text = "Modalidad Pago";
            this.btnAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnOpenApoderado
            // 
            this.btnOpenApoderado.Location = new System.Drawing.Point(21, 71);
            this.btnOpenApoderado.Name = "btnOpenApoderado";
            this.btnOpenApoderado.Size = new System.Drawing.Size(197, 36);
            this.btnOpenApoderado.TabIndex = 10;
            this.btnOpenApoderado.Text = "Detalle Pago";
            this.btnOpenApoderado.UseVisualStyleBackColor = true;
            // 
            // frmMenuTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 254);
            this.Controls.Add(this.lblMenuAdministrativo);
            this.Controls.Add(this.btnOpenNAcademico);
            this.Controls.Add(this.btnOpenGAcademico);
            this.Controls.Add(this.btnAsignatura);
            this.Controls.Add(this.btnOpenApoderado);
            this.Name = "frmMenuTesoreria";
            this.Text = "frmMenuTesoreria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAdministrativo;
        private System.Windows.Forms.Button btnOpenNAcademico;
        private System.Windows.Forms.Button btnOpenGAcademico;
        private System.Windows.Forms.Button btnAsignatura;
        private System.Windows.Forms.Button btnOpenApoderado;
    }
}