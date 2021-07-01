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

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Open.OpenChildForm(new FrmAccountInfo(),pnlHesab) ;
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
