using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    class Biletler
    {
        int _BiletID;
        public int BiletID
        {
            get { return _BiletID; }
            set { _BiletID = value; }
        }


        


        int _UcusID;
        public int UcusID
        {
            get { return _UcusID; }
            set { _UcusID = value; }
        }


        int _MusteriID;
        public int MusteriID
        {
            get { return _MusteriID; }
            set { _MusteriID = value; }
        }
        int _KoltukID;
        public int KoltukID
        {
            get { return _KoltukID; }
            set { _KoltukID = value; }
        }
    }
}
