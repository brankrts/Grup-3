using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controls.Database.DbConnect;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Bunifu.Framework.UI;

namespace WindowsFormsApp1.Controls.Database
{
    class MusteriProvider
        
{
        CurrentValues current = CurrentValues.Instance;
        DbConnector dbcon = new DbConnector();
        SqlDataReader reader;
        
        
        public MusteriProvider() 
        {
            dbcon.Baglan();
        }
        //public List<Musteriler> Listele()
        //{
            
        //    try
        //    {
        //        List<Musteriler> MusteriListesi = new List<Musteriler>();
        //        dbcon.cmd.CommandText = "Select *From Musteriler";
        //        dbcon.cmd.CommandType = CommandType.Text;
        //        dbcon.con.Open();
        //        reader = dbcon.cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            //Musteriler m = new Musteriler();
        //            m.MusteriID = Convert.ToInt32(reader[0].ToString());
        //            m.TC = reader[1].ToString();
        //            m.MusteriAdi = reader[2].ToString();
        //            m.MusteriSoyadi = reader[3].ToString();
        //            m.MusteriCinsiyet = reader[4].ToString();
        //            m.MusteriTel = reader[5].ToString();
        //            m.MusteriMail = reader[6].ToString();
        //            m.MusteriSifre = reader[7].ToString();
        //            m.MusteriYetki = reader[8].ToString();
        //            MusteriListesi.Add(m);
        //        }

        //        return MusteriListesi;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (dbcon.con != null)
        //        {
        //            dbcon.con.Close();
        //        }
        //    }
        //}
        public void Ekle(string MusteriTC,string MusteriAdi,string MusteriSoyadi,string MusteriCinsiyet,string MusteriTel,string MusteriMail,string MusteriSifre,string MusteriYetki = "normal")
        {
            try
            {
                
                dbcon.cmd = new SqlCommand("INSERT INTO [Musteriler] (MusteriTC,MusteriAdi,MusteriSoyadi,MusteriCinsiyet,MusteriTel,MusteriMail,MusteriSifre,MusteriYetki) values (@MusteriTC,@MusteriAdi,@MusteriSoyadi,@MusteriCinsiyet,@MusteriTel,@MusteriMail,@MusteriSifre,@MusteriYetki)", dbcon.con);


                dbcon.cmd.Parameters.AddWithValue("@MusteriTC", MusteriTC);
                dbcon.cmd.Parameters.AddWithValue("@MusteriAdi", MusteriAdi);
                dbcon.cmd.Parameters.AddWithValue("@MusteriSoyadi", MusteriSoyadi);
                dbcon.cmd.Parameters.AddWithValue("@MusteriCinsiyet", MusteriCinsiyet);
                dbcon.cmd.Parameters.AddWithValue("@MusteriTel", MusteriTel);
                dbcon.cmd.Parameters.AddWithValue("@MusteriMail", MusteriMail);
                dbcon.cmd.Parameters.AddWithValue("@MusteriSifre", MusteriSifre);
                dbcon.cmd.Parameters.AddWithValue("@MusteriYetki", MusteriYetki);
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
        public void Guncelle(int MusteriID,string MusteriAdi, string MusteriSoyadi, string MusteriTel, string MusteriMail)
        {
            try
            {

                dbcon.cmd = new SqlCommand("UPDATE Musteriler SET (MusteriAdi,MusteriSoyadi,MusteriTel,MusteriMail) VALUES (@MusteriAdi,@MusteriSoyadi,@MusteriTel,@MusteriMail) WHERE MusteriID=@MusteriID", dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                dbcon.cmd.Parameters.AddWithValue("@MusteriAdi", MusteriAdi); 
                dbcon.cmd.Parameters.AddWithValue("@MusteriSoyadi", MusteriSoyadi);
                dbcon.cmd.Parameters.AddWithValue("@MusteriTel", MusteriTel);
                dbcon.cmd.Parameters.AddWithValue("@MusteriMail", MusteriMail);
                dbcon.con.Open();
                dbcon.cmd.ExecuteNonQuery();

            }
            catch (Exception )
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

        public bool Login(GunaLineTextBox txtTC,GunaLineTextBox txtPassowrd) {


            try
            {
                dbcon.cmd = new SqlCommand("SELECT MusteriID FROM [Musteriler] where MusteriTC=@MusteriTC AND MusteriSifre=@MusteriSifre", dbcon.con);

                dbcon.cmd.Parameters.AddWithValue("@MusteriTC", txtTC.Text);
                dbcon.cmd.Parameters.AddWithValue("@MusteriSifre", txtPassowrd.Text);
                dbcon.con.Open();

                reader = dbcon.cmd.ExecuteReader();
                if (reader.Read())
                {   
                    current.MusteriID = Convert.ToInt32(reader["MusteriID"]);
                    
                    return true;
                    

                }
                else { return false; }
            }
            catch (Exception )
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
        public void HesabBilgileri(int MusteriID,BunifuMaterialTextbox txtAdi, BunifuMaterialTextbox txtSoyadi, BunifuMaterialTextbox txtTel, BunifuMaterialTextbox txtMail )
        {
            

            try
            {

                string select =
                    "SELECT MusteriAdi,MusteriSoyadi,MusteriCinsiyet,MusteriTel,MusteriMail " +
                    "FROM Musteriler " +
                    "WHERE MusteriID=@MusteriID ";

                dbcon.cmd = new SqlCommand(select, dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                dbcon.con.Open();

                reader = dbcon.cmd.ExecuteReader();
                reader.Read();
                txtAdi.Text = reader["MusteriAdi"].ToString();
                txtSoyadi.Text = reader["MusteriSoyadi"].ToString();
                txtTel.Text = reader["MusteriTel"].ToString();
                txtMail.Text = reader["MusteriMail"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dbcon.con != null)
                {
                    dbcon.con.Close();
                }
            }





        }
        public int GetID(string MusteriTC)
        {
            int ID;
            try
            {

                dbcon.cmd = new SqlCommand("SELECT MusteriID FROM [Musteriler] where MusteriID=@MusteriID", dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriTC);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                reader.Read();
                ID = Convert.ToInt32(reader["MusteriID"]);
                return ID;




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
        public bool IsMaster(int MusteriID) {

            
            

             dbcon.cmd = new SqlCommand("SELECT MusteriYetki FROM [Musteriler] where MusteriID=@MusteriID ", dbcon.con);
             dbcon.cmd.Parameters.AddWithValue("@MusteriID", MusteriID) ;
             dbcon.con.Open();
             reader = dbcon.cmd.ExecuteReader();
            reader.Read();
            if (reader[0].ToString() == "master") {

                return true;
            
            
             
             }
             else { return false; }
            
           



            
        }

    }
}

