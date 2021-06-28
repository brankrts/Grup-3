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
    class SehirlerProvider
    {
        SqlDataReader reader;
        DbConnector dbcon = new DbConnector();
        public SehirlerProvider()
        {
            dbcon.Baglan();

        }
        public List<Sehirler> Listele()
        {

            try
            {
                List<Sehirler> SehirListesi = new List<Sehirler>();
                dbcon.cmd.CommandText = "Select *From Sehirler";
                dbcon.cmd.CommandType = CommandType.Text;
                dbcon.con.Open();
                SqlDataReader reader = dbcon.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehirler s = new Sehirler();
                    s.SehirID = Convert.ToInt32(reader[0].ToString());
                    s.SehirAdi = reader[1].ToString();
                    
                    SehirListesi.Add(s);
                }

                return SehirListesi;
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
        public int GetID(string SehirAdi) {
            int ID;
            try
            {

                dbcon.cmd = new SqlCommand("SELECT SehirID FROM [Sehirler] where SehirAdi=@SehirAdi", dbcon.con);
                dbcon.cmd.Parameters.AddWithValue("@SehirAdi", SehirAdi);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                reader.Read();
                ID =Convert.ToInt32(reader["SehirID"]);
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
        public void Ekle(string SehirAdi)
        {
            try
            {
                dbcon.cmd.CommandText = "Insert Into Sehirler (SehirAdi) Values (" + SehirAdi +"')";
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

        public void Guncelle(Sehirler sehir, string SehirAdi)
        {
            try
            {
                dbcon.cmd.CommandText = "Update Sehirler SET SehirAdi='" + SehirAdi +  "' Where SehirID=" + sehir.SehirID + "";
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

        public void Sil(Sehirler s)
        {
            try
            {
                dbcon.cmd.CommandText = "Delete From Sehirler Where SehirID=" + s.SehirID + "";
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
        public void ListOfSehirler (Guna.UI2.WinForms.Guna2ComboBox cmbSehirler){
            try
            {
                
                dbcon.cmd = new SqlCommand("SELECT * FROM [Sehirler]", dbcon.con);
                dbcon.con.Open();
                reader = dbcon.cmd.ExecuteReader();
                

                while (reader.Read())
                {

                    cmbSehirler.Items.Add(reader["SehirAdi"]);
                 
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
    }
}
