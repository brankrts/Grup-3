using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    public class Musteriler
    {

        static Musteriler instance;



        public static Musteriler Instance
        {
            get
            {
                if (instance == null)
                    instance = new Musteriler();
                return instance;
            }
        }

        private Musteriler() { }






        int _MusteriID;
        public int MusteriID
        {
            get { return _MusteriID; }
            set { _MusteriID = value; }
        }
        string _TC;
        public string TC
        {
            get { return _TC; }
            set { _TC = value; }
        }


        string _MusteriAdi;
        public string MusteriAdi
        {
            get { return _MusteriAdi; }
            set { _MusteriAdi = value; }
        }
        string _MusteriSoyadi;
        public string MusteriSoyadi
        {
            get { return _MusteriSoyadi; }
            set { _MusteriSoyadi = value; }
        }


        string _MusteriCinsiyet;
        public string MusteriCinsiyet
        {
            get { return _MusteriCinsiyet; }
            set { _MusteriCinsiyet = value; }
        }
        string _MusteriTel;
        public string MusteriTel
        {
            get { return _MusteriTel; }
            set { _MusteriTel = value; }
        }
        string _MusteriMail;
        public string MusteriMail
        {
            get { return _MusteriMail; }
            set { _MusteriMail = value; }
        }
        string _MusteriYetki;
        public string MusteriYetki
        {
            get { return _MusteriYetki; }
            set { _MusteriYetki = value; }
        }
        string _MusteriSifre;
        public string MusteriSifre
        {
            get { return _MusteriSifre; }
            set { _MusteriSifre = value; }
        }

    }
}
