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

namespace WindowsFormsApp1.ChildForms.frmMaster
{
    public partial class frmAddFlight : Form

    {
        UcusProvider Ucuslar = new UcusProvider();
        SehirlerProvider sehirler = new SehirlerProvider();
        SirketlerProvider sirketler = new SirketlerProvider();
        public frmAddFlight()
        {
            InitializeComponent();
        }
        private void UcusEkle() {
            string SehirADiNereden;
            string SehirAdiNereye;
            string SirketAdi;
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            string saat = txtSaat.Text;
            SirketAdi = cmbFirma.SelectedItem.ToString();
            SehirADiNereden = cmbNereden.SelectedItem.ToString();
            SehirAdiNereye = cmbNereye.SelectedItem.ToString();

            int SirketID=  sirketler.GetID(SirketAdi);
            int SehirNeredenID = sehirler.GetID(SehirADiNereden);
            int SehirNereyeID = sehirler.GetID(SehirAdiNereye);


            if (SehirADiNereden == SehirAdiNereye) {

                lblUyari.Text = "Aynı Şehirler Seçilemez.";

            }
            else
            {
                Ucuslar.AddFlight(SirketID,SehirNeredenID,SehirNereyeID,cmbTarih.Value,saat,fiyat);
                lblUyari.ForeColor = System.Drawing.Color.Green;
                lblUyari.Text = "Başarı İle Eklendi";

            }
        
        
        
        
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtFromWhere_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtWhere_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtDate_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtFiyat.Text = "";
        }

        private void frmAddFlight_Load(object sender, EventArgs e)
        {
            sehirler.ListOfSehirler(cmbNereden);
            sehirler.ListOfSehirler(cmbNereye);
            sirketler.ListOfSirketler(cmbFirma);

        }

        private void txtPrice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFlightToDb_Click(object sender, EventArgs e)
        {
            UcusEkle();

        }

        private void txtSaat_Click(object sender, EventArgs e)
        {
            txtSaat.Text = "";
        }

        private void txtFiyat_Click(object sender, EventArgs e)
        {
            txtFiyat.Text = "";
        }
    }
}
