using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Service
{
    public class SearchInDB
    {

         
        public static String getURL(String pStrISBN)
        {


            String strReturn = "";
            System.Data.DataTable dt = new System.Data.DataTable();
            if (pStrISBN == "")
            {
                return strReturn;
            }
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UNSS1\8 семестър\klient_server\Client_Server_2\E_Library_ASP\Service\App_Data\findURLSQL.mdf;Integrated Security=True";


            // conn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\ Client_Server_2\\Services\\App_Data\\findURLSQL.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";


            using (conn)
            {
                SqlCommand cmd = new SqlCommand("Select URL, ISBN from tISBN where ISBN= '" + pStrISBN + "'", conn);
                try
                {
                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                    if (dt.Rows.Count == 0)
                    {
                        return strReturn;
                    }
                    strReturn = dt.Rows[0]["URL"].ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    strReturn = "";
                }
                return strReturn;
            }
        }
    }
}