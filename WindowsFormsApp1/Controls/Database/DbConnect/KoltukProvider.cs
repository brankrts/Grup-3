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
    class KoltukProvider
    {
        DbConnector dbcon = new DbConnector();
        public KoltukProvider()
        {
            dbcon.Baglan();

        }
        public List<Koltuklar> Listele()
        {

            try
            {
                List<Koltuklar> KoltukListesi = new List<Koltuklar>();
                dbcon.cmd.CommandText = "Select *From Koltuklar";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Koltuklar k = new Koltuklar();
                    k.KoltukID = Convert.ToInt32(reader[0].ToString());
                    k.UcusID = Convert.ToInt32(reader[1].ToString());
                    k.MusteriID = Convert.ToInt32(reader[2].ToString());
                    k.KoltukNo = Convert.ToInt32(reader[3].ToString());
                    KoltukListesi.Add(k);
                }

                return KoltukListesi;
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

        public void Ekle(int UcusID, int MusteriID, int KoltukNO)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Koltuklar (UcusID,MusteriID,KoltukNo) Values (" + UcusID + ",'" + MusteriID + "','" + KoltukNO + "')";
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

        public void Guncelle(Koltuklar Koltuk, int UcusID, int MusteriID, int KoltukNo)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Koltuklar SET UcusID='" + UcusID + "',MusteriID='" + MusteriID + "',KoltukNo='" + KoltukNo +  "' Where KoltukID=" + Koltuk.KoltukID + "";
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

        public void Sil(Koltuklar k)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Koltuklar Where KoltukID=" + k.KoltukID + "";
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
