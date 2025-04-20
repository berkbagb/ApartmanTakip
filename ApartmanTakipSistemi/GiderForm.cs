using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanTakipSistemi
{
    public partial class GiderForm : Form
    {
        private DatabaseHelper dbHelper;

        public GiderForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadKategoriler();
            LoadGiderler();
        }

        private void LoadKategoriler()
        {
            string[] kategoriler = { "Elektrik", "Su", "Temizlik", "Asansör Bakımı", "Diğer" };
            cmbKategori.Items.AddRange(kategoriler);
            cmbKategori.SelectedIndex = 0;
        }

        private void LoadGiderler()
        {
            string query = "SELECT GiderID, Kategori, Miktar, Tarih, Aciklama FROM Giderler";
            dgvGiderler.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string kategori = cmbKategori.SelectedItem.ToString();
                decimal miktar = nudMiktar.Value;
                DateTime tarih = dtpTarih.Value;
                string aciklama = txtAciklama.Text.Trim();

                string query = "INSERT INTO Giderler (Kategori, Miktar, Tarih, Aciklama) VALUES (@Kategori, @Miktar, @Tarih, @Aciklama)";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@Kategori", kategori),
                    new SqlParameter("@Miktar", miktar),
                    new SqlParameter("@Tarih", tarih),
                    new SqlParameter("@Aciklama", aciklama)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Gider kaydedildi!");
                LoadGiderler();
                txtAciklama.Clear();
                nudMiktar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}