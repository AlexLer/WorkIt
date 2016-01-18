using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WorkIt.Model
{
    class DatabaseConnection
    {
        private string sql_string;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter da_1;

        public string Sql { set { sql_string = value; } }


        public string connection_string { set { strCon = value; } }


        public System.Data.DataSet GetConnection { get { return MyDataSet(); } }

        public int ExecuteSqlCommand()
        {
            int x = -1;

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = con;
                    comm.CommandText = sql_string;
                    try
                    {
                        con.Open();
                        x = comm.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        return -1;
                    }
                    
                    con.Close();
                }
            }

            return x;
        }

        private System.Data.DataSet MyDataSet()
        {
            strCon = Properties.Settings.Default.ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();

            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);

            System.Data.DataSet dat_set = new System.Data.DataSet();

            da_1.Fill(dat_set, "Table_Data_1");
            
            con.Close();
            return dat_set;
        }
    }
}
