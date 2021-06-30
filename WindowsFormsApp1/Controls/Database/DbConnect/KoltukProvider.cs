using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class KoltukProvider
    {
        string Cinsiyet;
        string KoltukNo;
        DbConnector dbcon = new DbConnector();
        SqlDataReader reader;
        CurrentValues Current = CurrentValues.Instance;
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
        public void GetID(int KoltukNO)
        {
            
            try
            {

                dbcon.cmd = new SqlCommand("SELECT KoltukID FROM [Koltuklar] where KoltukNO=@KoltukNO", dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@KoltukNO", KoltukNO);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                reader.Read();
                Current.KoltukID = Convert.ToInt32(reader["KoltukID"]);
                



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
        public void KoltukRenkListele(Guna2CircleButton button,Panel panel,int UcusID)
        {
            string komut = "SELECT Koltuklar.KoltukNo,Musteriler.MusteriCinsiyet " +
                            "from Biletler " +
                           " inner join Ucuslar on Biletler.UcusID = Ucuslar.UcusID " +
                           " inner join Musteriler on Biletler.MusteriID = Musteriler.MusteriID " +
                            "inner join Koltuklar on Biletler.KoltukID = Koltuklar.KoltukID " +
                            "where Biletler.UcusID = @UcusID";

            try
            {

                dbcon.cmd = new SqlCommand(komut, dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@UcusID", UcusID);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                while (reader.Read()) {
                    Cinsiyet = reader["MusteriCinsiyet"].ToString();
                    KoltukNo = reader["KoltukNo"].ToString();
                    
                    foreach (Control x in panel.Controls)
                    {
                        if (x is Guna2CircleButton)
                        {
                            if (button.Text == KoltukNo)
                            {

                                if (Cinsiyet == "Erkek")
                                {
                                    button.FillColor = System.Drawing.Color.Blue;
                                    button.Enabled = false;
                                }
                                else
                                {
                                    button.FillColor = System.Drawing.Color.Purple;
                                    button.Enabled = false;
                                }

                            }

                        }
                    }





                }
                




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
        public void BildirimEkle(string Bildirim)
        {
            try
            {

                dbcon.cmd = new SqlCommand("INSERT INTO [Bildirimler] (Bildirim) values (@Bildirim)", dbcon.con);


                dbcon.cmd.Parameters.AddWithValue("@Bildirim", Bildirim);
                
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
        public void KoltukEkle(int UcusID, int MusteriID, int KoltukNo)
        {
            try
            {

                dbcon.cmd = new SqlCommand("INSERT INTO [Koltuklar] (UcusID,MusteriID,KoltukNo) values (@UcusID,@MusteriID,@KoltukNo)", dbcon.con);


                dbcon.cmd.Parameters.AddWithValue("@UcusID", UcusID);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                dbcon.cmd.Parameters.AddWithValue("@KoltukNo", KoltukNo);
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
