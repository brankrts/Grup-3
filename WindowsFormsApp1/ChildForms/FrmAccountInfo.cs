using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Controls.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmAccountInfo : Form
    {
        MusteriProvider Musteriler = new MusteriProvider();
        CurrentValues current = CurrentValues.Instance;
        
        public FrmAccountInfo()
        {
            InitializeComponent();
            HesapListele();

        }
        private void HesapListele() {
            

            Musteriler.HesabBilgileri(current.MusteriID,txtAdi,txtSoyadi,txtTel,txtMail);
        
        
        
        }
        private void pnlHesab_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            txtTel.Enabled = true;
            txtMail.Enabled = true;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteriler.Guncelle(current.MusteriID,txtAdi.Text,txtSoyadi.Text,txtTel.Text,txtMail.Text);
            HesapListele();
        }
    }
}
