using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    class Sirketler
    {
        int _SirketID;
        public int SirketID
        {
            get { return _SirketID; }
            set { _SirketID = value; }
        }


        string _SirketAdi;
        public string SirketAdi
        {
            get { return _SirketAdi; }
            set { _SirketAdi = value; }
        }
    }
}
