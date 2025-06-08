using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseAndInstructorManagementSystem
{
    public partial class KursYonetim : Form
    {

        public KursYonetim()
        {
            InitializeComponent();
        }

        string connectionString = "Server=.;Database=KursEgitmenYonetim;Trusted_Connection=True;";
        private void KurslariYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kurs", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKurslar.DataSource = dt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KurslariYukle();
            cmbKursTuru.Items.AddRange(new string[] { "Dil", "Programlama", "Resim", "Müzik" });

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtKursAdi.Text;
            string tur = cmbKursTuru.SelectedItem?.ToString();

            Kurs kurs = null;

            if (tur == "Dil")
                kurs = new DilKursu();
            else if (tur == "Programlama")
                kurs = new ProgramlamaKursu();
            else if (tur == "Resim")
                kurs = new ResimKursu();
            else if (tur == "Müzik")
                kurs = new MuzikKursu();
            else
            {
                MessageBox.Show("Geçerli bir kurs türü seçiniz.");
                return;
            }

            kurs.KursAdi = ad;
            kurs.KursTuru = tur;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kurs (KursAdi, KursTuru) VALUES (@ad, @tur)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@tur", tur);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show(kurs.KursBilgisi() + "kurs eklendi!");

            KurslariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKurslar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kursu seçiniz.");
                return;
            }

            int kursID = Convert.ToInt32(dgvKurslar.SelectedRows[0].Cells["KursID"].Value);
            string kursAd = dgvKurslar.SelectedRows[0].Cells["KursAdi"].Value?.ToString();
            string kursTuru = dgvKurslar.SelectedRows[0].Cells["KursTuru"].Value?.ToString();

            Kurs kurs = null;

            if (kursTuru == "Dil")
                kurs = new DilKursu();
            else if (kursTuru == "Programlama")
                kurs = new ProgramlamaKursu();
            else if (kursTuru == "Resim")
                kurs = new ResimKursu();
            else if (kursTuru == "Müzik")
                kurs = new MuzikKursu();
            else
            {
                MessageBox.Show("Kurs türü tanımsız.");
                return;
            }

            kurs.KursAdi = kursAd;
            kurs.KursTuru = kursTuru;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Kurs WHERE KursID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", kursID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show($"Silindi: {kurs.KursBilgisi()}");
            KurslariYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKurslar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek kursu seçiniz.");
                return;
            }

            int kursID = Convert.ToInt32(dgvKurslar.SelectedRows[0].Cells["KursID"].Value);
            string kursAd = txtKursAdi.Text;
            string kursTuru = cmbKursTuru.SelectedItem?.ToString();

            Kurs kurs = null;

            if (kursTuru == "Dil")
                kurs = new DilKursu();
            else if (kursTuru == "Programlama")
                kurs = new ProgramlamaKursu();
            else if (kursTuru == "Resim")
                kurs = new ResimKursu();
            else if (kursTuru == "Müzik")
                kurs = new MuzikKursu();
            else
            {
                MessageBox.Show("Kurs türü tanımsız.");
                return;
            }

            kurs.KursAdi = kursAd;
            kurs.KursTuru = kursTuru;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Kurs SET KursAdi = @ad, KursTuru = @tur WHERE KursID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", kursAd);
                cmd.Parameters.AddWithValue("@tur", kursTuru);
                cmd.Parameters.AddWithValue("@id", kursID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show($"Güncellendi: {kurs.KursBilgisi()}");
            KurslariYukle();
        }
        private void dgvKurslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKurslar.Rows[e.RowIndex];
                txtKursAdi.Text = row.Cells["KursAdi"].Value?.ToString();
                cmbKursTuru.Text = row.Cells["KursTuru"].Value?.ToString();
                txtDil.Text = row.Cells["Dil"].Value?.ToString();
                txtSeviye.Text = row.Cells["Seviye"].Value?.ToString();
                txtProgramlamaDili.Text = row.Cells["ProgramlamaDili"].Value?.ToString();
                txtZorluk.Text = row.Cells["Zorluk"].Value?.ToString();
            }
        }

        private void btnEgitmeneDon_Click(object sender, EventArgs e)
        {
            EgitmenYonetim form = new EgitmenYonetim();
            form.Show();
            this.Hide();
        }
    }
}
