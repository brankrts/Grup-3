using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmLogin : Form
    {   
        MusteriProvider Musteri = new MusteriProvider();
        CurrentValues CurrenMusteri = CurrentValues.Instance;
        

        //private void Login() {
            

            
        //    if (Musteri.Login(txtTC, txtPassword))
        //    {
                
        //        lblUyari.Text = "Giriş Başarılı.";
        //        lblUyari.ForeColor = System.Drawing.Color.Green;
                
                

        //    }
            
        //    else {
        //        txtTC.Text = "";
        //        txtPassword.Text = "";
        //        lblUyari.Text = "Giriş Başarısız.";
        //        lblUyari.ForeColor = System.Drawing.Color.Red;



        //    }
            
        
        //}
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnTryLogin_Click(object sender, EventArgs e)
        {
            //Login();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
