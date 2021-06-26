using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // sql işlemlerini kullanabilmek için

namespace ceyda_ozturk_giris_uye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=LAPTOP-QBUQDQGJ\\SQLEXPRESS;Initial Catalog=Sign;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString); //bağlantı oluştu
        SqlCommand komut;
        SqlDataReader read;

        private void sifre_tekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void xuıSuperButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifre.Text == sifre_tekrar.Text)
                {
                    if (connect.State == ConnectionState.Closed) //  eğer bağlantı kapalıysa bağlantıyı aç.
                        connect.Open();
                    string kayıt = "insert into information (tc,cinsiyet,ad,soyad,telefon,eposta,sifre,sifre_tekrar) values (@tc,@cinsiyet,@ad,@soyad,@telefon,@eposta,@sifre,@sifre_tekrar)";
                    SqlCommand komut = new SqlCommand(kayıt, connect);

                    komut.Parameters.AddWithValue("@tc", tc.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text.Substring(0, 2)); //cinsiyetin ilk 2 harfini alıyor .
                    komut.Parameters.AddWithValue("@ad", ad.Text);
                    komut.Parameters.AddWithValue("@soyad", soyad.Text);
                    komut.Parameters.AddWithValue("@telefon", telefon.Text);
                    komut.Parameters.AddWithValue("@eposta", eposta.Text);
                    komut.Parameters.AddWithValue("@sifre", sifre.Text);
                    komut.Parameters.AddWithValue("@sifre_tekrar", sifre_tekrar.Text);

                    komut.ExecuteReader();
                    connect.Close();

                    MessageBox.Show("Kayıt Olundu .");
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.", "Hata");
                }
            }
            catch (Exception error) // eğer hata varsa
            {
                MessageBox.Show("Hata meydana geldi" + error.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password password = new Password(); // Şifremi unuttum formuna yönledirme.
            password.ShowDialog(); 
        }

        private void buton_onay_Click(object sender, EventArgs e)
        { 
                if (connect.State == ConnectionState.Closed) //  eğer bağlantı kapalıysa bağlantıyı aç.
                    connect.Open();

                komut = new SqlCommand();
                komut.Connection = connect;
                komut.CommandText = "select * from information where tc = '"+giris_tc.Text+"'";
                read = komut.ExecuteReader();

                if (read.Read() == true) 
                {
                    if (giris_sifre.Text == read["sifre"].ToString())
                    {
                        MessageBox.Show("Giriş Başarılı");
                    }
                    else //şifre uyuşmadıysa
                    {
                        MessageBox.Show("Şifrenizi kontrol ediniz .");
                    } 
                }
                else // tc bilgisi uyuşmadıysa
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz .");
                }
                connect.Close();
            }
    }
}
