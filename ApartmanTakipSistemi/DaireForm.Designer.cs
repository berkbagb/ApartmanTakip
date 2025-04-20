namespace ApartmanTakipSistemi
{
    partial class DaireForm
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
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvDaireler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaireler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(238, 57);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(100, 20);
            this.txtDaireNo.TabIndex = 0;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(238, 83);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 20);
            this.txtKat.TabIndex = 1;
            // 
            // txtMetrekare
            // 
            this.txtMetrekare.Location = new System.Drawing.Point(238, 109);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(100, 20);
            this.txtMetrekare.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(249, 135);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(249, 164);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvDaireler
            // 
            this.dgvDaireler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaireler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDaireler.Location = new System.Drawing.Point(0, 300);
            this.dgvDaireler.Name = "dgvDaireler";
            this.dgvDaireler.Size = new System.Drawing.Size(800, 150);
            this.dgvDaireler.TabIndex = 5;
            this.dgvDaireler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaireler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daire No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Metrekare";
            // 
            // DaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDaireler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMetrekare);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtDaireNo);
            this.Name = "DaireForm";
            this.Text = "DaireForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaireler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDaireNo;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvDaireler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}