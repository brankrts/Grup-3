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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LAPTOP-QBUQDQGJ\\SQLEXPRESS;Initial Catalog=Sign;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString); //bağlantı oluştu
        SqlCommand komut;
        SqlDataReader read;

        private void xuıSuperButton1_Click(object sender, EventArgs e)
        {
            if (sifre.Text == sifre_tekrar.Text)
            {
                connect.Open();
                komut = new SqlCommand("select * from information where tc = '" + tc.Text + "'");
                komut.Connection = connect;
                read = komut.ExecuteReader();

                if (read.Read() == true)
                {
                    if (tc.Text == read["tc"].ToString() && eposta.Text == read["eposta"].ToString())
                    {
                        connect.Close();
                        connect.Open();
                        komut = new SqlCommand("update information set tc = '" + tc.Text + "' , sifre ='"+sifre.Text+"' where tc ='"+tc.Text+"'",connect);
                        komut.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("İşlem Başarılı ");
                     }
                    else
                    {
                        MessageBox.Show("Bilgileri kontol ediniz.");
                    } 
                    }
                    else
                    {
                        MessageBox.Show("Bilgileri kontrol ediniz.");
                    }
                connect.Close();
                    }
                    
         }
            }    }
        
