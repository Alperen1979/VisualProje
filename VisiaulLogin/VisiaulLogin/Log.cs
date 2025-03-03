using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VisiaulLogin
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // E-posta ve şifre çekme
            string email = text1.Text; // Email TextBox'ı
            string password = text2.Text; // Şifre TextBox'ı

            // Veritabanına bağlanmak için gerekli bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-QVMQ6JH;Initial Catalog=ForVisiual;Integrated Security=True;Encrypt=True;TrustServerCertificate=true;";

            // Giriş işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Personel WHERE Email = @Email AND Sifre = @Sifre"; // Sifre alanını da ekleyin
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Sifre", password); // Şifreyi ekleyin

                try
                {
                    int count = (int)command.ExecuteScalar();
                    if (count == 1)
                    {
                        // Kullanıcı giriş yaptıysa, bakiye alanını güncelle
                        

                        MessageBox.Show("Giriş başarılı!");
                        // Giriş başarılı olduğunda Form1'i açabilirsiniz
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Giriş bilgileri hatalı. Lütfen tekrar deneyin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.ShowDialog();
        }
    }
}
