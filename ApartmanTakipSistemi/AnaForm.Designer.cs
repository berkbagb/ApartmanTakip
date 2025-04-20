namespace ApartmanTakipSistemi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOdenmemisAidatlar = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdenmemisAidatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daireToolStripMenuItem,
            this.aidatToolStripMenuItem,
            this.giderToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daireToolStripMenuItem
            // 
            this.daireToolStripMenuItem.Name = "daireToolStripMenuItem";
            this.daireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daireToolStripMenuItem.Text = "Daire";
            this.daireToolStripMenuItem.Click += new System.EventHandler(this.daireİşlemleriToolStripMenuItem_Click);
            // 
            // aidatToolStripMenuItem
            // 
            this.aidatToolStripMenuItem.Name = "aidatToolStripMenuItem";
            this.aidatToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aidatToolStripMenuItem.Text = "Aidat";
            this.aidatToolStripMenuItem.Click += new System.EventHandler(this.aidatİşlemleriToolStripMenuItem_Click);
            // 
            // giderToolStripMenuItem
            // 
            this.giderToolStripMenuItem.Name = "giderToolStripMenuItem";
            this.giderToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.giderToolStripMenuItem.Text = "Gider";
            this.giderToolStripMenuItem.Click += new System.EventHandler(this.giderİşlemleriToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // dgvOdenmemisAidatlar
            // 
            this.dgvOdenmemisAidatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdenmemisAidatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOdenmemisAidatlar.Location = new System.Drawing.Point(0, 246);
            this.dgvOdenmemisAidatlar.Name = "dgvOdenmemisAidatlar";
            this.dgvOdenmemisAidatlar.Size = new System.Drawing.Size(800, 204);
            this.dgvOdenmemisAidatlar.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOdenmemisAidatlar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.daireİşlemleriToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdenmemisAidatlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvOdenmemisAidatlar;
    }
}

