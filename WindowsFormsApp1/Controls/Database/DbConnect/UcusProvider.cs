using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class UcusProvider
    {
        DbConnector dbcon = new DbConnector();
        public UcusProvider() {
            dbcon.Baglan();

        }
        public List<Ucuslar> Listele()
        {

            try
            {
                List<Ucuslar> UcusListesi = new List<Ucuslar>();
                dbcon.cmd.CommandText = "Select *From Ucuslar";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ucuslar k = new Ucuslar();
                    k.UcusID = Convert.ToInt32(reader[0].ToString());
                    k.SirketID = Convert.ToInt32(reader[1].ToString());
                    k.Nereden = Convert.ToInt32(reader[2].ToString());
                    k.Nereye = Convert.ToInt32(reader[3].ToString());
                    k.Tarih = DateTime.Parse(reader[4].ToString());
                    k.Fiyat = Convert.ToInt32(reader[5].ToString());
                    UcusListesi.Add(k);
                }

                return UcusListesi;
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

        public void Ekle(int SirketID,int Nereden,int Nereye,DateTime Tarih,int Fiyat)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Ucuslar (SirketID,Nereden,Nereye,Tarih,Fiyat) Values (" + SirketID + ",'" + Nereden + "','" + Nereye + "','" + Tarih + "','" + Fiyat + "')";
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

        public void Guncelle(Ucuslar MevcutUcus, int SirketID, int Nereden, int Nereye, DateTime Tarih, int Fiyat)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Ucuslar SET SirketID='" + SirketID + "',Nereden='" + Nereden + "',Nereye='" + Nereye + "',Tarih='" + Tarih + "',Fiyat='" + Fiyat + "' Where UcusID=" + MevcutUcus.UcusID + "";
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

        public void Sil(Ucuslar k)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Ucuslar Where UcusID=" + k.UcusID + "";
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
