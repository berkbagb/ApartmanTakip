namespace ApartmanTakipSistemi
{
    partial class AidatForm
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
            this.cmbDaire = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.chkOdendi = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvAidatlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDaire
            // 
            this.cmbDaire.FormattingEnabled = true;
            this.cmbDaire.Location = new System.Drawing.Point(134, 72);
            this.cmbDaire.Name = "cmbDaire";
            this.cmbDaire.Size = new System.Drawing.Size(121, 21);
            this.cmbDaire.TabIndex = 0;
            this.cmbDaire.Text = "Daire Seçimi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(134, 99);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 1;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(135, 125);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 20);
            this.nudMiktar.TabIndex = 2;
            // 
            // chkOdendi
            // 
            this.chkOdendi.AutoSize = true;
            this.chkOdendi.Location = new System.Drawing.Point(135, 152);
            this.chkOdendi.Name = "chkOdendi";
            this.chkOdendi.Size = new System.Drawing.Size(60, 17);
            this.chkOdendi.TabIndex = 3;
            this.chkOdendi.Text = "Ödendi";
            this.chkOdendi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(140, 175);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Ekle/Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvAidatlar
            // 
            this.dgvAidatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAidatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAidatlar.Location = new System.Drawing.Point(0, 300);
            this.dgvAidatlar.Name = "dgvAidatlar";
            this.dgvAidatlar.Size = new System.Drawing.Size(800, 150);
            this.dgvAidatlar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daire Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aidat Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aidat Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödendi mi?";
            // 
            // AidatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAidatlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkOdendi);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbDaire);
            this.Name = "AidatForm";
            this.Text = "AidatForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidatlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDaire;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.CheckBox chkOdendi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvAidatlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}