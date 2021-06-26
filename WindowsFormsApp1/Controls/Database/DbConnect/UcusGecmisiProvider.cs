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
    class UcusGecmisiProvider
    {

        DbConnector dbcon = new DbConnector();
        public UcusGecmisiProvider()
        {
            dbcon.Baglan();

        }
        public List<Ucus_Gecmisi> Listele()
        {

            try
            {
                List<Ucus_Gecmisi> UcusGecmisiListesi = new List<Ucus_Gecmisi>();
                dbcon.cmd.CommandText = "Select *From Ucus_Gecmisi";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ucus_Gecmisi u = new Ucus_Gecmisi();
                    u.GecmisID = Convert.ToInt32(reader[0].ToString());
                    u.MusteriID = Convert.ToInt32(reader[1].ToString());
                    u.UcusID = Convert.ToInt32(reader[2].ToString());
                    u.KoltukID = Convert.ToInt32(reader[3].ToString());
                    UcusGecmisiListesi.Add(u);
                }

                return UcusGecmisiListesi;
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

        public void Ekle(int MusteriID, int UcusID, int KoltukID)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Ucus_Gecmisi (MusteriID,UcusID,KoltukID) Values (" + MusteriID + ",'" + UcusID + "','" + KoltukID + "')";
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

        public void Guncelle(Ucus_Gecmisi Gecmis, int MusteriID, int UcusID, int KoltukID)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Ucus_Gecmisi SET MusteriID='" + MusteriID + "',UcusID='" + UcusID + "',KoltukID='" + KoltukID + "' Where GecmisID=" + Gecmis.GecmisID + "";
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

        public void Sil(Ucus_Gecmisi u)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Ucus_Gecmisi Where GecmisID=" + u.GecmisID + "";
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
