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
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.ChildForms;

namespace Proje1
{
    public partial class HesapBilgilerim : Form
    {
        OpenChildForms Open = new OpenChildForms();
        public HesapBilgilerim()
        {
            InitializeComponent();
        }

        void Yenile()
        {
            //dataGridView1.DataSource = UpdateList.List("Select * from HesapBilgilerim ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Open.OpenChildForm(new FrmAccountInfo(),pnlHesab) ;
        }
        void Temizle()
        {
         
        /*foreach (Control item in this.groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                    
            }*/
	{

	}

        }

    private void xuıSuperButton1_Click(object sender, EventArgs e)
        {

        }

        private void xuıSuperButton2_Click(object sender, EventArgs e)
        {
            MevcutUçuşlarım mevcutUçuşlarım = new MevcutUçuşlarım();
            mevcutUçuşlarım.Show();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHesapYonetımı_Click(object sender, EventArgs e)
        {
            HesapBilgilerim hesapBilgilerim = new HesapBilgilerim();
            hesapBilgilerim.Show();
            Hide();
        }

        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblUlke_Click(object sender, EventArgs e)
        {

        }
                                          

        private void btnUcusGecmısım_Click(object sender, EventArgs e)
        {
            UçuşGeçmişim uçuşGeçmişim = new UçuşGeçmişim();
            uçuşGeçmişim.Show();
            
        }

        private void btnKayıtlıOdeme_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        SqlCommand komut;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {/*
            string sql = "Update HesapBilgilerim Set Adi='" + txtAd.Text + "',Soyadi='" + txtSoyad.Text + "',Telefon='" + txtCepNo.Text + "',TcKimlikNo='" + txtTcNo.Text + "',Eposta='" + txtEposta.Text + "' Where ID='"+txtID.Text+"' ";
            komut = new SqlCommand();
            UpdateList.GUNLIST(sql, komut);
            Yenile();
            Temizle();
        */
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            

            Open.OpenChildForm(new MevcutUçuşlarım(),pnlHesab);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            Open.OpenChildForm(new FrmAccountInfo() , pnlHesab);
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            Open.OpenChildForm(new UçuşGeçmişim(), pnlHesab);
        }
    }
}
