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
    public partial class EgitmenYonetim : Form
    {
        public EgitmenYonetim()
        {
            InitializeComponent();
        }
        private void EgitmenleriYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Egitmen", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEgitmenler.DataSource = dt;
            }
        }
        private Egitmen EgitmenNesnesiOlustur()
        {
            string adSoyad = txtAdSoyad.Text;
            string tur = cmbUzmanlikAlani.SelectedItem?.ToString();

            switch (tur)
            {
                case "Dil":
                    return new DilEgitmeni
                    {
                        AdSoyad = adSoyad,
                        BildigiDiller = txtBildigiDiller.Text
                    };

                case "Programlama":
                    return new ProgramlamaEgitmeni
                    {
                        AdSoyad = adSoyad,
                        BildigiDiller = txtBildigiDiller.Text
                    };

                case "Resim":
                    return new ResimEgitmeni
                    {
                        AdSoyad = adSoyad,
                        KullandigiMalzemeler = txtMalzemeler.Text
                    };

                case "Müzik":
                    return new MuzikEgitmeni
                    {
                        AdSoyad = adSoyad,
                        CalabildigiEnstrumanlar = txtEnstrumanlar.Text
                    };

                default:
                    throw new Exception("Geçersiz eğitmen türü seçildi.");
            }
        }


        string connectionString = "Server=.;Database=KursEgitmenYonetim;Trusted_Connection=True;";
        private void btnEkleEgitmen_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = EgitmenNesnesiOlustur();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Egitmen (AdSoyad, UzmanlikAlani, BildigiDiller, KullandigiMalzemeler, CalabildigiEnstrumanlar) " +
                               "VALUES (@ad, @tip, @dil, @malzeme, @enstruman)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", egitmen.AdSoyad);
                cmd.Parameters.AddWithValue("@tip", cmbUzmanlikAlani.Text);

                if (egitmen is DilEgitmeni dil)
                {
                    cmd.Parameters.AddWithValue("@dil", dil.BildigiDiller);
                    cmd.Parameters.AddWithValue("@malzeme", DBNull.Value);
                    cmd.Parameters.AddWithValue("@enstruman", DBNull.Value);
                }
                else if (egitmen is ProgramlamaEgitmeni prog)
                {
                    cmd.Parameters.AddWithValue("@dil", prog.BildigiDiller);
                    cmd.Parameters.AddWithValue("@malzeme", DBNull.Value);
                    cmd.Parameters.AddWithValue("@enstruman", DBNull.Value);
                }
                else if (egitmen is ResimEgitmeni resim)
                {
                    cmd.Parameters.AddWithValue("@dil", DBNull.Value);
                    cmd.Parameters.AddWithValue("@malzeme", resim.KullandigiMalzemeler);
                    cmd.Parameters.AddWithValue("@enstruman", DBNull.Value);
                }
                else if (egitmen is MuzikEgitmeni muzik)
                {
                    cmd.Parameters.AddWithValue("@dil", DBNull.Value);
                    cmd.Parameters.AddWithValue("@malzeme", DBNull.Value);
                    cmd.Parameters.AddWithValue("@enstruman", muzik.CalabildigiEnstrumanlar);
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }


            MessageBox.Show(egitmen.EgitmenBilgisi(), "Eğitmen Eklendi");
            EgitmenleriYukle();

        }

        private void EgitmenYonetim_Load(object sender, EventArgs e)
        {
            cmbUzmanlikAlani.Items.AddRange(new string[] {"Dil", "Programlama", "Resim", "Müzik"});
            EgitmenleriYukle();
        }

        private void btnSilEgitmen_Click(object sender, EventArgs e)
        {
            if (dgvEgitmenler.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dgvEgitmenler.SelectedRows[0].Cells["EgitmenID"].Value);
                string secilenAd = dgvEgitmenler.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
                string secilenDil = dgvEgitmenler.SelectedRows[0].Cells["BildigiDiller"].Value.ToString();
                string tip = dgvEgitmenler.SelectedRows[0].Cells["UzmanlikAlani"].Value.ToString();

                cmbUzmanlikAlani.SelectedItem = tip;
                txtAdSoyad.Text = secilenAd;
                txtBildigiDiller.Text = secilenDil;
                Egitmen egitmen = EgitmenNesnesiOlustur();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Egitmen WHERE EgitmenID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show(egitmen.EgitmenBilgisi(), "Eğitmen Silindi");
                EgitmenleriYukle();

            }
            else
            {
                MessageBox.Show("Silmek için bir eğitmen seçin.");
            }
        }

        private void btnGuncelleEgitmen_Click(object sender, EventArgs e)
        {

            if (dgvEgitmenler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir eğitmen seçiniz.");
                return;
            }

            int egitmenID = Convert.ToInt32(dgvEgitmenler.SelectedRows[0].Cells["EgitmenID"].Value);

            string adSoyad = txtAdSoyad.Text;
            string tur = cmbUzmanlikAlani.SelectedItem?.ToString();

            string bildigiDiller = null;
            string kullandigiMalzemeler = null;
            string calabildigiEnstrumanlar = null;

            if (tur == "Dil" || tur == "Programlama")
                bildigiDiller = txtBildigiDiller.Text;
            else if (tur == "Resim")
                kullandigiMalzemeler = txtMalzemeler.Text;
            else if (tur == "Müzik")
                calabildigiEnstrumanlar = txtEnstrumanlar.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Egitmen SET AdSoyad = @ad, UzmanlikAlani = @tur, " +
                               "BildigiDiller = @dil, KullandigiMalzemeler = @malzeme, CalabildigiEnstrumanlar = @enstruman " +
                               "WHERE EgitmenID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", adSoyad);
                cmd.Parameters.AddWithValue("@tur", tur ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@dil", (object)(bildigiDiller ?? (object)DBNull.Value));
                cmd.Parameters.AddWithValue("@malzeme", (object)(kullandigiMalzemeler ?? (object)DBNull.Value));
                cmd.Parameters.AddWithValue("@enstruman", (object)(calabildigiEnstrumanlar ?? (object)DBNull.Value));
                cmd.Parameters.AddWithValue("@id", egitmenID);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Eğitmen başarıyla güncellendi.");
                    else
                        MessageBox.Show("Güncelleme başarısız.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                EgitmenleriYukle();
            }
        }

        private void dgvEgitmenler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEgitmenler.Rows[e.RowIndex];

                txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                cmbUzmanlikAlani.SelectedItem = row.Cells["UzmanlikAlani"].Value?.ToString();
                txtBildigiDiller.Text = row.Cells["BildigiDiller"].Value?.ToString();
                txtMalzemeler.Text = row.Cells["KullandigiMalzemeler"].Value?.ToString();
                txtEnstrumanlar.Text = row.Cells["CalabildigiEnstrumanlar"].Value?.ToString();
            }
        }

        private void btnKursYonetim_Click(object sender, EventArgs e)
        {
            KursYonetim form = new KursYonetim();
            form.Show();
            this.Hide();
        }
    }
}
