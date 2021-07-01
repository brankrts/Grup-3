using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;

namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class BiletlerProvider
    {
        SqlDataReader reader;
        CurrentValues Current = CurrentValues.Instance;
        DbConnector dbcon = new DbConnector();
        public BiletlerProvider()
        {
            dbcon.Baglan();

        }
        public List<Biletler> Listele()
        {

            try
            {
                List<Biletler> BiletListesi = new List<Biletler>();
                dbcon.cmd.CommandText = "Select *From Biletler";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Biletler b = new Biletler();
                    b.BiletID = Convert.ToInt32(reader[0].ToString());
                    b.UcusID = Convert.ToInt32(reader[1].ToString());
                    b.MusteriID = Convert.ToInt32(reader[2].ToString());
                    b.KoltukID = Convert.ToInt32(reader[3].ToString());
                    BiletListesi.Add(b);
                }

                return BiletListesi;
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
        public void GetID(int MusteriID)
        {

            try
            {

                dbcon.cmd = new SqlCommand("SELECT BiletID FROM [Bileter] where MusteriID=@MusteriID", dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                reader.Read();
                Current.BiletID = Convert.ToInt32(reader["BiletID"]);




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
        public void Ekle(int UcusID, int MusteriID, int KoltukID)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Biletler (UcusID,MusteriID,KoltukID) Values (" + UcusID + ",'" + MusteriID + "','" + KoltukID + "')";
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

        public void Guncelle(Biletler Bilet, int UcusID, int MusteriID, int KoltukID)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Koltuklar SET UcusID='" + UcusID + "',MusteriID='" + MusteriID + "',KoltukID='" + KoltukID + "' Where BiletID=" + Bilet.BiletID + "";
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
        public void BiletEkle(int UcusID,int MusteriID, int KoltukID)
        {
            try
            {

                dbcon.cmd = new SqlCommand("INSERT INTO [Biletler] (UcusID,MusteriID,KoltukID) values (@UcusID,@MusteriID,@KoltukID)", dbcon.con);


                dbcon.cmd.Parameters.AddWithValue("@UcusID", UcusID);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                dbcon.cmd.Parameters.AddWithValue("@KoltukID", KoltukID);
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
        public void Sil(Biletler b)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Biletler Where BiletID=" + b.BiletID + "";
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
