using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanTakipSistemi
{
    public partial class AidatForm : Form
    {
        private DatabaseHelper dbHelper;

        public AidatForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadDaireler();
            LoadAidatlar();
        }

        private void LoadDaireler()
        {
            string query = "SELECT DaireID, DaireNo FROM Daireler";
            DataTable dt = dbHelper.ExecuteQuery(query);
            cmbDaire.DataSource = dt;
            cmbDaire.DisplayMember = "DaireNo";
            cmbDaire.ValueMember = "DaireID";
        }

        private void LoadAidatlar()
        {
            string query = "SELECT a.AidatID, d.DaireNo, a.Tarih, a.Miktar, a.OdendiMi FROM Aidatlar a JOIN Daireler d ON a.DaireID = d.DaireID";
            dgvAidatlar.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDaire.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir daire seçin!");
                    return;
                }

                int daireID = Convert.ToInt32(cmbDaire.SelectedValue);
                DateTime tarih = dtpTarih.Value;
                decimal miktar = nudMiktar.Value;
                bool odendiMi = chkOdendi.Checked;

                string query = "INSERT INTO Aidatlar (DaireID, Tarih, Miktar, OdendiMi) VALUES (@DaireID, @Tarih, @Miktar, @OdendiMi)";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@DaireID", daireID),
                    new SqlParameter("@Tarih", tarih),
                    new SqlParameter("@Miktar", miktar),
                    new SqlParameter("@OdendiMi", odendiMi)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Aidat kaydedildi!");
                LoadAidatlar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}