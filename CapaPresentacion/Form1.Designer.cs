namespace CapaPresentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.panelAdministrativoSubMenu = new System.Windows.Forms.Panel();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.panelAdministrativoSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMenuLateral.Controls.Add(this.panelAdministrativoSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnAdministrativo);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(465, 1382);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(465, 192);
            this.panelLogo.TabIndex = 1;
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrativo.Location = new System.Drawing.Point(0, 192);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(465, 95);
            this.btnAdministrativo.TabIndex = 1;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // panelAdministrativoSubMenu
            // 
            this.panelAdministrativoSubMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAdministrativoSubMenu.Controls.Add(this.button5);
            this.panelAdministrativoSubMenu.Controls.Add(this.button4);
            this.panelAdministrativoSubMenu.Controls.Add(this.btnDocente);
            this.panelAdministrativoSubMenu.Controls.Add(this.btnEstudiante);
            this.panelAdministrativoSubMenu.Controls.Add(this.btnTutor);
            this.panelAdministrativoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdministrativoSubMenu.Location = new System.Drawing.Point(0, 287);
            this.panelAdministrativoSubMenu.Name = "panelAdministrativoSubMenu";
            this.panelAdministrativoSubMenu.Size = new System.Drawing.Size(465, 442);
            this.panelAdministrativoSubMenu.TabIndex = 1;
            // 
            // btnTutor
            // 
            this.btnTutor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTutor.Location = new System.Drawing.Point(0, 0);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(465, 73);
            this.btnTutor.TabIndex = 0;
            this.btnTutor.Text = "Tutor";
            this.btnTutor.UseVisualStyleBackColor = false;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiante.Location = new System.Drawing.Point(0, 73);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(465, 73);
            this.btnEstudiante.TabIndex = 1;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnDocente
            // 
            this.btnDocente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocente.Location = new System.Drawing.Point(0, 146);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(465, 73);
            this.btnDocente.TabIndex = 2;
            this.btnDocente.Text = "Docente";
            this.btnDocente.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(465, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(465, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.DimGray;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(465, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1775, 1382);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2240, 1382);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenuLateral);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimumSize = new System.Drawing.Size(2268, 1461);
            this.Name = "Form1";
            this.Text = "t ";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelAdministrativoSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Panel panelAdministrativoSubMenu;
        private System.Windows.Forms.Button btnTutor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

