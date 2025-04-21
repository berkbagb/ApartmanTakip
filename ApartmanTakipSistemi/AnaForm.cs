using System;
using System.Windows.Forms;

namespace ApartmanTakipSistemi
{
    public partial class AnaForm : Form
    {
        private DatabaseHelper dbHelper;

        public AnaForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadOdenmemisAidatlar();
        }

        public void LoadOdenmemisAidatlar()
        {
            string query = "SELECT d.DaireNo, a.Tarih, a.Miktar FROM Aidatlar a JOIN Daireler d ON a.DaireID = d.DaireID WHERE a.OdendiMi = 0";
            dgvOdenmemisAidatlar.DataSource = dbHelper.ExecuteQuery(query);
        }
        

        private void daireİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaireForm daireForm = new DaireForm();
            daireForm.ShowDialog();
            MessageBox.Show("1seksondebiç");
        }

        private void aidatİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AidatForm aidatForm = new AidatForm();
            aidatForm.ShowDialog();
            LoadOdenmemisAidatlar(); // Aidat eklendikten sonra güncelle
        }

        private void giderİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderForm giderForm = new GiderForm();
            giderForm.ShowDialog();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.ShowDialog();
        }
    }
}