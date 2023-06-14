using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public class db
    {
        protected SqlConnection getConnection()
        {
            // this is the connection string
            SqlConnection con = new SqlConnection(@"Data Source=31.147.204.119;Initial Catalog=RWA23_jvuk21_DB;User ID=jvuk21;Password={b|9VVcL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

           // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=RWA23;Integrated Security=True");

            return con;
        }

        // this function will return the data as a result of the query
        
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // here we have filled the dataset object with the data
            // coming formthe database
            da.Fill(ds);

            con.Close();
            return ds;
        }

        // function to set the data

        public void setData(string query, string message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            //  passing the connection  in the cmd;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
