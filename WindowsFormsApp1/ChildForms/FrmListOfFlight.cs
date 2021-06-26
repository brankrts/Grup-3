using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FrmListOfFlight : Form
    {
        public FrmListOfFlight()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListOfFlight_Shown(object sender, EventArgs e)
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

        private void FrmListOfFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
