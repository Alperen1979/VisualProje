using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VisiaulLogin
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Veritabanına bağlanmak için gerekli bağlantı dizesi
            string connectionString ="Data Source=DESKTOP-QVMQ6JH;Initial Catalog=ForVisiual;Integrated Security=True;Encrypt=True;TrustServerCertificate=true;";
            ;

            // Kullanıcıdan alınan bilgileri almak
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telNo = txtTelNo.Text;
            string email = txtEmail.Text;

            // Veritabanında kaydetme işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Personel (Ad, Soyad,sifre, Email) VALUES (@Ad, @Soyad, @sifre, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@sifre", telNo);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
