using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Controls.Database.DbConnect
{
    class DbConnector
    {
        public SqlConnection con;
        public SqlCommand cmd;

        public DbConnector() 
        {
            Baglan();
        }

        public void Baglan()
        {
            con = new SqlConnection("server=.; Initial Catalog=db_Flight;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }



    }
}
