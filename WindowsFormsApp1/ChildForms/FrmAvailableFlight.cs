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
    public partial class MevcutUçuşlarım : Form
    {
        public MevcutUçuşlarım()
        {
            InitializeComponent();
        }

        private void MevcutUçuşlarım_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUcusGecmısım_Click(object sender, EventArgs e)
        {
            UçuşGeçmişim uçuşGeçmişim = new UçuşGeçmişim();
            uçuşGeçmişim.Show();
            
        }

        private void btnKayıtlıOdeme_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MevcutUçuşlarım_Shown(object sender, EventArgs e)
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

                   "Pegasus",
                   "Ankara",
                   "İstanbul",
                   "20:10:2004",
                   "297"



                });
        }
    }
}
