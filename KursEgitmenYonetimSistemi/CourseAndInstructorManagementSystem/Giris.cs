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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        string connectionString = "Server=.;Database=KursEgitmenYonetim;Trusted_Connection=True;";

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Admin WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                conn.Open();
                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    EgitmenYonetim form = new EgitmenYonetim();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniYoneticiKayıt uyeOlForm = new YeniYoneticiKayıt();
            uyeOlForm.Show();
            this.Hide();
        }
    }
}
