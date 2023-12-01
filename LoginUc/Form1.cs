using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LoginUc
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ProjelerVT;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            textBoxSifre.PasswordChar = '*';
        }

        private string sha256KoduOlustur(string sha256Kodu)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sha256Kodu));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text.ToString().Length == 0 || textBoxSifre.Text.ToString().Length == 0)
            {
                MessageBox.Show("Alanlar boþ býrakýlamaz!");
                return;
            }
            try
            {
                connection.Open();
                string commend = "SELECT KullaniciAdi, Sifre FROM Kullanici WHERE KullaniciAdi = @P1 AND Sifre = @P2";
                SqlCommand cmd = new SqlCommand(commend, connection);
                cmd.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@P2", sha256KoduOlustur(textBoxSifre.Text));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Kullanýcý adý ve Þifre doðru! Sisteme Hoþ Geldiniz!!");
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya Þifre hatalý!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT baðlantýsýnda sorun oluþtu \n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text.ToString().Length == 0 || textBoxSifre.Text.ToString().Length == 0)
            {
                MessageBox.Show("Alanlar boþ býrakýlamaz!");
                return;
            }

            string cmd = "SELECT KullaniciAdi FROM Kullanici WHERE KullaniciAdi = @P1";

            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                bool yeniKullaniciEkle = false;

                if (reader.HasRows)
                {
                    MessageBox.Show(textBoxKullaniciAdi.Text + " isminde bir kullanýcý zaten mevcut, ekleme yapýlamadý!");
                }
                else
                {
                    yeniKullaniciEkle = true;
                }
                reader.Close();

                if (yeniKullaniciEkle) 
                {
                    sqlCommand = new SqlCommand("INSERT INTO Kullanici VALUES (@P1, @P2)", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", sha256KoduOlustur(textBoxSifre.Text));
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT baðlantýsýnda sorun oluþtu \n" + ex.Message);
            }
            finally 
            { 
                if (connection != null)
                    connection.Close(); 
            }
        }
    }
}
