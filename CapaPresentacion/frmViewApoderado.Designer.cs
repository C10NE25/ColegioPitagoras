namespace CapaPresentacion
{
    partial class frmViewApoderado
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
            this.dgvApoderado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApoderado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApoderado
            // 
            this.dgvApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApoderado.Location = new System.Drawing.Point(14, 12);
            this.dgvApoderado.Name = "dgvApoderado";
            this.dgvApoderado.RowHeadersWidth = 51;
            this.dgvApoderado.RowTemplate.Height = 24;
            this.dgvApoderado.Size = new System.Drawing.Size(772, 426);
            this.dgvApoderado.TabIndex = 0;
            // 
            // frmViewApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvApoderado);
            this.Name = "frmViewApoderado";
            this.Text = "frmViewApoderado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApoderado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApoderado;
    }
}