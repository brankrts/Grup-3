using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using WindowsFormsApp1.ChildForms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Controls.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {

        public  string CurrentTC { get; set; }
        
        private IconButton currentButton;
        private Panel leftBorderBtn;
        OpenChildForms open = new OpenChildForms();
        CurrentValues Current =  CurrentValues.Instance; 
        MusteriProvider Musteri = new MusteriProvider();
        UcusProvider ucus = new UcusProvider();
        
        
        
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        private void ActiveButton(object senderBtn, Color color)
        {


            if (senderBtn != null)
            {
                DisiableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                btnTitle.IconChar = currentButton.IconChar;
                btnTitle.IconColor = currentButton.IconColor;
                lblTitle.Text = currentButton.Text;



            }


        }
        private void DisiableButton()
        {



            if (currentButton != null)
            {

                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }
  
        private void Login()
        {
            
            if (Musteri.Login(txtTC, txtPassword))
            {

                lblUyari.Text = "Giriş Başarılı.";
                lblUyari.ForeColor = System.Drawing.Color.Green;
                CurrentTC = txtTC.Text.ToString();
                GetBildirimler();
                
            }
            else
            {
                txtTC.Text = "";
                txtPassword.Text = "";
                lblUyari.Text = "Giriş Başarısız.";
                lblUyari.ForeColor = System.Drawing.Color.Red;



            }
        }
        
        
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,53);
            pnlMenu.Controls.Add(leftBorderBtn);
            open.OpenChildForm(new ChildForms.FrmSearchFlight(), pnlChildForm);
            FormInitFalse();
        }

        private void FormInitFalse() {

            btnSearchFlight.Visible = false;
            btnMonthChart.Visible = false;
            btnMaster.Visible = false;
            btnAcountInfo.Visible = false;
            open.currentChildForm.Close();
            
            //open.OpenChildForm(new ChildForms.FrmLogin(), pnlChildForm);
        
        
        }
        private void FormInitTrue() {

            btnSearchFlight.Visible = true;
            btnMonthChart.Visible = true;
            btnAcountInfo.Visible = true;
            btnLogin.Visible = false;
            btnRegister.Visible = false;
            if (Musteri.IsMaster(Current.MusteriID)) {
                btnMaster.Visible = true;
                open.OpenChildForm(new ChildForms.FormMaster(), pnlChildForm);
            }else {
                open.OpenChildForm(new ChildForms.FrmSearchFlight(), pnlChildForm);


            }

        }



        private void ıconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            open.OpenChildForm(new ChildForms.FrmRegister(), pnlChildForm);
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            
            open.OpenChildForm(new ChildForms.FrmMonth(), pnlChildForm);
        }   

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            Reset();
            if (open.currentChildForm != null)
            {
                open.currentChildForm.Close();
            }

            // open.OpenChildForm(new ChildForms.FrmLogin(), pnlChildForm);


        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            
            open.OpenChildForm(new ChildForms.FrmSearchFlight(), pnlChildForm);
        }

        private void btnWhoAreWe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            open.OpenChildForm(new ChildForms.FrmWhoWeAre(), pnlChildForm);
            
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            
            open.OpenChildForm(new ChildForms.FormMaster(), pnlChildForm);
        }
        private void Reset() {

            DisiableButton();
            leftBorderBtn.Visible = true;
            btnTitle.IconChar = IconChar.SignInAlt;
            btnTitle.IconColor = Color.MediumPurple;
            lblTitle.Text = "Giriş Yap";
        
        }
        private void btnHome_Click(object sender, EventArgs e)
        {   
           /*Reset();
            if (open.currentChildForm != null)
            {
                open.currentChildForm.Close();
            }*/
        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboServer.SelectedIndex = 0;
            SetBildirimler();
            
        }
        private void GetBildirimler() {

            ucus.ListOfBildirimler();
            if (Current.RowCount!=0) {
                btnBildirimSayac.Text = Current.RowCount.ToString();
                btnBildirimSayac.BaseColor = System.Drawing.Color.Red;
                btnBildirimSayac.Visible = true;
                btnBildirim.Visible = true;

            }else
            {
                btnBildirimSayac.Text = "0";
                btnBildirimSayac.BaseColor = System.Drawing.Color.LightGray;
            }


        }
        private void SetBildirimler() {

            
            btnBildirimSayac.Visible = false;
            btnBildirim.Visible = false;
        
        
        }
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ıconButton2_Click_1(object sender, EventArgs e)
        {

            ActiveButton(sender, RGBColors.color5);
            open.OpenChildForm(new Proje1.HesapBilgilerim(),pnlChildForm);
        }

        private void btnTryLogin_Click(object sender, EventArgs e)
        {
            Login();
            FormInitTrue();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBildirim_Click(object sender, EventArgs e)
        {
            btnBildirimSayac.Text = "0";
            btnBildirimSayac.BaseColor = System.Drawing.Color.LightGray;
            BildirimGoruntule Bildirimler = new BildirimGoruntule();
            Bildirimler.Show();
            Bildirimler.Focus();
            
        }

        private void comboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblServer.Text = comboServer.SelectedItem.ToString() + " Serverine Bağlanıldı";
        }
    }
}
