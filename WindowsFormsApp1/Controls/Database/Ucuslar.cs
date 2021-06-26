using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    class Ucuslar
    {
        int _UcusID;
        public int UcusID
        {
            get { return _UcusID; }
            set { _UcusID = value; }
        }


        int _SirketID;
        public int SirketID
        {
            get { return _SirketID; }
            set { _SirketID = value; }
        }
        int _Nereden;
        public int Nereden
        {
            get { return _Nereden; }
            set { _Nereden = value; }
        }
        int _Nereye;
        public int Nereye
        {
            get { return _Nereye; }
            set { _Nereye = value; }
        }
        DateTime _Tarih;
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        int _Fiyat;
        public int Fiyat
        {
            get { return _Fiyat; }
            set { _Fiyat = value; }
        }
    }

}
