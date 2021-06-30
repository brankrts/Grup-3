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
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1.ChildForms.FormsMaster
{
    public partial class MasterListOfFlights : Form
    {
        UcusProvider Flights = new UcusProvider();
        
        string komut = "SELECT Sirketler.SirketAdi,s1.SehirAdi,s2.SehirAdi,Ucuslar.Tarih,Ucuslar.Saat,Ucuslar.Fiyat FROM Ucuslar INNER JOIN Sirketler ON Ucuslar.SirketID = Sirketler.SirketID INNER JOIN Sehirler as s1 ON Ucuslar.Nereden = s1.SehirID INNER JOIN Sehirler as s2 ON Ucuslar.Nereye = s2.SehirID";

        public MasterListOfFlights()
        {
            InitializeComponent();
        }

        private void gridListofFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MasterListOfFlights_Load(object sender, EventArgs e)
        {
            Flights.ListFlightMaster(gridListofFlight,komut);
        }

        private void gridListofFlight_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
