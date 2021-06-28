using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database; 


namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmRegister : Form
    {
        MusteriProvider Musteri = new MusteriProvider();
        Color colorGreen = System.Drawing.Color.Green;
        Color colorRed = System.Drawing.Color.Red;
        private bool Options(Guna.UI.WinForms.GunaLineTextBox t) {
            int sayac = 0;
            string text = t.Text;
            foreach (char txt in text)
           {
                sayac++;
                
           }
            if (sayac < 11 || sayac > 11) {

                lblHata.Text = "Girdiğiniz Bilgiler Hatalıdır.";
                lblHata.LinkColor = System.Drawing.Color.Red;
                return false;
            } return true;
        }
        private void ClearTXT() {

            lblHata.Text = "";
            


        }
        private bool Denetle() {
            if (txtTC.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || txtMail.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "" || txtTel.Text == "") {

                lblHata.Text = "Girdiğiniz Bilgiler Hatalıdır.";
                return false;
            }return true;
        
        
        }
        private void SelectedCombo() {
            cbmCinsiyet.SelectedIndex = 0;



        }
        private bool IsSame() {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                return true;
            }
            else {
                return false;
            }
        
        }
        private void ChangeLabelText(string message,Color color) {

            lblHata.Text = message;
            lblHata.LinkColor = color;
        
        
        }
        private void AddCostumer() {


            
            if (Denetle() && Options(txtTC) && Options(txtTel) || IsSame() ) {

                Musteri.Ekle(txtTC.Text.ToString(), txtAd.Text.ToString(), txtSoyad.Text.ToString(), cbmCinsiyet.SelectedItem.ToString(), txtTel.Text.ToString(), txtMail.Text.ToString(), txtSifre.Text.ToString());
                ChangeLabelText("Kayıt Başarı İle Tamamlandı",colorGreen);
            
            }
            ClearBOX();
        
        
        
        }
        private void ClearBOX() {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtTel.Text = "";
            SelectedCombo();




        }

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            SelectedCombo();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)

        {
            ClearTXT();
            Denetle();
            Options(txtTC);
            Options(txtTel);
            AddCostumer();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
