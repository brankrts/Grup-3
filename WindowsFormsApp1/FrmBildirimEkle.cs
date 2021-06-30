using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1
{
    public partial class FrmBildirimEkle : Form
    {
        KoltukProvider koltuk = new KoltukProvider();
        public FrmBildirimEkle()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTryLogin_Click(object sender, EventArgs e)
        {
            koltuk.BildirimEkle(txtBildirim.Text);
            lblBilgi.Text = "Bildirim Eklendi.";
            txtBildirim.Text = "";

        }

        private void txtBildirim_Click(object sender, EventArgs e)
        {
            lblBilgi.Text = "";
        }
    }
}
