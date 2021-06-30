using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Windows.Forms;


namespace Proje1
{
    public partial class MevcutUçuşlarım : Form
    {
        UcusProvider Ucuslar = new UcusProvider();
        CurrentValues Current = CurrentValues.Instance;
        public MevcutUçuşlarım()
        {
           
            
            InitializeComponent();
        }
        
        private void MevcutUçuşlarım_Load(object sender, EventArgs e)
        {
            Ucuslar.ListOfBiletler(Current.MusteriID, gridListofFlight);
        }

        private void gridListofFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
