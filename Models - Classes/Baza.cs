using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinancialManager_VukJan.Models___Classes
{
    public class Baza
    {
        protected SqlConnection getConnection()
        {
            SqlConnection connect = new SqlConnection(@"Data source=31.147.204.119;Initial Catalog=RWA23_jvuk21_DB;User ID=jvuk21;Password={b|9VVcL;
                        Connect Timeout=30;Encrypt=False;");

            return connect;
        }

        public DataSet getData(string query)
        {
            SqlConnection connect = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
           
            da.Fill(ds);
            
            connect.Close();
            return ds;
        }


        public void setData(string query, string message)
        {
            SqlConnection connect = getConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connect;
            connect.Open();
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            connect.Close() ;

            MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

    }
}
