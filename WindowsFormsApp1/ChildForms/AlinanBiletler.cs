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
    public partial class AlinanBiletler : Form
    {
        UcusProvider ucus = new UcusProvider();
        public AlinanBiletler()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlinanBiletler_Load(object sender, EventArgs e)
        {
            ucus.ListOfBiletlerMaster(gridmaster);

        }
    }
}
