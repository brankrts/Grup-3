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

namespace WindowsFormsApp1.ChildForms
{
    public partial class BildirimGoruntule : Form
    {
        UcusProvider ucuslar = new UcusProvider();
        public BildirimGoruntule()
        {
            InitializeComponent();
        }

        private void BildirimGoruntule_Load(object sender, EventArgs e)
        {
            ucuslar.ListOfBildirimlerAddGrid(gridLisBildirimler);
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
