using System;
using System.Windows.Forms;

namespace ApartmanTakipSistemi
{
    public partial class RaporForm : Form
    {
        private DatabaseHelper dbHelper;

        public RaporForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadRaporTurleri();
        }

        private void LoadRaporTurleri()
        {
            cmbRaporTuru.Items.AddRange(new[] { "Ödenmemiş Aidatlar", "Gider Özeti" });
            cmbRaporTuru.SelectedIndex = 0;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string query = "";
            if (cmbRaporTuru.SelectedItem.ToString() == "Ödenmemiş Aidatlar")
            {
                query = "SELECT d.DaireNo, a.Tarih, a.Miktar FROM Aidatlar a JOIN Daireler d ON a.DaireID = d.DaireID WHERE a.OdendiMi = 0";
            }
            else if (cmbRaporTuru.SelectedItem.ToString() == "Gider Özeti")
            {
                query = "SELECT Kategori, SUM(Miktar) as ToplamMiktar FROM Giderler GROUP BY Kategori";
            }

            dgvRapor.DataSource = dbHelper.ExecuteQuery(query);
        }
    }
}