using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanTakipSistemi
{
    public partial class DaireForm : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedDaireID = 0;

        public DaireForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadDaireler();
        }

        private void LoadDaireler()
        {
            string query = "SELECT DaireID, DaireNo, Kat, Metrekare FROM Daireler";
            dgvDaireler.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string daireNo = txtDaireNo.Text.Trim();
                if (string.IsNullOrEmpty(daireNo) || !int.TryParse(txtKat.Text, out int kat) || !decimal.TryParse(txtMetrekare.Text, out decimal metrekare))
                {
                    MessageBox.Show("Lütfen tüm alanları doğru doldurun!");
                    return;
                }

                string query;
                SqlParameter[] parameters;
                if (selectedDaireID == 0) // Yeni daire
                {
                    query = "INSERT INTO Daireler (DaireNo, Kat, Metrekare) VALUES (@DaireNo, @Kat, @Metrekare)";
                    parameters = new[]
                    {
                        new SqlParameter("@DaireNo", daireNo),
                        new SqlParameter("@Kat", kat),
                        new SqlParameter("@Metrekare", metrekare)
                    };
                }
                else // Güncelleme
                {
                    query = "UPDATE Daireler SET DaireNo = @DaireNo, Kat = @Kat, Metrekare = @Metrekare WHERE DaireID = @DaireID";
                    parameters = new[]
                    {
                        new SqlParameter("@DaireNo", daireNo),
                        new SqlParameter("@Kat", kat),
                        new SqlParameter("@Metrekare", metrekare),
                        new SqlParameter("@DaireID", selectedDaireID)
                    };
                }

                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Daire kaydedildi!");
                LoadDaireler();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void ClearDaireInputs()
        {
            selectedDaireID = 0;
            txtDaireNo.Clear();
            txtKat.Clear();
            txtMetrekare.Clear();
            btnDaireSil.Enabled = false;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedDaireID == 0)
            {
                MessageBox.Show("Lütfen silmek için bir daire seçin!");
                return;
            }

            if (MessageBox.Show("Bu daireyi silmek istediğinize emin misiniz? Bu işlem, daireye ait tüm aidat kayıtlarını da silecektir.", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // Önce Aidatlar tablosundan ilgili kayıtları sil
                    string deleteAidatQuery = "DELETE FROM Aidatlar WHERE DaireID = @DaireID";
                    SqlParameter[] aidatParameters = new[] { new SqlParameter("@DaireID", selectedDaireID) };
                    dbHelper.ExecuteNonQuery(deleteAidatQuery, aidatParameters);

                    // Sonra Daireler tablosundan daireyi sil
                    string deleteDaireQuery = "DELETE FROM Daireler WHERE DaireID = @DaireID";
                    SqlParameter[] daireParameters = new[] { new SqlParameter("@DaireID", selectedDaireID) };
                    dbHelper.ExecuteNonQuery(deleteDaireQuery, daireParameters);

                    MessageBox.Show("Daire ve ilgili aidat kayıtları silindi!");
                    LoadDaireler();
                    AnaForm a = new AnaForm();
                    a.LoadOdenmemisAidatlar();
                    //LoadOdenmemisAidatlar(); // Ödenmemiş aidat listesini güncelle
                    ClearDaireInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dgvDaireler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDaireler.Rows[e.RowIndex];
                selectedDaireID = Convert.ToInt32(row.Cells["DaireID"].Value);
                txtDaireNo.Text = row.Cells["DaireNo"].Value.ToString();
                txtKat.Text = row.Cells["Kat"].Value.ToString();
                txtMetrekare.Text = row.Cells["Metrekare"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            selectedDaireID = 0;
            txtDaireNo.Clear();
            txtKat.Clear();
            txtMetrekare.Clear();
        }
    }
}