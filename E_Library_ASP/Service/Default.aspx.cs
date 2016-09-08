using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Service
{

 
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string strURL="", strISBN;
            strISBN = txtDefault.Text.ToString();
            strISBN = strISBN.Trim();
           // strURL = "http://yahoo.com";
            if (strISBN != "")
            {
                try
                {
                    strURL = SearchInDB.getURL(strISBN);
                }
                catch (Exception)
                {
                    strURL = "No connection to Database";
                }
            }
            else
            {
                HyperLink1.Text = "";
                HyperLink1.NavigateUrl = "";
            }
            if (strURL != "")
            {
                HyperLink1.Text = strURL;
                HyperLink1.NavigateUrl = strURL;
            }
            else
            {
                HyperLink1.Text = "Sorry, we have not found an e-book version!";
                HyperLink1.NavigateUrl = "";
            }
        }


    }
}
