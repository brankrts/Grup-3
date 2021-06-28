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

namespace WindowsFormsApp1.ChildForms.FrmMaster
{
    public partial class frmAddMaster : Form
    {
        MusteriProvider Musteri = new MusteriProvider();
        public frmAddMaster()
        {
            InitializeComponent();
        }

        private void btnAddFlightToDb_Click(object sender, EventArgs e)
        {
            Musteri.Ekle(txtTC.Text.ToString(), txtAd.Text.ToString(), txtSoyad.Text.ToString(), cbmCinsiyet.SelectedItem.ToString(), txtTel.Text.ToString(), txtMail.Text.ToString(), txtSifre.Text.ToString(), cmbYetki.SelectedItem.ToString()) ;
            lblUyari.Text = "Kayıt Eklendi";
        }
    }
}
