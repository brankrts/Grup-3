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
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        OpenChildForms open = new OpenChildForms();
        
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,53);
            pnlMenu.Controls.Add(leftBorderBtn);
        }

        
        private struct RGBColors {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        private void ActiveButton(object senderBtn, Color color) {


            if (senderBtn != null) {
                DisiableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                btnTitle.IconChar = currentButton.IconChar;
                btnTitle.IconColor = currentButton.IconColor;
                lblTitle.Text = currentButton.Text;


            
            }
        
        
        }
        private void DisiableButton() {



            if (currentButton != null) {
                
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;


            } }
       

        
       

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
            
            open.OpenChildForm(new ChildForms.FrmLogin(), pnlChildForm);


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
            leftBorderBtn.Visible = false;
            btnTitle.IconChar = IconChar.Home;
            btnTitle.IconColor = Color.MediumPurple;
            lblTitle.Text = "Anasayfa";
        
        }
        private void btnHome_Click(object sender, EventArgs e)
        {   
            Reset();
            if (open.currentChildForm != null)
            {
                open.currentChildForm.Close();
            }
        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboServer.SelectedIndex = 0;
            
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ıconButton2_Click_1(object sender, EventArgs e)
        {

            ActiveButton(sender, RGBColors.color5);
            open.OpenChildForm(new Proje1.HesapBilgilerim(),pnlChildForm);
        }
    }
}
