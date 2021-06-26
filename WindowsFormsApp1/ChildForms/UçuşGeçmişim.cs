using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class UçuşGeçmişim : Form
    {
        public UçuşGeçmişim()
        {
            InitializeComponent();
        }

        private void btnUcusGecmısım_Click(object sender, EventArgs e)
        {
            UçuşGeçmişim uçuşGeçmişim = new UçuşGeçmişim();
            uçuşGeçmişim.Show();
            Hide();
        }

        private void btnHesapYonetımı_Click(object sender, EventArgs e)
        {
            HesapBilgilerim hesapBilgilerim = new HesapBilgilerim();
            hesapBilgilerim.Show();
           
        }

        private void btnMevcutUcuslarım_Click(object sender, EventArgs e)
        {
            MevcutUçuşlarım mevcutUçuşlarım = new MevcutUçuşlarım();
            mevcutUçuşlarım.Show();
        }

        private void btnKayıtlıOdeme_Click(object sender, EventArgs e)
        {
            
        }

        private void UçuşGeçmişim_Load(object sender, EventArgs e)
        {

        }

        private void UçuşGeçmişim_Shown(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Add(


               new object[] {

                   "Pegasus",
                   "Ankara",
                   "İstanbul",
                   "20:10:2004",
                   "297"



               });
            bunifuCustomDataGrid1.Rows.Add(


                new object[] {

                   "Pegasus",
                   "Ankara",
                   "İstanbul",
                   "20:10:2004",
                   "297"



                });
            bunifuCustomDataGrid1.Rows.Add(


                new object[] {

                   "THY",
                   "Ankara",
                   "İZMİR",
                   "20:10:2004",
                   "500"



                });
            bunifuCustomDataGrid1.Rows.Add(


                new object[] {

                   "THY",
                   "Ankara",
                   "İZMİR",
                   "20:10:2004",
                   "500"



                });
            bunifuCustomDataGrid1.Rows.Add(


                new object[] {

                   "THY",
                   "Ankara",
                   "İZMİR",
                   "20:10:2004",
                   "500"



                });
        }
    }
}
