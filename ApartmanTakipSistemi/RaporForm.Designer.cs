namespace ApartmanTakipSistemi
{
    partial class RaporForm
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
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Location = new System.Drawing.Point(160, 21);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbRaporTuru.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(160, 48);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(121, 23);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Raporu göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRapor.Location = new System.Drawing.Point(0, 115);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(443, 150);
            this.dgvRapor.TabIndex = 2;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 265);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.cmbRaporTuru);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dgvRapor;
    }
}