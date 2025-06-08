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
    public partial class YeniYoneticiKayıt : Form
    {
        public YeniYoneticiKayıt()
        {
            InitializeComponent();
        }

        string connectionString = "Server=.;Database=KursEgitmenYonetim;Trusted_Connection=True;";
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Admin (KullaniciAdi, Sifre) VALUES (@kadi, @sifre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kadi", txtYeniKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", txtYeniSifre.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı.");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kayıt başarısız: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Giris girisForm = new Giris();
            girisForm.Show();
            this.Close();
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtYeniKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
