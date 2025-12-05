namespace CapaPresentacion
{
    partial class frmViewInscripcion
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
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(13, 14);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.RowHeadersWidth = 51;
            this.dgvInscripcion.RowTemplate.Height = 24;
            this.dgvInscripcion.Size = new System.Drawing.Size(774, 424);
            this.dgvInscripcion.TabIndex = 0;
            // 
            // frmViewInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInscripcion);
            this.Name = "frmViewInscripcion";
            this.Text = "frmViewInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripcion;
    }
}