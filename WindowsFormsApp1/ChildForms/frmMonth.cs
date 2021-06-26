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

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmMonth : Form
    {
        public FrmMonth()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
                  }

        private void FrmMonth_Load(object sender, EventArgs e)
        {
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Ankara-- > İstabul Seferleri";
            chart1.Titles.Add(title);
            chart1.Series["THY"].Points.AddY(295);
            chart1.Series["PGS"].Points.AddY(350);
            chart1.Series["AJET"].Points.AddY(425);
            chart1.Series["THY"].Points.AddY(293);
            chart1.Series["PGS"].Points.AddY(546);
            chart1.Series["AJET"].Points.AddY(859);
            chart1.Series["THY"].Points.AddY(256);
            chart1.Series["PGS"].Points.AddY(110);
            chart1.Series["AJET"].Points.AddY(987);
        }
    }
}
