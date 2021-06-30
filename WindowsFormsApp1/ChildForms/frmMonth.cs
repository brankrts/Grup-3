using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmMonth : Form
    {
        SehirlerProvider Sehirler = new SehirlerProvider();
        Ucuslar ucus = Ucuslar.Instance;
        UcusProvider ucusProvider = new UcusProvider();
        private void GetValues()
        {

            int NeredenID = Sehirler.GetID(cmbNereden.SelectedItem.ToString());
            int NereyeID = Sehirler.GetID(cmbNereye.SelectedItem.ToString());
            ucus.Nereden = NeredenID;
            ucus.Nereye = NereyeID;
            
    
        }
        public FrmMonth()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
         }

        private void FrmMonth_Load(object sender, EventArgs e)
        {
            Sehirler.ListOfSehirler(cmbNereden);
            Sehirler.ListOfSehirler(cmbNereye);
            cmbNereden.SelectedIndex = 1;
            cmbNereye.SelectedIndex = 4;
            GetValues();
            ucusProvider.ListOfCharts(chart1, ucus.Nereden, ucus.Nereye, lblNereden, lblNereye);

        }

        private void btnSearchFlight_Click(object sender, EventArgs e)

        {
            GetValues();
            ucusProvider.ListOfCharts(chart1,ucus.Nereden,ucus.Nereye,lblNereden,lblNereye);
        }
    }
}
