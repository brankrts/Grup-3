using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1.Controls.Database
{
    class MusteriProvider
{
        DbConnector dbcon = new DbConnector();
        public MusteriProvider() //Kurucu metot
        {
            dbcon.Baglan();
        }
        

        public List<Musteriler> Listele()
        {
            
            try
            {
                List<Musteriler> MusteriListesi = new List<Musteriler>();
                dbcon.cmd.CommandText = "Select *From Musteriler";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Musteriler m = new Musteriler();
                    m.MusteriID = Convert.ToInt32(reader[0].ToString());
                    m.TC = reader[1].ToString();
                    m.MusteriAdi = reader[2].ToString();
                    m.MusteriSoyadi = reader[3].ToString();
                    m.MusteriCinsiyet = reader[4].ToString();
                    m.MusteriTel = reader[5].ToString();
                    m.MusteriMail = reader[6].ToString();
                    m.MusteriSifre = reader[7].ToString();
                    m.MusteriYetki = reader[8].ToString();
                    MusteriListesi.Add(m);
                }

                return MusteriListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }
        }

        public void Ekle(string MusteriTC,string MusteriAdi,string MusteriSoyadi,string MusteriCinsiyet,string MusteriTel,string MusteriMail,string MusteriSifre,string MusteriYetki = "normal")
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Musteriler (MusteriTC,MusteriAdi,MusteriSoyadi,MusteriCinsiyet,MusteriTel,MusteriMail,MusteriSifre,MusteriYetki) Values (" + MusteriTC + ",'" + MusteriAdi + "','" + MusteriSoyadi + "','" + MusteriCinsiyet + "','" + MusteriTel + "','" + MusteriMail + "','" + MusteriSifre + "','" + MusteriYetki + "')";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }

        public void Guncelle(Musteriler MevcutMusteri, string MusteriTC, string MusteriAdi, string MusteriSoyadi, string MusteriCinsiyet, string MusteriTel, string MusteriMail,  string MusteriYetki = "normal")
        {
            try
            {
                dbcon.cmd.CommandText = "Update Musteriler SET MusteriTC='" + MusteriTC + "',MusteriAdi='" + MusteriAdi + "',MusteriSoyadi='" + MusteriSoyadi + "',MusteriCinsiyet='" + MusteriCinsiyet + "',MusteriTel='" + MusteriTel + "',MusteriMail='" + MusteriMail + "',MusteriYetki='" + MusteriYetki + "' Where MusteriID=" + MevcutMusteri.MusteriID + "";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }

        }

        public void Sil(Musteriler m)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Musteriler Where MusteriID=" + m.MusteriID + "";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }
        }

    }
}

